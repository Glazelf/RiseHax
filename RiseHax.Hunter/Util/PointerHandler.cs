using SysBot.Base;
using System;
using System.Linq;

namespace RiseHax.Hunter
{
    public class PointerHandler
    {
#pragma warning disable CA1416 // Do not catch Win7 warning
        private static bool IsNum(char c) => (uint)(c - '0') <= 9;
        private static bool IsHexUpper(char c) => (uint)(c - 'A') <= 5;
        private static bool IsHexLower(char c) => (uint)(c - 'a') <= 5;

        /// <summary>
        /// Parses the hex string into a <see cref="uint"/>, skipping all characters except for valid digits.
        /// </summary>
        /// <param name="value">Hex String to parse</param>
        /// <returns>Parsed value</returns>
        public static uint GetHexValue(string value)
        {
            uint result = 0;
            if (string.IsNullOrEmpty(value))
                return result;

            foreach (var c in value)
            {
                if (IsNum(c))
                {
                    result <<= 4;
                    result += (uint)(c - '0');
                }
                else if (IsHexUpper(c))
                {
                    result <<= 4;
                    result += (uint)(c - 'A' + 10);
                }
                else if (IsHexLower(c))
                {
                    result <<= 4;
                    result += (uint)(c - 'a' + 10);
                }
            }
            return result;
        }

        public static ulong GetPointerAddress(ISwitchConnectionSync sb, string ptr)
        {
            uint finadd = 0;
            if (!ptr.EndsWith("]"))
                finadd = GetHexValue(ptr.Split('+').Last());
            var heap = sb.GetHeapBase();
            var jumps = ptr.Replace("main", "").Replace("heap", "").Replace("[", "").Replace("]", "").Split(new[] { "+" }, StringSplitOptions.RemoveEmptyEntries);

            var initaddress = GetHexValue(jumps[0].Trim());
            ulong address;
            if (ptr.Contains("heap"))
            {
                address = BitConverter.ToUInt64(sb.ReadBytes(initaddress, 0x8), 0);
            }
            else
            {
                address = BitConverter.ToUInt64(sb.ReadBytesMain(initaddress, 0x8), 0);
            }
            foreach (var j in jumps)
            {
                var val = GetHexValue(j.Trim());
                if (val == initaddress)
                    continue;
                if (val == finadd)
                {
                    address += val;
                    break;
                }
                address = BitConverter.ToUInt64(sb.ReadBytesAbsolute(address + val, 0x8), 0);

            }
            return address;
        }

        public static void WritePointer(ISwitchConnectionSync sb, string ptr, byte[] data)
        {
            uint finadd = 0;
            if (!ptr.EndsWith("]"))
                finadd = GetHexValue(ptr.Split('+').Last());
            var heap = sb.GetHeapBase();
            var jumps = ptr.Replace("main", "").Replace("heap", "").Replace("[", "").Replace("]", "").Split(new[] { "+" }, StringSplitOptions.RemoveEmptyEntries);

            var initaddress = GetHexValue(jumps[0].Trim());
            ulong address;
            if (ptr.Contains("heap"))
            {
                address = BitConverter.ToUInt64(sb.ReadBytes(initaddress, 0x8), 0);
            }
            else
            {
                address = BitConverter.ToUInt64(sb.ReadBytesMain(initaddress, 0x8), 0);
            }
            foreach (var j in jumps)
            {
                var val = GetHexValue(j.Trim());
                if (val == initaddress)
                    continue;
                if (val == finadd)
                {
                    address += val;
                    break;
                }
                address = BitConverter.ToUInt64(sb.ReadBytesAbsolute(address + val, 0x8), 0);
            }
            if (ptr.Contains("heap"))
            {
                sb.WriteBytes(data, initaddress);
            }
            else
            {
                sb.WriteBytesMain(data, address);
            }
        }

        public static ulong ConvertLittleEndian(byte[] array)
        {
            int pos = 0;
            ulong result = 0;
            foreach (byte by in array)
            {
                result |= ((ulong)by) << pos;
                pos += 8;
            }
            return result;
        }
    }
}

using SysBot.Base;
using System;

namespace RiseHax.Hunter
{
    public class BytesHandler
    {
        public static byte[] CombineArrays(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }

        public static void WriteUInt(uint input, ulong offset, ISwitchConnectionSync sb)
        {
            byte value = Convert.ToByte(input);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            sb.WriteBytesAbsolute(byteArray, offset);
            return;
        }

        public static void WriteFloat(float input, ulong offset, ISwitchConnectionSync sb)
        {
            byte[] Bytes = BitConverter.GetBytes(input);
            sb.WriteBytesAbsolute(Bytes, offset);
        }
    }
}

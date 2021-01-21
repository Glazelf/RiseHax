using System;
using System.Windows.Forms;
using RiseHax.Injection;
using RiseHax.WinForms.Properties;

namespace RiseHax.WinForms
{
    public class SysBotController
    {
        public SysBotController(InjectionType type) => Type = type;

        private readonly InjectionType Type;
        public readonly SysBot Bot = new();
        private readonly Settings Settings = Settings.Default;

        public string IP => Settings.SysBotIP;
        public string Port => Settings.SysBotPort.ToString();

        public bool Connect(string ip, string port)
        {
            if (!int.TryParse(port, out var p))
                p = 6000;

            try
            {
                Bot.Connect(ip, p);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                return false;
            }

            var settings = Settings;
            settings.SysBotIP = ip;
            settings.SysBotPort = p;
            settings.Save();

            return true;
        }

        public void WriteBytes(byte[] data, uint offset)
        {
            Bot.WriteBytes(data, offset);
        }

        public byte[] ReadBytes(uint offset, int length)
        {
            var result = Bot.ReadBytes(offset, length);
            return result;
        }
    }
}
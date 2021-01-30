using RiseHax.Core;
using RiseHax.Hunter;
using RiseHax.Injection;
using System;
using System.Windows.Forms;

namespace RiseHax.WinForms
{
    public partial class SysBotUI : Form
    {
#pragma warning disable CA1416 // Do not catch Win7 warning

        private static readonly string WorkingDirectory = Application.StartupPath;
        //private static readonly string ConfigPath = Path.Combine(WorkingDirectory, "config.json");


        public SysBotUI()
        {
            InitializeComponent();
        }

        public Injector SwitchInjector = new Injector();
        readonly SwitchConnectionConfig cfg = new SwitchConnectionConfig();
        readonly PointerHandler PointerHandler = new PointerHandler();
        public bool Connected = false;
        public ISwitchConnectionSync Connection;

        // Declare offsets
        ulong OffsetHunterHP;
        ulong OffsetHunterHPRecoverable;
        ulong OffsetHunterCoordX;
        ulong OffsetHunterCoordY;
        ulong OffsetHunterCoordZ;
        ulong OffsetHunterPouchItem1;
        ulong OffsetHunterPouchItem2;

        public void SysBotUI_Load(object sender, EventArgs e)
        {

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == false)
            {
                cfg.IP = TextBoxIP.Text;
                cfg.Port = Port;
                Connection = cfg.CreateSync();
                Connection.Connect();

                ReloadValues();
                // Toggle buttons and fields
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;
                // Player
                SysBotHunterCoordXCount.Enabled = true;
                SysBotHunterCoordYCount.Enabled = true;
                SysBotHunterCoordZCount.Enabled = true;
                // Quest
                SysBotMonsterHPCount.Enabled = true;
                SysBotHunterHPCount.Enabled = true;
                SysBotPouchItem1Count.Enabled = true;
                ButtonSysbotRead.Enabled = true;

                Connected = true;
                ButtonConnect.Text = "Diconnect";
            }
            else
            {
                Connection.Disconnect();
                // Toggle buttons and fields
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;
                // Player
                SysBotHunterCoordXCount.Enabled = false;
                SysBotHunterCoordYCount.Enabled = false;
                SysBotHunterCoordZCount.Enabled = false;
                // Quest
                SysBotMonsterHPCount.Enabled = false;
                SysBotHunterHPCount.Enabled = false;
                SysBotPouchItem1Count.Enabled = false;
                ButtonSysbotRead.Enabled = false;

                Connected = false;
                ButtonConnect.Text = "Connect";
            }
        }

        private void SysBotMonsterHPCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SysBotPouchMegaPotionCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SysBotHunterHPCount_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotHunterHPCount.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterHP);
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterHPRecoverable);
        }

        private void ButtonSysbotQuestRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        private void SysBotHunterCoordXCount_ValueChanged(object sender, EventArgs e)
        {
            float floatX = (float)SysBotHunterCoordXCount.Value;
            byte[] Bytes = BitConverter.GetBytes(floatX);
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoordX);
        }

        private void SysBotHunterCoordYCount_ValueChanged(object sender, EventArgs e)
        {
            float floatY = (float)SysBotHunterCoordYCount.Value;
            byte[] Bytes = BitConverter.GetBytes(floatY);
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoordY);
        }

        private void SysBotHunterCoordZCount_ValueChanged(object sender, EventArgs e)
        {
            float floatZ = (float)SysBotHunterCoordZCount.Value;
            byte[] Bytes = BitConverter.GetBytes(floatZ);
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoordZ);
        }

        private void ReloadValues()
        {
            ulong OffsetHunterHP = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHP);
            OffsetHunterHPRecoverable = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHPRecoverable);
            OffsetHunterCoordX = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterCoordX);
            OffsetHunterCoordY = OffsetHunterCoordX + 0x4;
            OffsetHunterCoordZ = OffsetHunterCoordX + 0x8;

            byte[] ByteArrayHunterCoordX = Connection.ReadBytesAbsolute(OffsetHunterCoordX, 4);
            byte[] ByteArrayHunterCoordY = Connection.ReadBytesAbsolute(OffsetHunterCoordY, 4);
            byte[] ByteArrayHunterCoordZ = Connection.ReadBytesAbsolute(OffsetHunterCoordZ, 4);
            float HunterCoordX = BitConverter.ToSingle(ByteArrayHunterCoordX, 0);
            float HunterCoordY = BitConverter.ToSingle(ByteArrayHunterCoordY, 0);
            float HunterCoordZ = BitConverter.ToSingle(ByteArrayHunterCoordZ, 0);

            uint HunterHP = Connection.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
            SysBotHunterHPCount.Value = HunterHP;
            SysBotHunterCoordXCount.Value = (decimal)HunterCoordX;
            SysBotHunterCoordYCount.Value = (decimal)HunterCoordY;
            SysBotHunterCoordZCount.Value = (decimal)HunterCoordZ;
        }

        // Currently unused since writing all coords at once is funky and reading them back out afterwards creates an infinite loop
        private void WriteCoords()
        {
            float floatX = (float)SysBotHunterCoordXCount.Value;
            float floatY = (float)SysBotHunterCoordYCount.Value;
            float floatZ = (float)SysBotHunterCoordZCount.Value;
            byte[] Bytes = ByteArrays.Combine(BitConverter.GetBytes(floatX), BitConverter.GetBytes(floatY), BitConverter.GetBytes(floatZ));
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoordX);
        }
    }
}
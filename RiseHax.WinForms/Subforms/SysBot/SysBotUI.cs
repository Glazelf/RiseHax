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
        ulong OffsetHunterPouchItem1;
        ulong OffsetHunterPouchItem2;
        ulong OffsetHunterPouchItem3;
        ulong OffsetHunterPouchItem4;
        ulong OffsetHunterPouchItem5;
        ulong OffsetHunterCoordX;
        ulong OffsetHunterCoordY;
        ulong OffsetHunterCoordZ;
        
        public void SysBotUI_Load(object sender, EventArgs e)
        {

        }

        // Connection and getting values
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == false)
            {
                // Connect button behaviour
                cfg.IP = TextBoxIP.Text;
                cfg.Port = Port;
                Connection = cfg.CreateSync();
                Connection.Connect();

                ReloadValues();
                // Toggle buttons and fields
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;
                ButtonSysbotRead.Enabled = true;
                // Player
                SysBotPouchItem1Count.Enabled = true;
                SysBotPouchItem2Count.Enabled = true;
                SysBotPouchItem3Count.Enabled = true;
                SysBotPouchItem4Count.Enabled = true;
                SysBotPouchItem5Count.Enabled = true;
                SysBotHunterCoordXCount.Enabled = true;
                SysBotHunterCoordYCount.Enabled = true;
                SysBotHunterCoordZCount.Enabled = true;
                // Quest
                SysBotMonsterHPCount.Enabled = true;
                SysBotHunterHPCount.Enabled = true;

                Connected = true;
                ButtonConnect.Text = "Diconnect";
            }
            else
            {
                // Disconnect button behaviour
                Connection.Disconnect();
                // Toggle buttons and fields
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;
                ButtonSysbotRead.Enabled = false;
                // Player
                SysBotPouchItem1Count.Enabled = false;
                SysBotPouchItem2Count.Enabled = false;
                SysBotPouchItem3Count.Enabled = false;
                SysBotPouchItem4Count.Enabled = false;
                SysBotPouchItem5Count.Enabled = false;
                SysBotHunterCoordXCount.Enabled = false;
                SysBotHunterCoordYCount.Enabled = false;
                SysBotHunterCoordZCount.Enabled = false;
                // Quest
                SysBotMonsterHPCount.Enabled = false;
                SysBotHunterHPCount.Enabled = false;

                Connected = false;
                ButtonConnect.Text = "Connect";
            }
        }
        private void ButtonSysbotRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        // HP writing
        private void SysBotMonsterHPCount_ValueChanged(object sender, EventArgs e)
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

        // Pouch item writing
        private void SysBotPouchItem1Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem1Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterPouchItem1);
        }

        private void SysBotPouchItem2Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem2Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterPouchItem2);
        }

        private void SysBotPouchItem3Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem3Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterPouchItem3);
        }

        private void SysBotPouchItem4Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem4Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterPouchItem4);
        }

        private void SysBotPouchItem5Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem5Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetHunterPouchItem5);
        }

        // Coordinate writing
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
            // Get offsets from pointers
            OffsetHunterHP = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHP);
            OffsetHunterHPRecoverable = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHPRecoverable);
            OffsetHunterPouchItem1 = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItem1);
            // Would preferably get all offsets from just the first item pointer
            OffsetHunterPouchItem2 = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItem2);
            OffsetHunterPouchItem3 = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItem3);
            OffsetHunterPouchItem4 = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItem4);
            OffsetHunterPouchItem5 = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItem5);
            // OffsetHunterPouchItem2 = OffsetHunterPouchItem1 + 0x08;
            // OffsetHunterPouchItem3 = OffsetHunterPouchItem1 + 0x10;
            // OffsetHunterPouchItem4 = OffsetHunterPouchItem1 + 0x18;
            // OffsetHunterPouchItem5 = OffsetHunterPouchItem1 + 0x20;
            OffsetHunterCoordX = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterCoordX);
            OffsetHunterCoordY = OffsetHunterCoordX + 0x4;
            OffsetHunterCoordZ = OffsetHunterCoordX + 0x8;

            // Pouch items
            uint PouchItem1Count = Connection.ReadBytesAbsolute(OffsetHunterPouchItem1, 1)[0];
            uint PouchItem2Count = Connection.ReadBytesAbsolute(OffsetHunterPouchItem2, 1)[0];
            uint PouchItem3Count = Connection.ReadBytesAbsolute(OffsetHunterPouchItem3, 1)[0];
            uint PouchItem4Count = Connection.ReadBytesAbsolute(OffsetHunterPouchItem4, 1)[0];
            uint PouchItem5Count = Connection.ReadBytesAbsolute(OffsetHunterPouchItem5, 1)[0];
            SysBotPouchItem1Count.Value = PouchItem1Count;
            SysBotPouchItem2Count.Value = PouchItem2Count;
            SysBotPouchItem3Count.Value = PouchItem3Count;
            SysBotPouchItem4Count.Value = PouchItem4Count;
            SysBotPouchItem5Count.Value = PouchItem5Count;

            //Coordinates
            byte[] ByteArrayHunterCoordX = Connection.ReadBytesAbsolute(OffsetHunterCoordX, 4);
            byte[] ByteArrayHunterCoordY = Connection.ReadBytesAbsolute(OffsetHunterCoordY, 4);
            byte[] ByteArrayHunterCoordZ = Connection.ReadBytesAbsolute(OffsetHunterCoordZ, 4);
            float HunterCoordX = BitConverter.ToSingle(ByteArrayHunterCoordX, 0);
            float HunterCoordY = BitConverter.ToSingle(ByteArrayHunterCoordY, 0);
            float HunterCoordZ = BitConverter.ToSingle(ByteArrayHunterCoordZ, 0);
            SysBotHunterCoordXCount.Value = (decimal)HunterCoordX;
            SysBotHunterCoordYCount.Value = (decimal)HunterCoordY;
            SysBotHunterCoordZCount.Value = (decimal)HunterCoordZ;

            // HP
            uint HunterHP = Connection.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
            SysBotHunterHPCount.Value = HunterHP;
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
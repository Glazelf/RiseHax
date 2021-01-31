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
        //private static readonly string ConfigPath = Path.CombineArrays(WorkingDirectory, "config.json");


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
        ulong[] OffsetPouchItemCounts;
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
            Connection.WriteBytesAbsolute(byteArray, OffsetPouchItemCounts[0]);
        }

        private void SysBotPouchItem2Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem2Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetPouchItemCounts[1]);
        }

        private void SysBotPouchItem3Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem3Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetPouchItemCounts[2]);
        }

        private void SysBotPouchItem4Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem4Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetPouchItemCounts[3]);
        }

        private void SysBotPouchItem5Count_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(SysBotPouchItem5Count.Value);
            byte[] byteArray = new byte[1];
            byteArray[0] = value;
            Connection.WriteBytesAbsolute(byteArray, OffsetPouchItemCounts[4]);
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
            // Would preferably get all offsets from just the first item pointer
            OffsetPouchItemCounts = GetItemPouchCounts();
            OffsetHunterCoordX = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterCoordX);
            OffsetHunterCoordY = OffsetHunterCoordX + 0x4;
            OffsetHunterCoordZ = OffsetHunterCoordX + 0x8;

            // Pouch items
            uint PouchItem1Count = Connection.ReadBytesAbsolute(OffsetPouchItemCounts[0], 1)[0];
            uint PouchItem2Count = Connection.ReadBytesAbsolute(OffsetPouchItemCounts[1], 1)[0];
            uint PouchItem3Count = Connection.ReadBytesAbsolute(OffsetPouchItemCounts[2], 1)[0];
            uint PouchItem4Count = Connection.ReadBytesAbsolute(OffsetPouchItemCounts[3], 1)[0];
            uint PouchItem5Count = Connection.ReadBytesAbsolute(OffsetPouchItemCounts[4], 1)[0];
            SysBotPouchItem1Count.Value = PouchItem1Count;
            SysBotPouchItem2Count.Value = PouchItem2Count;
            SysBotPouchItem3Count.Value = PouchItem3Count;
            SysBotPouchItem4Count.Value = PouchItem4Count;
            SysBotPouchItem5Count.Value = PouchItem5Count;

            //Coordinates
            float HunterCoordX = BitConverter.ToSingle(Connection.ReadBytesAbsolute(OffsetHunterCoordX, 4), 0);
            float HunterCoordY = BitConverter.ToSingle(Connection.ReadBytesAbsolute(OffsetHunterCoordY, 4), 0);
            float HunterCoordZ = BitConverter.ToSingle(Connection.ReadBytesAbsolute(OffsetHunterCoordZ, 4), 0);
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
            byte[] Bytes = BytesHandler.CombineArrays(BitConverter.GetBytes(floatX), BitConverter.GetBytes(floatY), BitConverter.GetBytes(floatZ));
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoordX);
        }

        private ulong[] GetItemPouchCounts()
        {
            int numHunterItems = 24;

            ulong[] itemCountAddresses = new ulong[numHunterItems];
            ulong pouchAdress = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerPouchItems);
            for (uint i = 0; i < numHunterItems; i++)
            {
                itemCountAddresses[i] = pouchAdress + i * 0x60;
            }
            return itemCountAddresses;
        }
    }
}
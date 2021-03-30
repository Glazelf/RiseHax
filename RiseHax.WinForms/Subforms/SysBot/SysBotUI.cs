using RiseHax.Hunter;
using RiseHax.Injection;
using SysBot.Base;
using System;
using System.Drawing;
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
        public ISwitchConnectionSync sb;

        // Declare offsets
        ulong OffsetHunterHP;
        ulong OffsetHunterHPRecoverable;
        ulong[] OffsetPouchItemCounts;
        ulong OffsetHunterCoordX;
        ulong OffsetHunterCoordY;
        ulong OffsetHunterCoordZ;
        ulong OffsetMonster1HP;

        public void SysBotUI_Load(object sender, EventArgs e)
        {

        }

        // sb and getting values
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == false)
            {
                // Connect button behaviour
                cfg.IP = TextBoxIP.Text;
                cfg.Port = Port;
                sb = cfg.CreateSync();
                sb.Connect();

                ReloadValues();
                // Toggle buttons and fields
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;
                ButtonSysbotRead.Enabled = true;

                StatusConnection.ForeColor = Color.Green;
                StatusConnection.Text = "Connected";
                Connected = true;
                ButtonConnect.Text = "Disconnect";
                SysBotLog.Text += Environment.NewLine + "Successfully connected.";
            }
            else
            {
                // Disconnect button behaviour
                sb.Disconnect();
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
                SysBotHunterHPCount.Enabled = false;
                SysBotHunterStaminaCount.Enabled = false;
                SysBotMonster1HPCount.Enabled = false;

                StatusConnection.ForeColor = Color.Red;
                StatusConnection.Text = "Disconnected";
                Connected = false;
                ButtonConnect.Text = "Connect";
                SysBotLog.Text += Environment.NewLine + "Successfully disconnected.";
            }
        }
        private void ButtonSysbotRead_Click(object sender, EventArgs e)
        {
            ReloadValues();
        }

        // HP writing
        private void SysBotMonster1HPCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotMonster1HPCount.Value, OffsetMonster1HP, sb);
        }

        private void SysBotHunterHPCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotHunterHPCount.Value, OffsetHunterHP, sb);
            BytesHandler.WriteUInt((uint)SysBotHunterHPCount.Value, OffsetHunterHPRecoverable, sb);
        }

        // Pouch item writing
        private void SysBotPouchItem1Count_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPouchItem1Count.Value, OffsetPouchItemCounts[0], sb);
        }

        private void SysBotPouchItem2Count_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPouchItem2Count.Value, OffsetPouchItemCounts[1], sb);
        }

        private void SysBotPouchItem3Count_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPouchItem3Count.Value, OffsetPouchItemCounts[2], sb);
        }

        private void SysBotPouchItem4Count_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPouchItem4Count.Value, OffsetPouchItemCounts[3], sb);
        }

        private void SysBotPouchItem5Count_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPouchItem5Count.Value, OffsetPouchItemCounts[4], sb);
        }

        // Coordinate writing
        private void SysBotHunterCoordXCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotHunterCoordXCount.Value, OffsetHunterCoordX, sb);
        }

        private void SysBotHunterCoordYCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotHunterCoordYCount.Value, OffsetHunterCoordY, sb);
        }

        private void SysBotHunterCoordZCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotHunterCoordZCount.Value, OffsetHunterCoordZ, sb);
        }

        private void ReloadValues()
        {
            //// Get offsets from pointers
            // Hunter HP
            try
            {
                OffsetHunterHP = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerHunterHP);
                OffsetHunterHPRecoverable = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerHunterHPRecoverable);
                uint HunterHP = sb.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
                SysBotHunterHPCount.Value = HunterHP;
                SysBotHunterHPCount.Enabled = true;
            }
            catch (Exception)
            {
                SysBotHunterHPCount.Enabled = false;
            }
            // Pouch
            try
            {
                // Pouch, would preferably get all offsets from just the first item pointer
                OffsetPouchItemCounts = GetItemPouchCounts();
                uint PouchItem1Count = sb.ReadBytesAbsolute(OffsetPouchItemCounts[0], 1)[0];
                uint PouchItem2Count = sb.ReadBytesAbsolute(OffsetPouchItemCounts[1], 1)[0];
                uint PouchItem3Count = sb.ReadBytesAbsolute(OffsetPouchItemCounts[2], 1)[0];
                uint PouchItem4Count = sb.ReadBytesAbsolute(OffsetPouchItemCounts[3], 1)[0];
                uint PouchItem5Count = sb.ReadBytesAbsolute(OffsetPouchItemCounts[4], 1)[0];
                SysBotPouchItem1Count.Value = PouchItem1Count;
                SysBotPouchItem2Count.Value = PouchItem2Count;
                SysBotPouchItem3Count.Value = PouchItem3Count;
                SysBotPouchItem4Count.Value = PouchItem4Count;
                SysBotPouchItem5Count.Value = PouchItem5Count;
                SysBotPouchItem1Count.Enabled = true;
                SysBotPouchItem2Count.Enabled = true;
                SysBotPouchItem3Count.Enabled = true;
                SysBotPouchItem4Count.Enabled = true;
                SysBotPouchItem5Count.Enabled = true;
            }
            catch (Exception)
            {
                SysBotPouchItem1Count.Enabled = false;
                SysBotPouchItem2Count.Enabled = false;
                SysBotPouchItem3Count.Enabled = false;
                SysBotPouchItem4Count.Enabled = false;
                SysBotPouchItem5Count.Enabled = false;
            }
            // Coordinates
            try
            {
                OffsetHunterCoordX = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerHunterCoordX);
                OffsetHunterCoordY = OffsetHunterCoordX + 0x4;
                OffsetHunterCoordZ = OffsetHunterCoordX + 0x8;
                float HunterCoordX = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetHunterCoordX, 4), 0);
                float HunterCoordY = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetHunterCoordY, 4), 0);
                float HunterCoordZ = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetHunterCoordZ, 4), 0);
                SysBotHunterCoordXCount.Value = (decimal)HunterCoordX;
                SysBotHunterCoordYCount.Value = (decimal)HunterCoordY;
                SysBotHunterCoordZCount.Value = (decimal)HunterCoordZ;
                SysBotHunterCoordXCount.Enabled = true;
                SysBotHunterCoordYCount.Enabled = true;
                SysBotHunterCoordZCount.Enabled = true;
            }
            catch (Exception)
            {
                SysBotHunterCoordXCount.Enabled = false;
                SysBotHunterCoordYCount.Enabled = false;
                SysBotHunterCoordZCount.Enabled = false;
            }
            // Monsters
            try
            {
                OffsetMonster1HP = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerMonsters3HP);
                float Monster1HP = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetMonster1HP, 4), 0);
                SysBotMonster1HPCount.Value = (decimal)Monster1HP;
                SysBotMonster1HPCount.Enabled = true;
            }
            catch (Exception)
            {
                SysBotMonster1HPCount.Enabled = false;
            }

            SysBotLog.Text += Environment.NewLine + "Successfully loaded values.";
        }

        // Currently unused since writing all coords at once is funky and reading them back out afterwards creates an infinite loop
        private void WriteCoords()
        {
            float floatX = (float)SysBotHunterCoordXCount.Value;
            float floatY = (float)SysBotHunterCoordYCount.Value;
            float floatZ = (float)SysBotHunterCoordZCount.Value;
            byte[] Bytes = BytesHandler.CombineArrays(BitConverter.GetBytes(floatX), BitConverter.GetBytes(floatY), BitConverter.GetBytes(floatZ));
            sb.WriteBytesAbsolute(Bytes, OffsetHunterCoordX);
        }

        private ulong[] GetItemPouchCounts()
        {
            int numHunterItems = 24;

            ulong[] itemCountAddresses = new ulong[numHunterItems];
            ulong pouchAddress = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerPouchItems);
            for (uint i = 0; i < numHunterItems; i++)
            {
                itemCountAddresses[i] = pouchAddress + i * 0x60;
            }
            return itemCountAddresses;
        }
    }
}
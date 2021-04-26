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
        ulong OffsetHunterHPMax;
        ulong OffsetHunterHPRecoverable;
        ulong OffsetVillageQuestCount;
        ulong OffsetLowRankQuestCount;
        ulong OffsetHighRankQuestCount;
        ulong OffsetRampageQuestCount;
        ulong OffsetArenaQuestCount;
        ulong OffsetSlainTotal;
        ulong OffsetCapturedTotal;
        ulong OffsetPlaytime;
        ulong[] OffsetPouchItemCounts;
        ulong OffsetHunterCoordX;
        ulong OffsetHunterCoordY;
        ulong OffsetHunterCoordZ;
        ulong OffsetMonster1HP;
        ulong OffsetZeni;
        ulong OffsetPoints;

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
                SysBotZeniCount.Enabled = false;
                SysBotPointsCount.Enabled = false;
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
            BytesHandler.WriteUInt(GlobalVariables.MaxHP, OffsetHunterHPMax, sb);
        }

        // Activity Log writing
        private void SysBotVillageQuestCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotVillageQuestCount.Value, OffsetVillageQuestCount, sb);
        }

        private void SysBotLowRankQuestCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotLowRankQuestCount.Value, OffsetLowRankQuestCount, sb);
        }

        private void SysBotHighRankQuestCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotHighRankQuestCount.Value, OffsetHighRankQuestCount, sb);
        }

        private void SysBotRampageQuestCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotRampageQuestCount.Value, OffsetRampageQuestCount, sb);
        }

        private void SysBotArenaQuestCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotArenaQuestCount.Value, OffsetArenaQuestCount, sb);
        }

        private void SysBotSlainTotalCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotSlainTotalCount.Value, OffsetSlainTotal, sb);
        }

        private void SysBotCapturedTotalCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotCapturedTotalCount.Value, OffsetCapturedTotal, sb);
        }

        private void SysBotPlaytimeCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteUInt((uint)SysBotPlaytimeCount.Value, OffsetPlaytime, sb);
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

        private void SysBotZeniCount_ValueChanged(object sender, EventArgs e)
        {
            BytesHandler.WriteFloat((float)SysBotZeniCount.Value, OffsetZeni, sb);
        }
        private void SysBotPointsCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReloadValues()
        {
            //// Get offsets from pointers
            // Player
            try
            {
                OffsetHunterHP = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerHunterHP);
                OffsetHunterHPMax = OffsetHunterHP + DataOffsets.DistanceHPToHPMax;
                OffsetHunterHPRecoverable = OffsetHunterHP + DataOffsets.DistanceHPToRecoverable;
                uint HunterHP = sb.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
                SysBotHunterHPCount.Value = HunterHP;
                SysBotHunterHPCount.Enabled = true;
            }
            catch (Exception ex)
            {
                SysBotHunterHPCount.Enabled = false;
                LogError(ex);
            }
            try
            {
                OffsetZeni = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerZeni);
                float Zeni = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetZeni, 4), 0);
                SysBotZeniCount.Value = (decimal)Zeni;
                SysBotZeniCount.Enabled = true;
            }
            catch (Exception ex)
            {
                SysBotZeniCount.Enabled = false;
                LogError(ex);
            }
            // Activity Log
            try
            {
                OffsetVillageQuestCount = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog);
                OffsetLowRankQuestCount = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceActivityLog);
                OffsetHighRankQuestCount = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceActivityLog * 2);
                OffsetRampageQuestCount = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceActivityLog * 3);
                OffsetArenaQuestCount = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceActivityLog * 4);
                OffsetSlainTotal = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceSlainTotal);
                OffsetCapturedTotal = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistanceCapturedTotal);
                uint VillageQuestCount = sb.ReadBytesAbsolute(OffsetVillageQuestCount, 1)[0];
                uint LowRankQuestCount = sb.ReadBytesAbsolute(OffsetLowRankQuestCount, 1)[0];
                uint HighRankQuestCount = sb.ReadBytesAbsolute(OffsetHighRankQuestCount, 1)[0];
                uint RampageQuestCount = sb.ReadBytesAbsolute(OffsetRampageQuestCount, 1)[0];
                uint ArenaQuestCount = sb.ReadBytesAbsolute(OffsetArenaQuestCount, 1)[0];
                uint SlainTotal = sb.ReadBytesAbsolute(OffsetSlainTotal, 1)[0];
                uint CapturedTotal = sb.ReadBytesAbsolute(OffsetCapturedTotal, 1)[0];
                SysBotVillageQuestCount.Value = VillageQuestCount;
                SysBotLowRankQuestCount.Value = LowRankQuestCount;
                SysBotHighRankQuestCount.Value = HighRankQuestCount;
                SysBotRampageQuestCount.Value = RampageQuestCount;
                SysBotArenaQuestCount.Value = ArenaQuestCount;
                SysBotSlainTotalCount.Value = SlainTotal;
                SysBotCapturedTotalCount.Value = CapturedTotal;

                SysBotVillageQuestCount.Enabled = true;
                SysBotLowRankQuestCount.Enabled = true;
                SysBotHighRankQuestCount.Enabled = true;
                SysBotRampageQuestCount.Enabled = true;
                SysBotArenaQuestCount.Enabled = true;
                SysBotSlainTotalCount.Enabled = true;
                SysBotCapturedTotalCount.Enabled = true;

            }
            catch (Exception ex)
            {
                SysBotVillageQuestCount.Enabled = false;
                SysBotLowRankQuestCount.Enabled = false;
                SysBotHighRankQuestCount.Enabled = false;
                SysBotRampageQuestCount.Enabled = false;
                SysBotArenaQuestCount.Enabled = false;
                SysBotSlainTotalCount.Enabled = false;
                SysBotCapturedTotalCount.Enabled = false;
                SysBotPlaytimeCount.Enabled = false;
                LogError(ex);
            }
            // Playtime
            try
            {
                OffsetPlaytime = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerActivityLog + DataOffsets.DistancePlaytime);
                uint Playtime = sb.ReadBytesAbsolute(OffsetPlaytime, 1)[0];
                SysBotPlaytimeCount.Value = Playtime;
                SysBotPlaytimeCount.Enabled = true;
            }
            catch (Exception ex)
            {
                SysBotPlaytimeCount.Enabled = false;
                LogError(ex);
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
            catch (Exception ex)
            {
                SysBotPouchItem1Count.Enabled = false;
                SysBotPouchItem2Count.Enabled = false;
                SysBotPouchItem3Count.Enabled = false;
                SysBotPouchItem4Count.Enabled = false;
                SysBotPouchItem5Count.Enabled = false;
                LogError(ex);
            }
            // Coordinates
            try
            {
                OffsetHunterCoordX = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerHunterCoordX);
                OffsetHunterCoordY = OffsetHunterCoordX + DataOffsets.DistanceCoordinates;
                OffsetHunterCoordZ = OffsetHunterCoordX + DataOffsets.DistanceCoordinates * 2;
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
            catch (Exception ex)
            {
                SysBotHunterCoordXCount.Enabled = false;
                SysBotHunterCoordYCount.Enabled = false;
                SysBotHunterCoordZCount.Enabled = false;
                LogError(ex);
            }
            // Monsters
            try
            {
                OffsetMonster1HP = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerMonsters3HP);
                float Monster1HP = BitConverter.ToSingle(sb.ReadBytesAbsolute(OffsetMonster1HP, 4), 0);
                SysBotMonster1HPCount.Value = (decimal)Monster1HP;
                SysBotMonster1HPCount.Enabled = true;
            }
            catch (Exception ex)
            {
                SysBotMonster1HPCount.Enabled = false;
                LogError(ex);
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
            ulong pouchAddress = PointerHandler.GetPointerAddress(sb, DataOffsets.PointerPouchItem1) + DataOffsets.DistanceItemPouchTypeToCount;
            for (uint i = 0; i < numHunterItems; i++)
            {
                itemCountAddresses[i] = pouchAddress + i * DataOffsets.DistanceItemPouchCounts;
            }
            return itemCountAddresses;
        }
        public void LogError(Exception ex)
        {
            SysBotLog.Text += Environment.NewLine + $"{ex.Message}\n{ex.StackTrace}";
        }
    }
}
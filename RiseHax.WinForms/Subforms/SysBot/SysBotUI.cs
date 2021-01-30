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

        ulong OffsetHunterHP;
        ulong OffsetHunterHPRecoverable;
        ulong OffsetHunterCoords;

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
                QuestSysBotMonsterHPCount.Enabled = true;
                QuestSysBotHunterHPCount.Enabled = true;
                QuestSysBotPouchMegaPotionCount.Enabled = true;
                ButtonSysbotQuestRead.Enabled = true;
                QuestSysBotTriesRemaining.Enabled = true;

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
                QuestSysBotMonsterHPCount.Enabled = false;
                QuestSysBotHunterHPCount.Enabled = false;
                QuestSysBotPouchMegaPotionCount.Enabled = false;
                ButtonSysbotQuestRead.Enabled = false;
                QuestSysBotTriesRemaining.Enabled = false;

                Connected = false;
                ButtonConnect.Text = "Connect";
            }
        }

        private void QuestSysBotMonsterHPCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuestSysBotPouchMegaPotionCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void QuestSysBotHunterHPCount_ValueChanged(object sender, EventArgs e)
        {
            byte value = Convert.ToByte(QuestSysBotHunterHPCount.Value);
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
            WriteCoords();
        }

        private void SysBotHunterCoordYCount_ValueChanged(object sender, EventArgs e)
        {
            WriteCoords();
        }

        private void SysBotHunterCoordZCount_ValueChanged(object sender, EventArgs e)
        {
            WriteCoords();
        }

        private void ReloadValues()
        {
            OffsetHunterHP = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHP);
            OffsetHunterHPRecoverable = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHPRecoverable);
            OffsetHunterCoords = PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterCoords);

            byte[] ByteArrayHunterCoords = Connection.ReadBytesAbsolute(OffsetHunterCoords, 12);
            float HunterCoordX = BitConverter.ToSingle(ByteArrayHunterCoords, 0);
            float HunterCoordY = BitConverter.ToSingle(ByteArrayHunterCoords, 4);
            float HunterCoordZ = BitConverter.ToSingle(ByteArrayHunterCoords, 8);

            uint HunterHP = Connection.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
            QuestSysBotHunterHPCount.Value = HunterHP;
            SysBotHunterCoordXCount.Value = (decimal)HunterCoordX;
            SysBotHunterCoordYCount.Value = (decimal)HunterCoordY;
            SysBotHunterCoordZCount.Value = (decimal)HunterCoordZ;
        }

        private void WriteCoords()
        {
            float floatX = (float)SysBotHunterCoordXCount.Value;
            float floatY = (float)SysBotHunterCoordYCount.Value;
            float floatZ = (float)SysBotHunterCoordZCount.Value;
            byte[] Bytes = ByteArrays.Combine(BitConverter.GetBytes(floatX), BitConverter.GetBytes(floatY), BitConverter.GetBytes(floatZ));
            Connection.WriteBytesAbsolute(Bytes, OffsetHunterCoords);
        }
    }
}
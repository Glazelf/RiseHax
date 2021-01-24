using Newtonsoft.Json;
using RiseHax.Core;
using RiseHax.Injection;
using RiseHax.Hunter;
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
                uint OffsetHunterHP = (uint)PointerHandler.GetPointerAddress(Connection, DataOffsets.PointerHunterHP);
                byte[] byteArray = Connection.ReadBytesAbsolute(OffsetHunterHP, 4);
                uint HunterHP = Connection.ReadBytesAbsolute(OffsetHunterHP, 1)[0];
                SysBotLog.Text += " " +HunterHP.ToString();

                //byte[] MegaPotionByte = Connection.ReadBytes(OffsetMegaPotion, 1);
                //SysBotLog.Text += MegaPotionByte[0].ToString();
                //QuestSysBotPouchMegaPotionCount.Value = MegaPotionByte[0];

                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;

                QuestSysBotMonsterHPCount.Enabled = true;
                QuestSysBotPlayerHPCount.Enabled = true;
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

                QuestSysBotMonsterHPCount.Enabled = false;
                QuestSysBotPlayerHPCount.Enabled = false;
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

        private void QuestSysBotPlayerHPCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSysbotQuestRead_Click(object sender, EventArgs e)
        {

        }
    }
}
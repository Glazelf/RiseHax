using Newtonsoft.Json;
using RiseHax.Core;
using RiseHax.Injection;
using RiseHax.Hunter;
using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RiseHax.WinForms
{
    public partial class SysBotUI : Form
    {
#pragma warning disable CA1416 // Do not catch Win7 warning
        private static readonly string WorkingDirectory = Application.StartupPath;
        private static readonly string ConfigPath = Path.Combine(WorkingDirectory, "config.json");

        public SysBotUI()
        {
            InitializeComponent();
            if (File.Exists(ConfigPath))
            {
                var lines = File.ReadAllText(ConfigPath);
                var prog = JsonConvert.DeserializeObject<ProgramConfig>(lines);
            }
            else
            {
                var hub = new HunterHubConfig();
            }
        }

        public Injector SwitchInjector = new Injector();
        public bool Connected = false;
        

        public void SysBotUI_Load(object sender, EventArgs e)
        {
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == true)
            {

                // Toggle buttons and fields
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;

                QuestSysBotMonsterHPCount.Enabled = false;
                QuestSysBotPlayerHPCount.Enabled = false;
                QuestSysBotPouchMegaPotionCount.Enabled = false;
                ButtonSysbotQuestRead.Enabled = false;

                Connected = false;
                ButtonConnect.Text = "Connect";

            }
            else
            {

                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;

                QuestSysBotMonsterHPCount.Enabled = true;
                QuestSysBotPlayerHPCount.Enabled = true;
                QuestSysBotPouchMegaPotionCount.Enabled = true;
                ButtonSysbotQuestRead.Enabled = true;

                Connected = true;
                ButtonConnect.Text = "Diconnect";
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
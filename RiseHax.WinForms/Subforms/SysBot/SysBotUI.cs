using RiseHax.Core;
using System;
using System.Windows.Forms;

namespace RiseHax.WinForms
{
    public partial class SysBotUI : Form
    {
        public SysBotUI()
        {
            InitializeComponent();
        }

        SwitchConnection SwitchSocket = new SwitchConnection();
        public bool Connected = false;

        public void SysBotUI_Load(object sender, EventArgs e)
        {
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == true)
            {
                SwitchSocket.Connect(TextBoxIP.Text, Port, true);
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
                SwitchSocket.Connect(TextBoxIP.Text, Port, false);
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
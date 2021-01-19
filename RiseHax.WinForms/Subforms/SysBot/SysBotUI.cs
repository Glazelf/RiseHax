using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RiseHax.WinForms
{
    public partial class SysBotUI : Form
    {
        Socket socket;
        public SysBotUI()
        {
            InitializeComponent();
        }

        public bool Connected = false;

        public void SysBotUI_Load(object sender, EventArgs e)
        {
        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(TextBoxPort.Text);
            if (Connected == true)
            {
                Connect(TextBoxIP.Text, Port, true);
                TextBoxIP.Enabled = true;
                TextBoxPort.Enabled = true;

                QuestSysBotMonsterHPCount.Enabled = false;
                QuestSysBotPlayerHPCount.Enabled = false;
                QuestSysBotPouchMegaPotionCount.Enabled = false;
                ButtonSysbotQuestRead.Enabled = false;

                ButtonConnect.Text = "Connect";
            }
            else
            {
                Connect(TextBoxIP.Text, Port, false);
                TextBoxIP.Enabled = false;
                TextBoxPort.Enabled = false;

                QuestSysBotMonsterHPCount.Enabled = true;
                QuestSysBotPlayerHPCount.Enabled = true;
                QuestSysBotPouchMegaPotionCount.Enabled = true;
                ButtonSysbotQuestRead.Enabled = true;

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

        public void Connect(string host, int port, bool disconnect = false)
        {
            if (disconnect == false)
            {
                socket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);
                socket.Connect(host, port);
                MessageBox.Show("Connection established!",
                    "RiseHax Connection",
                    MessageBoxButtons.OK
                );
                Connected = true;
            }
            else
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                MessageBox.Show("Connection aborted!",
                "RiseHax Connection",
                MessageBoxButtons.OK
            );
                Connected = false;
            }
        }
    }
}
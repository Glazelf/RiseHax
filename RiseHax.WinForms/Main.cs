using System;
using System.Threading;
using System.Windows.Forms;

namespace RiseHax.WinForms
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void BtnLiveHax_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new SysBotUI()));
            t.Start();
            Close();
        }

        private void BtnSaveEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Since the Monster Hunter: Rise demo barely has saves, this feature will only be worked on when the full game is out.",
                "RiseHax Save Editor",
                MessageBoxButtons.OK
            );
        }
    }
}

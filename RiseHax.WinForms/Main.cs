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
            MessageBox.Show("Save Editor is still a work in progress, use memory editing for now!",
                "RiseHax",
                MessageBoxButtons.OK
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiseHax.WinForms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLiveHax_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Since the Monster Hunter: Rise demo barely has saves, this feature will only be worked on when the full game is out.",
                "RiseHax Save Editor",
                MessageBoxButtons.OK
            );
        }
    }
}

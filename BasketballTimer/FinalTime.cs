using System;
using System.Windows.Forms;

namespace BasketballTimer
{
    public partial class FinalTime : Form
    {

        public FinalTime()
        {
            InitializeComponent();
        }

        private void btnNewTimePeriod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

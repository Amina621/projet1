using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1
{
    public partial class delivery : Form
    {
        public delivery()
        {
            InitializeComponent();
        }
        int startpoint = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            VProgressBar.Value = startpoint;
            LProgressBar.Value = startpoint;
            if(LProgressBar.Value ==100)
            {
                VProgressBar.Value = 0;
                LProgressBar.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void delivery_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselUygProV1
{
    public partial class intro : Form
    {
        int i = 0;
        public intro()
        {
            InitializeComponent();
        }

        private void intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 100)
            {
                i++;
            }
            else
            {
                login frmlogin = new login();
                frmlogin.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}

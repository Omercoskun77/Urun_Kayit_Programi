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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            urun frmurun = new urun();
            frmurun.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselUygProV1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string user = k_adi.Text;
            string password = sifre.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gpproje;Integrated Security=True");
            con.Open();

            // Hem dbo.Users hem de dbo.KullaniciBilgiler tablolarında kullanıcı adı ve şifre kontrolü
            string queryString = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password " +
                                 "AND EXISTS (SELECT 1 FROM dbo.KullaniciBilgiler WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre)";
            using (SqlCommand cmd = new SqlCommand(queryString, con))
            {
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@kullanici_adi", user);
                cmd.Parameters.AddWithValue("@sifre", password);

                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Başarıyla giriş yapıldı! Sayfa yükleniyor...");
                    anasayfa frmanasayfa = new anasayfa();
                    frmanasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı ve/veya şifre girişi!");
                }
            }

            con.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();

            
            if (registerForm.RegistrationSuccessful)
            {
                k_adi.Text = registerForm.RegisteredUsername;
            }
        }
    }
}

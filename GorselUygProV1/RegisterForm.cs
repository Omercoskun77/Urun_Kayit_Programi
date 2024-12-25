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
    public partial class RegisterForm : Form
    {
        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=gpproje;Integrated Security=True";

        public bool RegistrationSuccessful { get; private set; } = false;
        public string RegisteredUsername { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
    
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRegisterSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!");
                return;
            }

            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Şifre en az 5 karakter olmalı!");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı zaten kullanılmaktadır!");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarılı!");
                            RegistrationSuccessful = true;
                            RegisteredUsername = txtUsername.Text;

                            // dbo.KullaniciBilgiler tablosuna kayıt ekleme
                            string kullaniciBilgileriInsertQuery = "INSERT INTO dbo.KullaniciBilgiler (kullanici_adi, sifre) VALUES (@kullanici_adi, @sifre)";
                            using (SqlCommand kullaniciBilgileriCmd = new SqlCommand(kullaniciBilgileriInsertQuery, connection))
                            {
                                kullaniciBilgileriCmd.Parameters.AddWithValue("@kullanici_adi", txtUsername.Text);
                                kullaniciBilgileriCmd.Parameters.AddWithValue("@sifre", txtPassword.Text);
                                int kullaniciBilgileriResult = kullaniciBilgileriCmd.ExecuteNonQuery();
                                if (kullaniciBilgileriResult > 0)
                                {
                                    MessageBox.Show("Kullanıcı bilgileri de dbo.KullaniciBilgiler tablosuna kaydedildi.");
                                }
                                else
                                {
                                    MessageBox.Show("Kullanıcı bilgilerinin dbo.KullaniciBilgiler tablosuna kaydedilmesinde bir hata oluştu.");
                                }
                            }

                            this.Close();
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatadan dolayı erişilemiyor: " + ex.Message);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

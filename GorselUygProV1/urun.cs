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
    public partial class urun : Form
    {
        public urun()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int i=0;
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=gpproje;Integrated Security=True");


        public void kayitlari_getir()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string getir = "Select * from Urun";
                    SqlCommand komut = new SqlCommand(getir, con);
                    SqlDataAdapter ad = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı hatası!" + hata.Message);
            }
        }

        private void urun_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            tbid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            tburunadi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            tbkategorisi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            tbmensei.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            tbfiyatbilgisi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "insert into Urun (urun_adi, urun_kategorisi, urun_mensei, urun_fiyatbilgisi) " +
                        "values (@urunadi, @urunkategori, @urunmensei, @urunfiyat)";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@urunadi", tburunadi.Text);
                    komut.Parameters.AddWithValue("@urunkategori", tbkategorisi.Text);
                    komut.Parameters.AddWithValue("@urunmensei", tbmensei.Text);
                    komut.Parameters.AddWithValue("@urunfiyat", tbfiyatbilgisi.Text);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni ürün kaydı eklendi!");
                    con.Close();
                    tbid.Clear();
                    tburunadi.Clear();
                    tbkategorisi.Clear();
                    tbmensei.Clear();
                    tbfiyatbilgisi.Clear();
                    kayitlari_getir();
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bağlantı hatası!" + hata.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand komut = new SqlCommand("Update Urun set urun_adi = '" + tburunadi.Text + "', urun_kategorisi ='" + tbkategorisi.Text + "'," +
                        "urun_mensei='" + tbmensei.Text + "', urun_fiyatbilgisi='" + tbfiyatbilgisi.Text + "' where urun_id=@id", con);
                    komut.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Güncelleme işlemi yapıldı!");
                    kayitlari_getir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı hatası!" + hata.Message);
            }


        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand komut = new SqlCommand("Delete from Urun where urun_id=@id", con);
                    komut.Parameters.AddWithValue("id", dataGridView1.Rows[i].Cells[0].Value);
                    komut.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Seçili ürün silindi!");
                    kayitlari_getir();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı hatası!" + hata.Message);
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand komut = new SqlCommand("select * from Urun where urun_id='" + tb_id_ara.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    MessageBox.Show("Arama sonuçları getirildi!");
                    tb_id_ara.Clear();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bağlantı hatası!" + hata.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            anasayfa frmanasayfa = new anasayfa();
            frmanasayfa.Show();
            this.Hide();
        }
    }
}

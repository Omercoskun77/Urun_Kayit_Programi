namespace GorselUygProV1
{
    partial class urun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urun));
            this.panel1 = new System.Windows.Forms.Panel();
            this.geridon = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbmensei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tburunadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbkategorisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbfiyatbilgisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.tb_id_ara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.geridon);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 82);
            this.panel1.TabIndex = 2;
            // 
            // geridon
            // 
            this.geridon.BackColor = System.Drawing.Color.SteelBlue;
            this.geridon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geridon.FlatAppearance.BorderSize = 0;
            this.geridon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geridon.ImageIndex = 5;
            this.geridon.ImageList = this.ımageList1;
            this.geridon.Location = new System.Drawing.Point(839, 0);
            this.geridon.Name = "geridon";
            this.geridon.Size = new System.Drawing.Size(91, 82);
            this.geridon.TabIndex = 2;
            this.geridon.UseVisualStyleBackColor = false;
            this.geridon.Click += new System.EventHandler(this.geridon_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Delete.png");
            this.ımageList1.Images.SetKeyName(1, "Document.png");
            this.ımageList1.Images.SetKeyName(2, "Plus.png");
            this.ımageList1.Images.SetKeyName(3, "Refresh.png");
            this.ımageList1.Images.SetKeyName(4, "Search.png");
            this.ımageList1.Images.SetKeyName(5, "go-back.256x256.png");
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Firebrick;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Location = new System.Drawing.Point(928, 0);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(91, 82);
            this.cikis.TabIndex = 1;
            this.cikis.Text = "X";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(362, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN TAKİP SİSTEMİ PROJESİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselUygProV1.Resource1.logo12;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Candara", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(336, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 66);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ürün Bilgileri Ekranı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbid
            // 
            this.tbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbid.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbid.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbid.Location = new System.Drawing.Point(226, 48);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(248, 38);
            this.tbid.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SlateGray;
            this.label8.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(40, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "              ID:             ";
            // 
            // tbmensei
            // 
            this.tbmensei.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbmensei.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbmensei.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmensei.Location = new System.Drawing.Point(226, 209);
            this.tbmensei.Name = "tbmensei";
            this.tbmensei.Size = new System.Drawing.Size(248, 38);
            this.tbmensei.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "       MENŞEİ:       ";
            // 
            // tburunadi
            // 
            this.tburunadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tburunadi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tburunadi.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tburunadi.Location = new System.Drawing.Point(226, 103);
            this.tburunadi.Name = "tburunadi";
            this.tburunadi.Size = new System.Drawing.Size(248, 38);
            this.tburunadi.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(40, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 14;
            this.label5.Text = "      ÜRÜN ADI:    ";
            // 
            // tbkategorisi
            // 
            this.tbkategorisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbkategorisi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbkategorisi.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbkategorisi.Location = new System.Drawing.Point(226, 156);
            this.tbkategorisi.Name = "tbkategorisi";
            this.tbkategorisi.Size = new System.Drawing.Size(248, 38);
            this.tbkategorisi.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SlateGray;
            this.label6.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(40, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = "   KATEGORİSİ:  ";
            // 
            // tbfiyatbilgisi
            // 
            this.tbfiyatbilgisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbfiyatbilgisi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbfiyatbilgisi.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbfiyatbilgisi.Location = new System.Drawing.Point(226, 264);
            this.tbfiyatbilgisi.Name = "tbfiyatbilgisi";
            this.tbfiyatbilgisi.Size = new System.Drawing.Size(248, 38);
            this.tbfiyatbilgisi.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(40, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "  FİYAT BİLGİSİ: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 526);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 298);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_listele.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_listele.ImageIndex = 1;
            this.btn_listele.ImageList = this.ımageList1;
            this.btn_listele.Location = new System.Drawing.Point(839, 667);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(161, 133);
            this.btn_listele.TabIndex = 21;
            this.btn_listele.Text = "Ürünleri\r\nGöster";
            this.btn_listele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbfiyatbilgisi);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbkategorisi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tburunadi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbmensei);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(0, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 323);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(516, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 130);
            this.button2.TabIndex = 24;
            this.button2.Text = "Ürünleri\r\nGüncelle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 2;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(516, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 131);
            this.button1.TabIndex = 23;
            this.button1.Text = "Ürünleri\r\nKaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ara);
            this.groupBox2.Controls.Add(this.tb_id_ara);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(729, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 322);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // btn_ara
            // 
            this.btn_ara.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_ara.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ara.ImageIndex = 4;
            this.btn_ara.ImageList = this.ımageList1;
            this.btn_ara.Location = new System.Drawing.Point(45, 141);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(191, 145);
            this.btn_ara.TabIndex = 14;
            this.btn_ara.Text = "Arama";
            this.btn_ara.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ara.UseVisualStyleBackColor = false;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // tb_id_ara
            // 
            this.tb_id_ara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_id_ara.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_id_ara.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_id_ara.Location = new System.Drawing.Point(66, 73);
            this.tb_id_ara.Name = "tb_id_ara";
            this.tb_id_ara.Size = new System.Drawing.Size(191, 38);
            this.tb_id_ara.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = " ID:";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_sil.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ImageIndex = 0;
            this.btn_sil.ImageList = this.ımageList1;
            this.btn_sil.Location = new System.Drawing.Point(839, 542);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(161, 119);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Veri Sil";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 823);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "urun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urun";
            this.Load += new System.EventHandler(this.urun_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbmensei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tburunadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbkategorisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbfiyatbilgisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox tb_id_ara;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button geridon;
    }
}
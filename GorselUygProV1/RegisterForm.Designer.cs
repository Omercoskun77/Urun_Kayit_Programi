namespace GorselUygProV1
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.kutucuk1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.kutucuk2 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.kutucuk3 = new System.Windows.Forms.Label();
            this.btnRegisterSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 82);
            this.panel1.TabIndex = 1;
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Firebrick;
            this.cikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.Color.White;
            this.cikis.Location = new System.Drawing.Point(521, 0);
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
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(135, 25);
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
            this.label4.Font = new System.Drawing.Font("Candara", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(245, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 66);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kayıt Ol";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(288, 237);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(248, 40);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // kutucuk1
            // 
            this.kutucuk1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kutucuk1.AutoSize = true;
            this.kutucuk1.BackColor = System.Drawing.Color.SlateGray;
            this.kutucuk1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutucuk1.ForeColor = System.Drawing.Color.White;
            this.kutucuk1.Location = new System.Drawing.Point(79, 240);
            this.kutucuk1.Name = "kutucuk1";
            this.kutucuk1.Size = new System.Drawing.Size(203, 35);
            this.kutucuk1.TabIndex = 9;
            this.kutucuk1.Text = "KULLANICI ADI:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(288, 292);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(248, 40);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // kutucuk2
            // 
            this.kutucuk2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kutucuk2.AutoSize = true;
            this.kutucuk2.BackColor = System.Drawing.Color.SlateGray;
            this.kutucuk2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutucuk2.ForeColor = System.Drawing.Color.White;
            this.kutucuk2.Location = new System.Drawing.Point(79, 295);
            this.kutucuk2.Name = "kutucuk2";
            this.kutucuk2.Size = new System.Drawing.Size(205, 35);
            this.kutucuk2.TabIndex = 11;
            this.kutucuk2.Text = "          ŞİFRE:         ";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordConfirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPasswordConfirm.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPasswordConfirm.Location = new System.Drawing.Point(288, 346);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(248, 40);
            this.txtPasswordConfirm.TabIndex = 14;
            this.txtPasswordConfirm.TextChanged += new System.EventHandler(this.txtPasswordConfirm_TextChanged);
            // 
            // kutucuk3
            // 
            this.kutucuk3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kutucuk3.AutoSize = true;
            this.kutucuk3.BackColor = System.Drawing.Color.SlateGray;
            this.kutucuk3.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kutucuk3.ForeColor = System.Drawing.Color.White;
            this.kutucuk3.Location = new System.Drawing.Point(79, 349);
            this.kutucuk3.Name = "kutucuk3";
            this.kutucuk3.Size = new System.Drawing.Size(206, 35);
            this.kutucuk3.TabIndex = 13;
            this.kutucuk3.Text = " ŞİFRE ONAYLA:";
            // 
            // btnRegisterSave
            // 
            this.btnRegisterSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegisterSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterSave.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegisterSave.ForeColor = System.Drawing.Color.White;
            this.btnRegisterSave.Location = new System.Drawing.Point(197, 410);
            this.btnRegisterSave.Name = "btnRegisterSave";
            this.btnRegisterSave.Size = new System.Drawing.Size(214, 52);
            this.btnRegisterSave.TabIndex = 15;
            this.btnRegisterSave.Text = "KAYDET";
            this.btnRegisterSave.UseVisualStyleBackColor = false;
            this.btnRegisterSave.Click += new System.EventHandler(this.btnRegisterSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(197, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(214, 52);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "İPTAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 563);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterSave);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.kutucuk3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.kutucuk2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.kutucuk1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label kutucuk1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label kutucuk2;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label kutucuk3;
        private System.Windows.Forms.Button btnRegisterSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
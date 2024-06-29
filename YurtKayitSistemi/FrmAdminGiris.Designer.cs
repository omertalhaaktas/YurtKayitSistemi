namespace YurtKayitSistemi
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            label1 = new Label();
            BtnGirisYap = new Button();
            TxtKullaniciAd = new TextBox();
            TxtSifre = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 56);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Ad :";
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGirisYap.Location = new Point(294, 56);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(128, 58);
            BtnGirisYap.TabIndex = 1;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // TxtKullaniciAd
            // 
            TxtKullaniciAd.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKullaniciAd.Location = new Point(127, 53);
            TxtKullaniciAd.Name = "TxtKullaniciAd";
            TxtKullaniciAd.Size = new Size(100, 25);
            TxtKullaniciAd.TabIndex = 2;
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(127, 93);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(100, 25);
            TxtSifre.TabIndex = 4;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 96);
            label2.Name = "label2";
            label2.Size = new Size(47, 18);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 44);
            panel1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 6);
            label3.Name = "label3";
            label3.Size = new Size(423, 29);
            label3.TabIndex = 6;
            label3.Text = "Öğrenci Yurt Kayıt Otomasyon Sistemi";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(470, 149);
            Controls.Add(panel1);
            Controls.Add(TxtSifre);
            Controls.Add(label2);
            Controls.Add(TxtKullaniciAd);
            Controls.Add(BtnGirisYap);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnGirisYap;
        private TextBox TxtKullaniciAd;
        private TextBox TxtSifre;
        private Label label2;
        private Panel panel1;
        private Label label3;
    }
}
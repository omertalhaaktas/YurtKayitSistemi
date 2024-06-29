namespace YurtKayitSistemi
{
    partial class FrmYoneticiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYoneticiDuzenle));
            TxtYoneticiid = new TextBox();
            label1 = new Label();
            TxtKullaniciAd = new TextBox();
            label2 = new Label();
            TxtSifre = new TextBox();
            label3 = new Label();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            BtnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtYoneticiid
            // 
            TxtYoneticiid.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtYoneticiid.Location = new Point(114, 12);
            TxtYoneticiid.Name = "TxtYoneticiid";
            TxtYoneticiid.Size = new Size(252, 26);
            TxtYoneticiid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 2;
            label1.Text = "Yönetici id :";
            // 
            // TxtKullaniciAd
            // 
            TxtKullaniciAd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtKullaniciAd.Location = new Point(114, 44);
            TxtKullaniciAd.Name = "TxtKullaniciAd";
            TxtKullaniciAd.Size = new Size(252, 26);
            TxtKullaniciAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı :";
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSifre.Location = new Point(114, 76);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(252, 26);
            TxtSifre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 79);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 6;
            label3.Text = "Şifre :";
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSil.Location = new Point(146, 131);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(107, 32);
            BtnSil.TabIndex = 5;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(259, 131);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(107, 32);
            BtnGuncelle.TabIndex = 6;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(354, 137);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(33, 131);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(107, 32);
            BtnKaydet.TabIndex = 4;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // FrmYoneticiDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(378, 354);
            Controls.Add(BtnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(TxtSifre);
            Controls.Add(label3);
            Controls.Add(TxtKullaniciAd);
            Controls.Add(label2);
            Controls.Add(TxtYoneticiid);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmYoneticiDuzenle";
            Text = "Yönetici İşlemleri";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtYoneticiid;
        private Label label1;
        private TextBox TxtKullaniciAd;
        private Label label2;
        private TextBox TxtSifre;
        private Label label3;
        private Button BtnSil;
        private Button BtnGuncelle;
        private DataGridView dataGridView1;
        private Button BtnKaydet;
    }
}
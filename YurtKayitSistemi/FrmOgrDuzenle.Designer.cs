namespace YurtKayitSistemi
{
    partial class FrmOgrDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrDuzenle));
            label1 = new Label();
            label11 = new Label();
            BtnGuncelle = new Button();
            label10 = new Label();
            RchAdres = new RichTextBox();
            MskVeliTelefon = new MaskedTextBox();
            label9 = new Label();
            TxtVeliAdSoyad = new TextBox();
            label8 = new Label();
            CmbOdaNo = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            CmbBolum = new ComboBox();
            label5 = new Label();
            MskDogum = new MaskedTextBox();
            label4 = new Label();
            MskOgrTelefon = new MaskedTextBox();
            Telefon = new Label();
            MskTC = new MaskedTextBox();
            TxtMail = new TextBox();
            label3 = new Label();
            TxtOgrSoyad = new TextBox();
            label2 = new Label();
            TxtOgrAd = new TextBox();
            label12 = new Label();
            TxtOgrid = new TextBox();
            BtnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(86, 18);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci id :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 478);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 47;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(68, 530);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(148, 32);
            BtnGuncelle.TabIndex = 46;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(81, 377);
            label10.Name = "label10";
            label10.Size = new Size(54, 18);
            label10.TabIndex = 45;
            label10.Text = "Adres :";
            // 
            // RchAdres
            // 
            RchAdres.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RchAdres.Location = new Point(139, 374);
            RchAdres.Name = "RchAdres";
            RchAdres.Size = new Size(238, 141);
            RchAdres.TabIndex = 44;
            RchAdres.Text = "";
            // 
            // MskVeliTelefon
            // 
            MskVeliTelefon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskVeliTelefon.Location = new Point(139, 342);
            MskVeliTelefon.Mask = "(999) 000-0000";
            MskVeliTelefon.Name = "MskVeliTelefon";
            MskVeliTelefon.Size = new Size(237, 26);
            MskVeliTelefon.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(40, 345);
            label9.Name = "label9";
            label9.Size = new Size(95, 18);
            label9.TabIndex = 42;
            label9.Text = "Veli Telefon :";
            // 
            // TxtVeliAdSoyad
            // 
            TxtVeliAdSoyad.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVeliAdSoyad.Location = new Point(139, 310);
            TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            TxtVeliAdSoyad.Size = new Size(237, 26);
            TxtVeliAdSoyad.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 313);
            label8.Name = "label8";
            label8.Size = new Size(108, 18);
            label8.TabIndex = 40;
            label8.Text = "Veli Ad Soyad :";
            // 
            // CmbOdaNo
            // 
            CmbOdaNo.FormattingEnabled = true;
            CmbOdaNo.Location = new Point(139, 281);
            CmbOdaNo.Name = "CmbOdaNo";
            CmbOdaNo.Size = new Size(237, 23);
            CmbOdaNo.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(64, 281);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 38;
            label7.Text = "Oda No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(65, 223);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 37;
            label6.Text = "E-posta :";
            // 
            // CmbBolum
            // 
            CmbBolum.FormattingEnabled = true;
            CmbBolum.Location = new Point(139, 252);
            CmbBolum.Name = "CmbBolum";
            CmbBolum.Size = new Size(237, 23);
            CmbBolum.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 252);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 35;
            label5.Text = "Öğrenci Bölüm :";
            // 
            // MskDogum
            // 
            MskDogum.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskDogum.Location = new Point(139, 188);
            MskDogum.Mask = "00/00/0000";
            MskDogum.Name = "MskDogum";
            MskDogum.Size = new Size(237, 26);
            MskDogum.TabIndex = 34;
            MskDogum.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 191);
            label4.Name = "label4";
            label4.Size = new Size(111, 18);
            label4.TabIndex = 33;
            label4.Text = "Doğum Tarihi :";
            // 
            // MskOgrTelefon
            // 
            MskOgrTelefon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskOgrTelefon.Location = new Point(139, 156);
            MskOgrTelefon.Mask = "(999) 000-0000";
            MskOgrTelefon.Name = "MskOgrTelefon";
            MskOgrTelefon.Size = new Size(237, 26);
            MskOgrTelefon.TabIndex = 32;
            // 
            // Telefon
            // 
            Telefon.AutoSize = true;
            Telefon.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Telefon.Location = new Point(68, 159);
            Telefon.Name = "Telefon";
            Telefon.Size = new Size(66, 18);
            Telefon.TabIndex = 31;
            Telefon.Text = "Telefon :";
            // 
            // MskTC
            // 
            MskTC.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskTC.Location = new Point(139, 124);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(237, 26);
            MskTC.TabIndex = 30;
            MskTC.ValidatingType = typeof(int);
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMail.Location = new Point(139, 220);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(237, 26);
            TxtMail.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(98, 127);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 28;
            label3.Text = "TC :";
            // 
            // TxtOgrSoyad
            // 
            TxtOgrSoyad.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOgrSoyad.Location = new Point(139, 90);
            TxtOgrSoyad.Name = "TxtOgrSoyad";
            TxtOgrSoyad.Size = new Size(237, 26);
            TxtOgrSoyad.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 93);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 26;
            label2.Text = "Öğrenci Soyad :";
            // 
            // TxtOgrAd
            // 
            TxtOgrAd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOgrAd.Location = new Point(139, 58);
            TxtOgrAd.Name = "TxtOgrAd";
            TxtOgrAd.Size = new Size(237, 26);
            TxtOgrAd.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(42, 61);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 24;
            label12.Text = "Öğrenci Ad :";
            // 
            // TxtOgrid
            // 
            TxtOgrid.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOgrid.Location = new Point(139, 26);
            TxtOgrid.Name = "TxtOgrid";
            TxtOgrid.Size = new Size(237, 26);
            TxtOgrid.TabIndex = 48;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSil.Location = new Point(229, 530);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(148, 32);
            BtnSil.TabIndex = 49;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // FrmOgrDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(388, 574);
            Controls.Add(BtnSil);
            Controls.Add(TxtOgrid);
            Controls.Add(label11);
            Controls.Add(BtnGuncelle);
            Controls.Add(label10);
            Controls.Add(RchAdres);
            Controls.Add(MskVeliTelefon);
            Controls.Add(label9);
            Controls.Add(TxtVeliAdSoyad);
            Controls.Add(label8);
            Controls.Add(CmbOdaNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(CmbBolum);
            Controls.Add(label5);
            Controls.Add(MskDogum);
            Controls.Add(label4);
            Controls.Add(MskOgrTelefon);
            Controls.Add(Telefon);
            Controls.Add(MskTC);
            Controls.Add(TxtMail);
            Controls.Add(label3);
            Controls.Add(TxtOgrSoyad);
            Controls.Add(label2);
            Controls.Add(TxtOgrAd);
            Controls.Add(label12);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOgrDuzenle";
            Text = "Öğrenci Düzenle";
            Load += FrmOgrDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label11;
        private Button BtnGuncelle;
        private Label label10;
        private RichTextBox RchAdres;
        private MaskedTextBox MskVeliTelefon;
        private Label label9;
        private TextBox TxtVeliAdSoyad;
        private Label label8;
        private ComboBox CmbOdaNo;
        private Label label7;
        private Label label6;
        private ComboBox CmbBolum;
        private Label label5;
        private MaskedTextBox MskDogum;
        private Label label4;
        private MaskedTextBox MskOgrTelefon;
        private Label Telefon;
        private MaskedTextBox MskTC;
        private TextBox TxtMail;
        private Label label3;
        private TextBox TxtOgrSoyad;
        private Label label2;
        private TextBox TxtOgrAd;
        private Label label12;
        private TextBox TxtOgrid;
        private Button BtnSil;
    }
}
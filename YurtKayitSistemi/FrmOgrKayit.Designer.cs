namespace YurtKayitSistemi
{
    partial class FrmOgrKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            label1 = new Label();
            TxtOgrAd = new TextBox();
            TxtOgrSoyad = new TextBox();
            label2 = new Label();
            TxtMail = new TextBox();
            label3 = new Label();
            MskTC = new MaskedTextBox();
            MskOgrTelefon = new MaskedTextBox();
            Telefon = new Label();
            MskDogum = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            CmbBolum = new ComboBox();
            label6 = new Label();
            CmbOdaNo = new ComboBox();
            label7 = new Label();
            TxtVeliAdSoyad = new TextBox();
            label8 = new Label();
            MskVeliTelefon = new MaskedTextBox();
            label9 = new Label();
            RchAdres = new RichTextBox();
            label10 = new Label();
            BtnKaydet = new Button();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 30);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Ad :";
            // 
            // TxtOgrAd
            // 
            TxtOgrAd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOgrAd.Location = new Point(136, 27);
            TxtOgrAd.Name = "TxtOgrAd";
            TxtOgrAd.Size = new Size(237, 26);
            TxtOgrAd.TabIndex = 1;
            // 
            // TxtOgrSoyad
            // 
            TxtOgrSoyad.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOgrSoyad.Location = new Point(136, 59);
            TxtOgrSoyad.Name = "TxtOgrSoyad";
            TxtOgrSoyad.Size = new Size(237, 26);
            TxtOgrSoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 2;
            label2.Text = "Öğrenci Soyad :";
            // 
            // TxtMail
            // 
            TxtMail.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMail.Location = new Point(136, 189);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(237, 26);
            TxtMail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(95, 96);
            label3.Name = "label3";
            label3.Size = new Size(36, 18);
            label3.TabIndex = 4;
            label3.Text = "TC :";
            // 
            // MskTC
            // 
            MskTC.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskTC.Location = new Point(136, 93);
            MskTC.Mask = "00000000000";
            MskTC.Name = "MskTC";
            MskTC.Size = new Size(237, 26);
            MskTC.TabIndex = 3;
            MskTC.ValidatingType = typeof(int);
            // 
            // MskOgrTelefon
            // 
            MskOgrTelefon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskOgrTelefon.Location = new Point(136, 125);
            MskOgrTelefon.Mask = "(999) 000-0000";
            MskOgrTelefon.Name = "MskOgrTelefon";
            MskOgrTelefon.Size = new Size(237, 26);
            MskOgrTelefon.TabIndex = 4;
            // 
            // Telefon
            // 
            Telefon.AutoSize = true;
            Telefon.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Telefon.Location = new Point(65, 128);
            Telefon.Name = "Telefon";
            Telefon.Size = new Size(66, 18);
            Telefon.TabIndex = 7;
            Telefon.Text = "Telefon :";
            // 
            // MskDogum
            // 
            MskDogum.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskDogum.Location = new Point(136, 157);
            MskDogum.Mask = "00/00/0000";
            MskDogum.Name = "MskDogum";
            MskDogum.Size = new Size(237, 26);
            MskDogum.TabIndex = 5;
            MskDogum.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 160);
            label4.Name = "label4";
            label4.Size = new Size(111, 18);
            label4.TabIndex = 9;
            label4.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 221);
            label5.Name = "label5";
            label5.Size = new Size(119, 18);
            label5.TabIndex = 11;
            label5.Text = "Öğrenci Bölüm :";
            // 
            // CmbBolum
            // 
            CmbBolum.FormattingEnabled = true;
            CmbBolum.Location = new Point(136, 221);
            CmbBolum.Name = "CmbBolum";
            CmbBolum.Size = new Size(237, 23);
            CmbBolum.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 192);
            label6.Name = "label6";
            label6.Size = new Size(68, 18);
            label6.TabIndex = 13;
            label6.Text = "E-posta :";
            // 
            // CmbOdaNo
            // 
            CmbOdaNo.FormattingEnabled = true;
            CmbOdaNo.Location = new Point(136, 250);
            CmbOdaNo.Name = "CmbOdaNo";
            CmbOdaNo.Size = new Size(237, 23);
            CmbOdaNo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(61, 250);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 14;
            label7.Text = "Oda No :";
            // 
            // TxtVeliAdSoyad
            // 
            TxtVeliAdSoyad.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtVeliAdSoyad.Location = new Point(136, 279);
            TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            TxtVeliAdSoyad.Size = new Size(235, 26);
            TxtVeliAdSoyad.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 282);
            label8.Name = "label8";
            label8.Size = new Size(108, 18);
            label8.TabIndex = 16;
            label8.Text = "Veli Ad Soyad :";
            // 
            // MskVeliTelefon
            // 
            MskVeliTelefon.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MskVeliTelefon.Location = new Point(135, 311);
            MskVeliTelefon.Mask = "(999) 000-0000";
            MskVeliTelefon.Name = "MskVeliTelefon";
            MskVeliTelefon.Size = new Size(236, 26);
            MskVeliTelefon.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(35, 314);
            label9.Name = "label9";
            label9.Size = new Size(95, 18);
            label9.TabIndex = 18;
            label9.Text = "Veli Telefon :";
            // 
            // RchAdres
            // 
            RchAdres.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RchAdres.Location = new Point(135, 343);
            RchAdres.Name = "RchAdres";
            RchAdres.Size = new Size(237, 141);
            RchAdres.TabIndex = 11;
            RchAdres.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(76, 346);
            label10.Name = "label10";
            label10.Size = new Size(54, 18);
            label10.TabIndex = 21;
            label10.Text = "Adres :";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(251, 502);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(122, 32);
            BtnKaydet.TabIndex = 12;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 447);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 23;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // FrmOgrKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(385, 544);
            Controls.Add(label11);
            Controls.Add(BtnKaydet);
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
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOgrKayit";
            Text = "Öğrenci Kayıt";
            Load += FrmOgrKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtOgrAd;
        private TextBox TxtOgrSoyad;
        private Label label2;
        private TextBox TxtMail;
        private Label label3;
        private MaskedTextBox MskTC;
        private MaskedTextBox MskOgrTelefon;
        private Label Telefon;
        private MaskedTextBox MskDogum;
        private Label label4;
        private Label label5;
        private ComboBox CmbBolum;
        private Label label6;
        private ComboBox CmbOdaNo;
        private Label label7;
        private TextBox TxtVeliAdSoyad;
        private Label label8;
        private MaskedTextBox MskVeliTelefon;
        private Label label9;
        private RichTextBox RchAdres;
        private Label label10;
        private Button BtnKaydet;
        private Label label11;
    }
}
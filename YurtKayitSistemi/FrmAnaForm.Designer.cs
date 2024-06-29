namespace YurtKayitSistemi
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            menuStrip1 = new MenuStrip();
            öğrencilerToolStripMenuItem = new ToolStripMenuItem();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciListesiToolStripMenuItem = new ToolStripMenuItem();
            öğrenciSilToolStripMenuItem = new ToolStripMenuItem();
            bölümlerToolStripMenuItem = new ToolStripMenuItem();
            bölümEkleToolStripMenuItem = new ToolStripMenuItem();
            bölümDüzenleToolStripMenuItem = new ToolStripMenuItem();
            ödemelerToolStripMenuItem = new ToolStripMenuItem();
            ödemeAlToolStripMenuItem = new ToolStripMenuItem();
            giderlerToolStripMenuItem = new ToolStripMenuItem();
            giderEkleToolStripMenuItem = new ToolStripMenuItem();
            giderListesiToolStripMenuItem = new ToolStripMenuItem();
            istatistiklerToolStripMenuItem = new ToolStripMenuItem();
            gelirİstatistikleriToolStripMenuItem = new ToolStripMenuItem();
            yöneticiToolStripMenuItem = new ToolStripMenuItem();
            şifreİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            personelDüzenleToolStripMenuItem = new ToolStripMenuItem();
            notEkleToolStripMenuItem = new ToolStripMenuItem();
            erişimKolaylığıToolStripMenuItem = new ToolStripMenuItem();
            hesapMakinesiToolStripMenuItem = new ToolStripMenuItem();
            paintToolStripMenuItem = new ToolStripMenuItem();
            radyolarToolStripMenuItem = new ToolStripMenuItem();
            radyo1ToolStripMenuItem = new ToolStripMenuItem();
            radyo2ToolStripMenuItem = new ToolStripMenuItem();
            radyo3ToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrencilerToolStripMenuItem, bölümlerToolStripMenuItem, ödemelerToolStripMenuItem, giderlerToolStripMenuItem, istatistiklerToolStripMenuItem, yöneticiToolStripMenuItem, erişimKolaylığıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(788, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            öğrencilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrenciListesiToolStripMenuItem, öğrenciSilToolStripMenuItem });
            öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            öğrencilerToolStripMenuItem.Size = new Size(90, 22);
            öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(174, 22);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            öğrenciEkleToolStripMenuItem.Click += öğrenciEkleToolStripMenuItem_Click;
            // 
            // öğrenciListesiToolStripMenuItem
            // 
            öğrenciListesiToolStripMenuItem.Name = "öğrenciListesiToolStripMenuItem";
            öğrenciListesiToolStripMenuItem.Size = new Size(174, 22);
            öğrenciListesiToolStripMenuItem.Text = "Öğrenci Listesi";
            öğrenciListesiToolStripMenuItem.Click += öğrenciListesiToolStripMenuItem_Click;
            // 
            // öğrenciSilToolStripMenuItem
            // 
            öğrenciSilToolStripMenuItem.Name = "öğrenciSilToolStripMenuItem";
            öğrenciSilToolStripMenuItem.Size = new Size(174, 22);
            öğrenciSilToolStripMenuItem.Text = "Öğrenci Sil";
            öğrenciSilToolStripMenuItem.Click += öğrenciSilToolStripMenuItem_Click;
            // 
            // bölümlerToolStripMenuItem
            // 
            bölümlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bölümEkleToolStripMenuItem, bölümDüzenleToolStripMenuItem });
            bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            bölümlerToolStripMenuItem.Size = new Size(82, 22);
            bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            bölümEkleToolStripMenuItem.Size = new Size(179, 22);
            bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            bölümEkleToolStripMenuItem.Click += bölümEkleToolStripMenuItem_Click;
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            bölümDüzenleToolStripMenuItem.Size = new Size(179, 22);
            bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            bölümDüzenleToolStripMenuItem.Click += bölümDüzenleToolStripMenuItem_Click;
            // 
            // ödemelerToolStripMenuItem
            // 
            ödemelerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ödemeAlToolStripMenuItem });
            ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            ödemelerToolStripMenuItem.Size = new Size(85, 22);
            ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            ödemeAlToolStripMenuItem.Size = new Size(142, 22);
            ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            ödemeAlToolStripMenuItem.Click += ödemeAlToolStripMenuItem_Click;
            // 
            // giderlerToolStripMenuItem
            // 
            giderlerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giderEkleToolStripMenuItem, giderListesiToolStripMenuItem });
            giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            giderlerToolStripMenuItem.Size = new Size(74, 22);
            giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            giderEkleToolStripMenuItem.Size = new Size(158, 22);
            giderEkleToolStripMenuItem.Text = "Gider Ekle";
            giderEkleToolStripMenuItem.Click += giderEkleToolStripMenuItem_Click;
            // 
            // giderListesiToolStripMenuItem
            // 
            giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            giderListesiToolStripMenuItem.Size = new Size(158, 22);
            giderListesiToolStripMenuItem.Text = "Gider Listesi";
            giderListesiToolStripMenuItem.Click += giderListesiToolStripMenuItem_Click;
            // 
            // istatistiklerToolStripMenuItem
            // 
            istatistiklerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gelirİstatistikleriToolStripMenuItem });
            istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            istatistiklerToolStripMenuItem.Size = new Size(95, 22);
            istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            gelirİstatistikleriToolStripMenuItem.Size = new Size(192, 22);
            gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            gelirİstatistikleriToolStripMenuItem.Click += gelirİstatistikleriToolStripMenuItem_Click;
            // 
            // yöneticiToolStripMenuItem
            // 
            yöneticiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { şifreİşlemleriToolStripMenuItem, personelDüzenleToolStripMenuItem, notEkleToolStripMenuItem });
            yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            yöneticiToolStripMenuItem.Size = new Size(75, 22);
            yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            şifreİşlemleriToolStripMenuItem.Size = new Size(190, 22);
            şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            şifreİşlemleriToolStripMenuItem.Click += şifreİşlemleriToolStripMenuItem_Click_1;
            // 
            // personelDüzenleToolStripMenuItem
            // 
            personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            personelDüzenleToolStripMenuItem.Size = new Size(190, 22);
            personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            personelDüzenleToolStripMenuItem.Click += personelDüzenleToolStripMenuItem_Click_1;
            // 
            // notEkleToolStripMenuItem
            // 
            notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            notEkleToolStripMenuItem.Size = new Size(190, 22);
            notEkleToolStripMenuItem.Text = "Not Ekle";
            notEkleToolStripMenuItem.Click += notEkleToolStripMenuItem_Click;
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hesapMakinesiToolStripMenuItem, paintToolStripMenuItem, radyolarToolStripMenuItem, hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            erişimKolaylığıToolStripMenuItem.Size = new Size(126, 22);
            erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            hesapMakinesiToolStripMenuItem.Size = new Size(181, 22);
            hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            hesapMakinesiToolStripMenuItem.Click += hesapMakinesiToolStripMenuItem_Click;
            // 
            // paintToolStripMenuItem
            // 
            paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            paintToolStripMenuItem.Size = new Size(181, 22);
            paintToolStripMenuItem.Text = "Paint";
            paintToolStripMenuItem.Click += paintToolStripMenuItem_Click;
            // 
            // radyolarToolStripMenuItem
            // 
            radyolarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { radyo1ToolStripMenuItem, radyo2ToolStripMenuItem, radyo3ToolStripMenuItem });
            radyolarToolStripMenuItem.Name = "radyolarToolStripMenuItem";
            radyolarToolStripMenuItem.Size = new Size(181, 22);
            radyolarToolStripMenuItem.Text = "Radyolar";
            // 
            // radyo1ToolStripMenuItem
            // 
            radyo1ToolStripMenuItem.Name = "radyo1ToolStripMenuItem";
            radyo1ToolStripMenuItem.Size = new Size(154, 22);
            radyo1ToolStripMenuItem.Text = "90'LAR";
            radyo1ToolStripMenuItem.Click += radyo1ToolStripMenuItem_Click;
            // 
            // radyo2ToolStripMenuItem
            // 
            radyo2ToolStripMenuItem.Name = "radyo2ToolStripMenuItem";
            radyo2ToolStripMenuItem.Size = new Size(154, 22);
            radyo2ToolStripMenuItem.Text = "Radio Light";
            radyo2ToolStripMenuItem.Click += radyo2ToolStripMenuItem_Click;
            // 
            // radyo3ToolStripMenuItem
            // 
            radyo3ToolStripMenuItem.Name = "radyo3ToolStripMenuItem";
            radyo3ToolStripMenuItem.Size = new Size(154, 22);
            radyo3ToolStripMenuItem.Text = "Hamsi FM";
            radyo3ToolStripMenuItem.Click += radyo3ToolStripMenuItem_Click;
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(181, 22);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(181, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(531, 213);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(563, 144);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(624, 191);
            label2.Name = "label2";
            label2.Size = new Size(50, 18);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(563, 278);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(213, 64);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(788, 354);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAnaForm";
            Text = "Ana Sayfa";
            Load += FrmAnaForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrencilerToolStripMenuItem;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciListesiToolStripMenuItem;
        private ToolStripMenuItem öğrenciSilToolStripMenuItem;
        private ToolStripMenuItem bölümlerToolStripMenuItem;
        private ToolStripMenuItem bölümEkleToolStripMenuItem;
        private ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private ToolStripMenuItem ödemelerToolStripMenuItem;
        private ToolStripMenuItem ödemeAlToolStripMenuItem;
        private ToolStripMenuItem giderlerToolStripMenuItem;
        private ToolStripMenuItem giderEkleToolStripMenuItem;
        private ToolStripMenuItem giderListesiToolStripMenuItem;
        private ToolStripMenuItem istatistiklerToolStripMenuItem;
        private ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private ToolStripMenuItem yöneticiToolStripMenuItem;
        private ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private ToolStripMenuItem paintToolStripMenuItem;
        private ToolStripMenuItem radyolarToolStripMenuItem;
        private ToolStripMenuItem radyo1ToolStripMenuItem;
        private ToolStripMenuItem radyo2ToolStripMenuItem;
        private ToolStripMenuItem radyo3ToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private ToolStripMenuItem notEkleToolStripMenuItem;
    }
}
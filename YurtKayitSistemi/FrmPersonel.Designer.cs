namespace YurtKayitSistemi
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            TxtPersonelid = new TextBox();
            label1 = new Label();
            TxtPersonelAd = new TextBox();
            label2 = new Label();
            TxtPersonelGorev = new TextBox();
            label3 = new Label();
            BtnKaydet = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtPersonelid
            // 
            TxtPersonelid.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPersonelid.Location = new Point(129, 12);
            TxtPersonelid.Name = "TxtPersonelid";
            TxtPersonelid.Size = new Size(252, 26);
            TxtPersonelid.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 4;
            label1.Text = "Personel id :";
            // 
            // TxtPersonelAd
            // 
            TxtPersonelAd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPersonelAd.Location = new Point(129, 44);
            TxtPersonelAd.Name = "TxtPersonelAd";
            TxtPersonelAd.Size = new Size(252, 26);
            TxtPersonelAd.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 47);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 6;
            label2.Text = "Personel Ad :";
            // 
            // TxtPersonelGorev
            // 
            TxtPersonelGorev.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPersonelGorev.Location = new Point(129, 76);
            TxtPersonelGorev.Name = "TxtPersonelGorev";
            TxtPersonelGorev.Size = new Size(252, 26);
            TxtPersonelGorev.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 79);
            label3.Name = "label3";
            label3.Size = new Size(118, 18);
            label3.TabIndex = 8;
            label3.Text = "Personel Görev :";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(12, 132);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(95, 34);
            BtnKaydet.TabIndex = 10;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSil.Location = new Point(129, 132);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(95, 34);
            BtnSil.TabIndex = 11;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(247, 132);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(95, 34);
            BtnGuncelle.TabIndex = 12;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(369, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmPersonel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(391, 339);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtPersonelGorev);
            Controls.Add(label3);
            Controls.Add(TxtPersonelAd);
            Controls.Add(label2);
            Controls.Add(TxtPersonelid);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPersonel";
            Text = "Personel";
            Load += FrmPersonel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPersonelid;
        private Label label1;
        private TextBox TxtPersonelAd;
        private Label label2;
        private TextBox TxtPersonelGorev;
        private Label label3;
        private Button BtnKaydet;
        private Button BtnSil;
        private Button BtnGuncelle;
        private DataGridView dataGridView1;
    }
}
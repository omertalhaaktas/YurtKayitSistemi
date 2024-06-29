namespace YurtKayitSistemi
{
    partial class FrmGelirİstatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirİstatistik));
            label1 = new Label();
            LblPara = new Label();
            CmbAy = new ComboBox();
            label2 = new Label();
            LblAyKazanc = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(257, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 18);
            label1.TabIndex = 0;
            label1.Text = "Kasadaki Para :";
            // 
            // LblPara
            // 
            LblPara.AutoSize = true;
            LblPara.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblPara.Location = new Point(381, 17);
            LblPara.Name = "LblPara";
            LblPara.Size = new Size(18, 18);
            LblPara.TabIndex = 1;
            LblPara.Text = "0";
            // 
            // CmbAy
            // 
            CmbAy.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CmbAy.FormattingEnabled = true;
            CmbAy.Location = new Point(96, 17);
            CmbAy.Name = "CmbAy";
            CmbAy.Size = new Size(155, 26);
            CmbAy.TabIndex = 2;
            CmbAy.SelectedIndexChanged += CmbAy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(78, 18);
            label2.TabIndex = 3;
            label2.Text = "Ay Seçin :";
            // 
            // LblAyKazanc
            // 
            LblAyKazanc.AutoSize = true;
            LblAyKazanc.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblAyKazanc.Location = new Point(381, 51);
            LblAyKazanc.Name = "LblAyKazanc";
            LblAyKazanc.Size = new Size(18, 18);
            LblAyKazanc.TabIndex = 5;
            LblAyKazanc.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(285, 51);
            label4.Name = "label4";
            label4.Size = new Size(90, 18);
            label4.TabIndex = 4;
            label4.Text = "Seçilen Ay :";
            // 
            // FrmGelirİstatistik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(459, 101);
            Controls.Add(LblAyKazanc);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(CmbAy);
            Controls.Add(LblPara);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGelirİstatistik";
            Text = "Gelir İstatistik";
            Load += FrmGelirİstatistik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LblPara;
        private ComboBox CmbAy;
        private Label label2;
        private Label LblAyKazanc;
        private Label label4;
    }
}
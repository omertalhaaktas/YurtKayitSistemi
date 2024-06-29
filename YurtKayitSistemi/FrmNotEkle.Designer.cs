namespace YurtKayitSistemi
{
    partial class FrmNotEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotEkle));
            BtnKaydet = new Button();
            richTextBox1 = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(188, 289);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(279, 46);
            BtnKaydet.TabIndex = 0;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(455, 271);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // FrmNotEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(479, 347);
            Controls.Add(richTextBox1);
            Controls.Add(BtnKaydet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmNotEkle";
            Text = "Not Oluştur";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnKaydet;
        private RichTextBox richTextBox1;
        private SaveFileDialog saveFileDialog1;
    }
}
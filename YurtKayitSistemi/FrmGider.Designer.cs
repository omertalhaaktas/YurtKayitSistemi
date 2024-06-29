namespace YurtKayitSistemi
{
    partial class FrmGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGider));
            TxtElektrik = new TextBox();
            label1 = new Label();
            TxtSu = new TextBox();
            label2 = new Label();
            TxtPersonel = new TextBox();
            label3 = new Label();
            TxtGida = new TextBox();
            label4 = new Label();
            TxtInternet = new TextBox();
            label5 = new Label();
            TxtDogalGaz = new TextBox();
            label6 = new Label();
            TxtDiger = new TextBox();
            label7 = new Label();
            BtnKaydet = new Button();
            SuspendLayout();
            // 
            // TxtElektrik
            // 
            TxtElektrik.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtElektrik.Location = new Point(110, 22);
            TxtElektrik.Name = "TxtElektrik";
            TxtElektrik.Size = new Size(237, 26);
            TxtElektrik.TabIndex = 1;
            TxtElektrik.TextChanged += TxtElektrik_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 49;
            label1.Text = "Elektrik :";
            label1.Click += label1_Click;
            // 
            // TxtSu
            // 
            TxtSu.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSu.Location = new Point(110, 54);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(237, 26);
            TxtSu.TabIndex = 2;
            TxtSu.TextChanged += TxtSu_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(70, 57);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 51;
            label2.Text = "Su :";
            label2.Click += label2_Click;
            // 
            // TxtPersonel
            // 
            TxtPersonel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPersonel.Location = new Point(110, 182);
            TxtPersonel.Name = "TxtPersonel";
            TxtPersonel.Size = new Size(237, 26);
            TxtPersonel.TabIndex = 6;
            TxtPersonel.TextChanged += TxtPersonel_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 185);
            label3.Name = "label3";
            label3.Size = new Size(73, 18);
            label3.TabIndex = 53;
            label3.Text = "Personel :";
            label3.Click += label3_Click;
            // 
            // TxtGida
            // 
            TxtGida.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtGida.Location = new Point(110, 150);
            TxtGida.Name = "TxtGida";
            TxtGida.Size = new Size(237, 26);
            TxtGida.TabIndex = 5;
            TxtGida.TextChanged += TxtGida_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 153);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 55;
            label4.Text = "Gıda :";
            label4.Click += label4_Click;
            // 
            // TxtInternet
            // 
            TxtInternet.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtInternet.Location = new Point(110, 118);
            TxtInternet.Name = "TxtInternet";
            TxtInternet.Size = new Size(237, 26);
            TxtInternet.TabIndex = 4;
            TxtInternet.TextChanged += TxtInternet_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 121);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 57;
            label5.Text = "İnternet :";
            label5.Click += label5_Click;
            // 
            // TxtDogalGaz
            // 
            TxtDogalGaz.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDogalGaz.Location = new Point(110, 86);
            TxtDogalGaz.Name = "TxtDogalGaz";
            TxtDogalGaz.Size = new Size(237, 26);
            TxtDogalGaz.TabIndex = 3;
            TxtDogalGaz.TextChanged += TxtDogalGaz_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 89);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 59;
            label6.Text = "Doğal Gaz :";
            label6.Click += label6_Click;
            // 
            // TxtDiger
            // 
            TxtDiger.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDiger.Location = new Point(110, 214);
            TxtDiger.Name = "TxtDiger";
            TxtDiger.Size = new Size(237, 26);
            TxtDiger.TabIndex = 7;
            TxtDiger.TextChanged += TxtDiger_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(51, 217);
            label7.Name = "label7";
            label7.Size = new Size(53, 18);
            label7.TabIndex = 61;
            label7.Text = "Diğer :";
            label7.Click += label7_Click;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnKaydet.Location = new Point(208, 259);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(139, 39);
            BtnKaydet.TabIndex = 8;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // FrmGider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(395, 330);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtDiger);
            Controls.Add(label7);
            Controls.Add(TxtDogalGaz);
            Controls.Add(label6);
            Controls.Add(TxtInternet);
            Controls.Add(label5);
            Controls.Add(TxtGida);
            Controls.Add(label4);
            Controls.Add(TxtPersonel);
            Controls.Add(label3);
            Controls.Add(TxtSu);
            Controls.Add(label2);
            Controls.Add(TxtElektrik);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGider";
            Text = "Giderler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtElektrik;
        private Label label1;
        private TextBox TxtSu;
        private Label label2;
        private TextBox TxtPersonel;
        private Label label3;
        private TextBox TxtGida;
        private Label label4;
        private TextBox TxtInternet;
        private Label label5;
        private TextBox TxtDogalGaz;
        private Label label6;
        private TextBox TxtDiger;
        private Label label7;
        private Button BtnKaydet;
    }
}
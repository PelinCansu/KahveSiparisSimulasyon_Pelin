namespace WFA_KahveDukkaniUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblKasa1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uretim1 = new System.Windows.Forms.Label();
            this.uretim2 = new System.Windows.Forms.Label();
            this.uretimHatti3 = new System.Windows.Forms.Label();
            this.uretimHatti4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCalisan = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.cmbEkstralar = new System.Windows.Forms.ComboBox();
            this.cmbKahveler = new System.Windows.Forms.ComboBox();
            this.btnSiparisiYonlendir1 = new System.Windows.Forms.Button();
            this.btnSiparisYonlendir2 = new System.Windows.Forms.Button();
            this.btnSiparisiYonlendir3 = new System.Windows.Forms.Button();
            this.btnSiparisiYonlendir4 = new System.Windows.Forms.Button();
            this.btnKasayaGonder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKasa1
            // 
            this.lblKasa1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKasa1.Location = new System.Drawing.Point(450, 48);
            this.lblKasa1.Name = "lblKasa1";
            this.lblKasa1.Size = new System.Drawing.Size(217, 54);
            this.lblKasa1.TabIndex = 1;
            this.lblKasa1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kasa 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Üretim Hattı 1";
            // 
            // uretim1
            // 
            this.uretim1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uretim1.Location = new System.Drawing.Point(162, 408);
            this.uretim1.Name = "uretim1";
            this.uretim1.Size = new System.Drawing.Size(407, 54);
            this.uretim1.TabIndex = 1;
            this.uretim1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uretim2
            // 
            this.uretim2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uretim2.Location = new System.Drawing.Point(609, 408);
            this.uretim2.Name = "uretim2";
            this.uretim2.Size = new System.Drawing.Size(413, 54);
            this.uretim2.TabIndex = 1;
            this.uretim2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uretimHatti3
            // 
            this.uretimHatti3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uretimHatti3.Location = new System.Drawing.Point(162, 519);
            this.uretimHatti3.Name = "uretimHatti3";
            this.uretimHatti3.Size = new System.Drawing.Size(407, 54);
            this.uretimHatti3.TabIndex = 1;
            this.uretimHatti3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uretimHatti4
            // 
            this.uretimHatti4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uretimHatti4.Location = new System.Drawing.Point(609, 519);
            this.uretimHatti4.Name = "uretimHatti4";
            this.uretimHatti4.Size = new System.Drawing.Size(413, 54);
            this.uretimHatti4.TabIndex = 1;
            this.uretimHatti4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Üretim Hattı 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Üretim Hattı 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Üretim Hattı 4";
            // 
            // lstCalisan
            // 
            this.lstCalisan.FormattingEnabled = true;
            this.lstCalisan.ItemHeight = 20;
            this.lstCalisan.Location = new System.Drawing.Point(12, 12);
            this.lstCalisan.Name = "lstCalisan";
            this.lstCalisan.Size = new System.Drawing.Size(407, 144);
            this.lstCalisan.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Hazırlama Süresi (Dakika):";
            // 
            // lblSure
            // 
            this.lblSure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSure.Location = new System.Drawing.Point(450, 241);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(217, 45);
            this.lblSure.TabIndex = 13;
            // 
            // cmbEkstralar
            // 
            this.cmbEkstralar.FormattingEnabled = true;
            this.cmbEkstralar.Location = new System.Drawing.Point(450, 159);
            this.cmbEkstralar.Name = "cmbEkstralar";
            this.cmbEkstralar.Size = new System.Drawing.Size(217, 28);
            this.cmbEkstralar.TabIndex = 10;
            // 
            // cmbKahveler
            // 
            this.cmbKahveler.FormattingEnabled = true;
            this.cmbKahveler.Location = new System.Drawing.Point(450, 116);
            this.cmbKahveler.Name = "cmbKahveler";
            this.cmbKahveler.Size = new System.Drawing.Size(217, 28);
            this.cmbKahveler.TabIndex = 11;
            // 
            // btnSiparisiYonlendir1
            // 
            this.btnSiparisiYonlendir1.Location = new System.Drawing.Point(719, 48);
            this.btnSiparisiYonlendir1.Name = "btnSiparisiYonlendir1";
            this.btnSiparisiYonlendir1.Size = new System.Drawing.Size(211, 51);
            this.btnSiparisiYonlendir1.TabIndex = 9;
            this.btnSiparisiYonlendir1.Text = "Siparişi 1. Hatta Yönlendir";
            this.btnSiparisiYonlendir1.UseVisualStyleBackColor = true;
            this.btnSiparisiYonlendir1.Click += new System.EventHandler(this.btnSiparisiYonlendir1_Click);
            // 
            // btnSiparisYonlendir2
            // 
            this.btnSiparisYonlendir2.Location = new System.Drawing.Point(719, 104);
            this.btnSiparisYonlendir2.Name = "btnSiparisYonlendir2";
            this.btnSiparisYonlendir2.Size = new System.Drawing.Size(211, 51);
            this.btnSiparisYonlendir2.TabIndex = 9;
            this.btnSiparisYonlendir2.Text = "Siparişi 2. Hatta Yönlendir";
            this.btnSiparisYonlendir2.UseVisualStyleBackColor = true;
            this.btnSiparisYonlendir2.Click += new System.EventHandler(this.btnSiparisYonlendir2_Click);
            // 
            // btnSiparisiYonlendir3
            // 
            this.btnSiparisiYonlendir3.Location = new System.Drawing.Point(719, 161);
            this.btnSiparisiYonlendir3.Name = "btnSiparisiYonlendir3";
            this.btnSiparisiYonlendir3.Size = new System.Drawing.Size(211, 51);
            this.btnSiparisiYonlendir3.TabIndex = 9;
            this.btnSiparisiYonlendir3.Text = "Siparişi 3. Hatta Yönlendir";
            this.btnSiparisiYonlendir3.UseVisualStyleBackColor = true;
            this.btnSiparisiYonlendir3.Click += new System.EventHandler(this.btnSiparisiYonlendir3_Click);
            // 
            // btnSiparisiYonlendir4
            // 
            this.btnSiparisiYonlendir4.Location = new System.Drawing.Point(719, 218);
            this.btnSiparisiYonlendir4.Name = "btnSiparisiYonlendir4";
            this.btnSiparisiYonlendir4.Size = new System.Drawing.Size(211, 51);
            this.btnSiparisiYonlendir4.TabIndex = 9;
            this.btnSiparisiYonlendir4.Text = "Siparişi 4. Hatta Yönlendir";
            this.btnSiparisiYonlendir4.UseVisualStyleBackColor = true;
            this.btnSiparisiYonlendir4.Click += new System.EventHandler(this.btnSiparisiYonlendir4_Click);
            // 
            // btnKasayaGonder
            // 
            this.btnKasayaGonder.Location = new System.Drawing.Point(92, 195);
            this.btnKasayaGonder.Name = "btnKasayaGonder";
            this.btnKasayaGonder.Size = new System.Drawing.Size(226, 74);
            this.btnKasayaGonder.TabIndex = 16;
            this.btnKasayaGonder.Text = "Çalışanı Kasaya Gönder";
            this.btnKasayaGonder.UseVisualStyleBackColor = true;
            this.btnKasayaGonder.Click += new System.EventHandler(this.btnKasayaGonder_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 603);
            this.Controls.Add(this.btnKasayaGonder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.cmbEkstralar);
            this.Controls.Add(this.cmbKahveler);
            this.Controls.Add(this.btnSiparisiYonlendir4);
            this.Controls.Add(this.btnSiparisiYonlendir3);
            this.Controls.Add(this.btnSiparisYonlendir2);
            this.Controls.Add(this.btnSiparisiYonlendir1);
            this.Controls.Add(this.lstCalisan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uretimHatti4);
            this.Controls.Add(this.uretimHatti3);
            this.Controls.Add(this.uretim2);
            this.Controls.Add(this.uretim1);
            this.Controls.Add(this.lblKasa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblKasa1;
        private Label label1;
        private Label label3;
        private Label uretim1;
        private Label uretim2;
        private Label uretimHatti3;
        private Label uretimHatti4;
        private Label label6;
        private Label label2;
        private Label label4;
        private ListBox lstCalisan;
        private Label label7;
        private Label lblSure;
        private ComboBox cmbEkstralar;
        private ComboBox cmbKahveler;
        private Button btnSiparisiYonlendir1;
        private Button btnSiparisYonlendir2;
        private Button btnSiparisiYonlendir3;
        private Button btnSiparisiYonlendir4;
        private Button btnKasayaGonder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}
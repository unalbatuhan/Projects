namespace School_Project
{
    partial class Form1
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.grpboxSecimEkrani = new System.Windows.Forms.GroupBox();
            this.txtUrunAdet = new System.Windows.Forms.TextBox();
            this.btnKdv1 = new System.Windows.Forms.Button();
            this.btnKdv8 = new System.Windows.Forms.Button();
            this.btnKdv18 = new System.Windows.Forms.Button();
            this.grpboxUrunBilgileri = new System.Windows.Forms.GroupBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtUrunDetay = new System.Windows.Forms.TextBox();
            this.btnUrunDetay = new System.Windows.Forms.Button();
            this.grpboxSecimEkrani.SuspendLayout();
            this.grpboxUrunBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(15, 30);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(84, 27);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(129, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Location = new System.Drawing.Point(15, 79);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(63, 13);
            this.lblUrunFiyati.TabIndex = 2;
            this.lblUrunFiyati.Text = "Ürün Fiyatı :";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(84, 76);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(129, 20);
            this.txtUrunFiyati.TabIndex = 3;
            this.txtUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyati_KeyPress);
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(17, 126);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(61, 13);
            this.lblUrunAdet.TabIndex = 4;
            this.lblUrunAdet.Text = "Ürün Adet :";
            // 
            // grpboxSecimEkrani
            // 
            this.grpboxSecimEkrani.Controls.Add(this.txtToplam);
            this.grpboxSecimEkrani.Controls.Add(this.lblToplam);
            this.grpboxSecimEkrani.Controls.Add(this.btnKdv18);
            this.grpboxSecimEkrani.Controls.Add(this.btnKdv8);
            this.grpboxSecimEkrani.Controls.Add(this.btnKdv1);
            this.grpboxSecimEkrani.Controls.Add(this.txtUrunAdet);
            this.grpboxSecimEkrani.Controls.Add(this.lblUrunAdi);
            this.grpboxSecimEkrani.Controls.Add(this.lblUrunAdet);
            this.grpboxSecimEkrani.Controls.Add(this.txtUrunAdi);
            this.grpboxSecimEkrani.Controls.Add(this.txtUrunFiyati);
            this.grpboxSecimEkrani.Controls.Add(this.lblUrunFiyati);
            this.grpboxSecimEkrani.Location = new System.Drawing.Point(12, 12);
            this.grpboxSecimEkrani.Name = "grpboxSecimEkrani";
            this.grpboxSecimEkrani.Size = new System.Drawing.Size(553, 205);
            this.grpboxSecimEkrani.TabIndex = 5;
            this.grpboxSecimEkrani.TabStop = false;
            this.grpboxSecimEkrani.Text = "Seçim Ekranı";
            // 
            // txtUrunAdet
            // 
            this.txtUrunAdet.Location = new System.Drawing.Point(84, 119);
            this.txtUrunAdet.Name = "txtUrunAdet";
            this.txtUrunAdet.Size = new System.Drawing.Size(129, 20);
            this.txtUrunAdet.TabIndex = 5;
            this.txtUrunAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunAdet_KeyPress);
            // 
            // btnKdv1
            // 
            this.btnKdv1.Location = new System.Drawing.Point(386, 20);
            this.btnKdv1.Name = "btnKdv1";
            this.btnKdv1.Size = new System.Drawing.Size(116, 23);
            this.btnKdv1.TabIndex = 6;
            this.btnKdv1.Text = "%1 KDV  Hesapla";
            this.btnKdv1.UseVisualStyleBackColor = true;
            this.btnKdv1.Click += new System.EventHandler(this.btnKdv1_Click);
            // 
            // btnKdv8
            // 
            this.btnKdv8.Location = new System.Drawing.Point(386, 69);
            this.btnKdv8.Name = "btnKdv8";
            this.btnKdv8.Size = new System.Drawing.Size(116, 23);
            this.btnKdv8.TabIndex = 7;
            this.btnKdv8.Text = "%8 KDV Hesapla";
            this.btnKdv8.UseVisualStyleBackColor = true;
            this.btnKdv8.Click += new System.EventHandler(this.btnKdv8_Click);
            // 
            // btnKdv18
            // 
            this.btnKdv18.Location = new System.Drawing.Point(386, 121);
            this.btnKdv18.Name = "btnKdv18";
            this.btnKdv18.Size = new System.Drawing.Size(116, 23);
            this.btnKdv18.TabIndex = 8;
            this.btnKdv18.Text = "%18 KDV Hesapla";
            this.btnKdv18.UseVisualStyleBackColor = true;
            this.btnKdv18.Click += new System.EventHandler(this.btnKdv18_Click);
            // 
            // grpboxUrunBilgileri
            // 
            this.grpboxUrunBilgileri.Controls.Add(this.btnUrunDetay);
            this.grpboxUrunBilgileri.Controls.Add(this.txtUrunDetay);
            this.grpboxUrunBilgileri.Location = new System.Drawing.Point(12, 223);
            this.grpboxUrunBilgileri.Name = "grpboxUrunBilgileri";
            this.grpboxUrunBilgileri.Size = new System.Drawing.Size(553, 163);
            this.grpboxUrunBilgileri.TabIndex = 6;
            this.grpboxUrunBilgileri.TabStop = false;
            this.grpboxUrunBilgileri.Text = "Ürün Detayları";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(217, 171);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(48, 13);
            this.lblToplam.TabIndex = 9;
            this.lblToplam.Text = "Toplam :";
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(271, 168);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(100, 20);
            this.txtToplam.TabIndex = 10;
            // 
            // txtUrunDetay
            // 
            this.txtUrunDetay.Location = new System.Drawing.Point(18, 19);
            this.txtUrunDetay.Multiline = true;
            this.txtUrunDetay.Name = "txtUrunDetay";
            this.txtUrunDetay.Size = new System.Drawing.Size(363, 129);
            this.txtUrunDetay.TabIndex = 11;
            // 
            // btnUrunDetay
            // 
            this.btnUrunDetay.Location = new System.Drawing.Point(418, 75);
            this.btnUrunDetay.Name = "btnUrunDetay";
            this.btnUrunDetay.Size = new System.Drawing.Size(111, 25);
            this.btnUrunDetay.TabIndex = 12;
            this.btnUrunDetay.Text = "Ürün Bilgileri";
            this.btnUrunDetay.UseVisualStyleBackColor = true;
            this.btnUrunDetay.Click += new System.EventHandler(this.btnUrunDetay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 398);
            this.Controls.Add(this.grpboxUrunBilgileri);
            this.Controls.Add(this.grpboxSecimEkrani);
            this.Name = "Form1";
            this.Text = "Okul Proje";
            this.grpboxSecimEkrani.ResumeLayout(false);
            this.grpboxSecimEkrani.PerformLayout();
            this.grpboxUrunBilgileri.ResumeLayout(false);
            this.grpboxUrunBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.GroupBox grpboxSecimEkrani;
        private System.Windows.Forms.TextBox txtUrunAdet;
        private System.Windows.Forms.Button btnKdv18;
        private System.Windows.Forms.Button btnKdv8;
        private System.Windows.Forms.Button btnKdv1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.GroupBox grpboxUrunBilgileri;
        private System.Windows.Forms.Button btnUrunDetay;
        private System.Windows.Forms.TextBox txtUrunDetay;
    }
}


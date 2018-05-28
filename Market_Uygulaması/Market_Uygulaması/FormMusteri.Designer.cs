namespace Market_Uygulaması
{
    partial class FormMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteri));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdı = new System.Windows.Forms.TextBox();
            this.btnListele1 = new DevExpress.XtraEditors.SimpleButton();
            this.lboxUrunler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiyat1 = new System.Windows.Forms.TextBox();
            this.txtFiyat2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnListele2 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.btnListele3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSepetAltKategori = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtSepetKategori = new System.Windows.Forms.TextBox();
            this.btnSepet = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSepeteGit = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHeapSepet = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnListe4 = new DevExpress.XtraEditors.SimpleButton();
            this.txtHeapAltKategori = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtUrunAra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtUrunAdı
            // 
            this.txtUrunAdı.Location = new System.Drawing.Point(123, 91);
            this.txtUrunAdı.Name = "txtUrunAdı";
            this.txtUrunAdı.Size = new System.Drawing.Size(211, 22);
            this.txtUrunAdı.TabIndex = 1;
            // 
            // btnListele1
            // 
            this.btnListele1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele1.ImageOptions.Image")));
            this.btnListele1.Location = new System.Drawing.Point(356, 77);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(170, 50);
            this.btnListele1.TabIndex = 2;
            this.btnListele1.Text = "Ürünleri Listele";
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // lboxUrunler
            // 
            this.lboxUrunler.FormattingEnabled = true;
            this.lboxUrunler.ItemHeight = 16;
            this.lboxUrunler.Location = new System.Drawing.Point(567, 80);
            this.lboxUrunler.Name = "lboxUrunler";
            this.lboxUrunler.Size = new System.Drawing.Size(621, 388);
            this.lboxUrunler.TabIndex = 3;
            this.lboxUrunler.SelectedIndexChanged += new System.EventHandler(this.lboxUrunler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat Aralığı:";
            // 
            // txtFiyat1
            // 
            this.txtFiyat1.Location = new System.Drawing.Point(124, 163);
            this.txtFiyat1.Name = "txtFiyat1";
            this.txtFiyat1.Size = new System.Drawing.Size(91, 22);
            this.txtFiyat1.TabIndex = 5;
            // 
            // txtFiyat2
            // 
            this.txtFiyat2.Location = new System.Drawing.Point(243, 163);
            this.txtFiyat2.Name = "txtFiyat2";
            this.txtFiyat2.Size = new System.Drawing.Size(92, 22);
            this.txtFiyat2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(222, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // btnListele2
            // 
            this.btnListele2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele2.ImageOptions.Image")));
            this.btnListele2.Location = new System.Drawing.Point(356, 149);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(170, 50);
            this.btnListele2.TabIndex = 8;
            this.btnListele2.Text = "Ürünleri Listele";
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kategori:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(123, 237);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(211, 22);
            this.txtKategori.TabIndex = 10;
            // 
            // btnListele3
            // 
            this.btnListele3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListele3.ImageOptions.Image")));
            this.btnListele3.Location = new System.Drawing.Point(356, 223);
            this.btnListele3.Name = "btnListele3";
            this.btnListele3.Size = new System.Drawing.Size(170, 50);
            this.btnListele3.TabIndex = 11;
            this.btnListele3.Text = "Ürünleri Listele";
            this.btnListele3.Click += new System.EventHandler(this.btnListele3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSepetAltKategori);
            this.groupBox1.Controls.Add(this.txtSeriNo);
            this.groupBox1.Controls.Add(this.txtSepetKategori);
            this.groupBox1.Controls.Add(this.btnSepet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(640, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 231);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satın Alma İşlemleri";
            // 
            // txtSepetAltKategori
            // 
            this.txtSepetAltKategori.Location = new System.Drawing.Point(153, 105);
            this.txtSepetAltKategori.Name = "txtSepetAltKategori";
            this.txtSepetAltKategori.Size = new System.Drawing.Size(211, 25);
            this.txtSepetAltKategori.TabIndex = 25;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(153, 25);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(211, 25);
            this.txtSeriNo.TabIndex = 23;
            // 
            // txtSepetKategori
            // 
            this.txtSepetKategori.Location = new System.Drawing.Point(153, 64);
            this.txtSepetKategori.Name = "txtSepetKategori";
            this.txtSepetKategori.Size = new System.Drawing.Size(211, 25);
            this.txtSepetKategori.TabIndex = 24;
            // 
            // btnSepet
            // 
            this.btnSepet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSepet.ImageOptions.Image")));
            this.btnSepet.Location = new System.Drawing.Point(153, 164);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(170, 50);
            this.btnSepet.TabIndex = 19;
            this.btnSepet.Text = "Sepete Ekle";
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(82, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Seri No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ürün AltKategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ürün Kategori:";
            // 
            // btnSepeteGit
            // 
            this.btnSepeteGit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSepeteGit.ImageOptions.Image")));
            this.btnSepeteGit.Location = new System.Drawing.Point(54, 12);
            this.btnSepeteGit.Name = "btnSepeteGit";
            this.btnSepeteGit.Size = new System.Drawing.Size(161, 55);
            this.btnSepeteGit.TabIndex = 21;
            this.btnSepeteGit.Text = "Sepete Git";
            this.btnSepeteGit.Click += new System.EventHandler(this.btnSepeteGit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHeapSepet);
            this.groupBox2.Controls.Add(this.txtAdet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnListe4);
            this.groupBox2.Controls.Add(this.txtHeapAltKategori);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 187);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heap Ağacı İşlemleri";
            // 
            // btnHeapSepet
            // 
            this.btnHeapSepet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHeapSepet.ImageOptions.Image")));
            this.btnHeapSepet.Location = new System.Drawing.Point(171, 131);
            this.btnHeapSepet.Name = "btnHeapSepet";
            this.btnHeapSepet.Size = new System.Drawing.Size(170, 50);
            this.btnHeapSepet.TabIndex = 26;
            this.btnHeapSepet.Text = "Sepete Ekle";
            this.btnHeapSepet.Click += new System.EventHandler(this.btnHeapSepet_Click_1);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(106, 77);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(211, 24);
            this.txtAdet.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(-4, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Adet Giriniz:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnListe4
            // 
            this.btnListe4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnListe4.ImageOptions.Image")));
            this.btnListe4.Location = new System.Drawing.Point(344, 42);
            this.btnListe4.Name = "btnListe4";
            this.btnListe4.Size = new System.Drawing.Size(170, 50);
            this.btnListe4.TabIndex = 23;
            this.btnListe4.Text = "Ürünleri Listele";
            this.btnListe4.Click += new System.EventHandler(this.btnListe4_Click_1);
            // 
            // txtHeapAltKategori
            // 
            this.txtHeapAltKategori.Location = new System.Drawing.Point(106, 38);
            this.txtHeapAltKategori.Name = "txtHeapAltKategori";
            this.txtHeapAltKategori.Size = new System.Drawing.Size(211, 24);
            this.txtHeapAltKategori.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(-1, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alt Kategori:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAra);
            this.groupBox3.Controls.Add(this.txtUrunAra);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(22, 527);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 118);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hash Tablosu İşlemleri";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(349, 35);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(170, 50);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "ARA";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // txtUrunAra
            // 
            this.txtUrunAra.Location = new System.Drawing.Point(156, 49);
            this.txtUrunAra.Name = "txtUrunAra";
            this.txtUrunAra.Size = new System.Drawing.Size(182, 24);
            this.txtUrunAra.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(7, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "AltKategori Giriniz:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSepeteGit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListele3);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiyat2);
            this.Controls.Add(this.txtFiyat1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxUrunler);
            this.Controls.Add(this.btnListele1);
            this.Controls.Add(this.txtUrunAdı);
            this.Controls.Add(this.label1);
            this.Name = "FormMusteri";
            this.Text = "FormMusteri";
            this.Load += new System.EventHandler(this.FormMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private DevExpress.XtraEditors.SimpleButton btnListele1;
        private System.Windows.Forms.ListBox lboxUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiyat1;
        private System.Windows.Forms.TextBox txtFiyat2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnListele2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKategori;
        private DevExpress.XtraEditors.SimpleButton btnListele3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSepetAltKategori;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtSepetKategori;
        private DevExpress.XtraEditors.SimpleButton btnSepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSepeteGit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnHeapSepet;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnListe4;
        private System.Windows.Forms.TextBox txtHeapAltKategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private System.Windows.Forms.TextBox txtUrunAra;
        private System.Windows.Forms.Label label10;
    }
}
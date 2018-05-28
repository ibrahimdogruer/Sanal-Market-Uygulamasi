namespace Market_Uygulaması
{
    partial class FormSepet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSepet));
            this.lboxSepet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSepetAltKategori = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.txtSepetKategori = new System.Windows.Forms.TextBox();
            this.btnSepet = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatınAl = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboxSepet
            // 
            this.lboxSepet.FormattingEnabled = true;
            this.lboxSepet.ItemHeight = 16;
            this.lboxSepet.Location = new System.Drawing.Point(37, 40);
            this.lboxSepet.Name = "lboxSepet";
            this.lboxSepet.Size = new System.Drawing.Size(353, 324);
            this.lboxSepet.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(409, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 274);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sepet İşlemleri";
            // 
            // txtSepetAltKategori
            // 
            this.txtSepetAltKategori.Location = new System.Drawing.Point(161, 126);
            this.txtSepetAltKategori.Name = "txtSepetAltKategori";
            this.txtSepetAltKategori.Size = new System.Drawing.Size(211, 25);
            this.txtSepetAltKategori.TabIndex = 25;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(161, 46);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(211, 25);
            this.txtSeriNo.TabIndex = 23;
            // 
            // txtSepetKategori
            // 
            this.txtSepetKategori.Location = new System.Drawing.Point(161, 85);
            this.txtSepetKategori.Name = "txtSepetKategori";
            this.txtSepetKategori.Size = new System.Drawing.Size(211, 25);
            this.txtSepetKategori.TabIndex = 24;
            // 
            // btnSepet
            // 
            this.btnSepet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSepet.ImageOptions.Image")));
            this.btnSepet.Location = new System.Drawing.Point(128, 182);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(172, 51);
            this.btnSepet.TabIndex = 19;
            this.btnSepet.Text = "Sepetten Çıkar";
            this.btnSepet.Click += new System.EventHandler(this.btnSepet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(90, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Seri No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ürün AltKategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(43, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ürün Kategori:";
            // 
            // btnSatınAl
            // 
            this.btnSatınAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatınAl.ImageOptions.Image")));
            this.btnSatınAl.Location = new System.Drawing.Point(123, 384);
            this.btnSatınAl.Name = "btnSatınAl";
            this.btnSatınAl.Size = new System.Drawing.Size(190, 58);
            this.btnSatınAl.TabIndex = 26;
            this.btnSatınAl.Text = "Ürünleri Satın Al";
            this.btnSatınAl.Click += new System.EventHandler(this.btnSatınAl_Click);
            // 
            // FormSepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.btnSatınAl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lboxSepet);
            this.Name = "FormSepet";
            this.Text = "FormSepet";
            this.Load += new System.EventHandler(this.FormSepet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxSepet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSepetAltKategori;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.TextBox txtSepetKategori;
        private DevExpress.XtraEditors.SimpleButton btnSepet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnSatınAl;
    }
}
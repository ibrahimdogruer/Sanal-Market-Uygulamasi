namespace Market_Uygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPersonel = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteri = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.ImageOptions.Image")));
            this.btnPersonel.Location = new System.Drawing.Point(164, 169);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(192, 60);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "PERSONEL GİRİŞİ";
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteri.ImageOptions.Image")));
            this.btnMusteri.Location = new System.Drawing.Point(426, 169);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(192, 60);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "MÜŞTERİ GİRİŞİ";
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.btnPersonel);
            this.Name = "Form1";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPersonel;
        private DevExpress.XtraEditors.SimpleButton btnMusteri;
    }
}


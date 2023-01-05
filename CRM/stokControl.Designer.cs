namespace CRM
{
    partial class stokControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.urunAdi_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.stokAdedi_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fiyat_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunAdi_label
            // 
            this.urunAdi_label.AutoSize = true;
            this.urunAdi_label.BackColor = System.Drawing.Color.Transparent;
            this.urunAdi_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.urunAdi_label.Location = new System.Drawing.Point(20, 23);
            this.urunAdi_label.Name = "urunAdi_label";
            this.urunAdi_label.Size = new System.Drawing.Size(77, 21);
            this.urunAdi_label.TabIndex = 19;
            this.urunAdi_label.Text = "Ürün Adı";
            // 
            // stokAdedi_label
            // 
            this.stokAdedi_label.AutoSize = true;
            this.stokAdedi_label.BackColor = System.Drawing.Color.Transparent;
            this.stokAdedi_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAdedi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.stokAdedi_label.Location = new System.Drawing.Point(604, 23);
            this.stokAdedi_label.Name = "stokAdedi_label";
            this.stokAdedi_label.Size = new System.Drawing.Size(95, 21);
            this.stokAdedi_label.TabIndex = 20;
            this.stokAdedi_label.Text = "Stok Adedi";
            // 
            // fiyat_label
            // 
            this.fiyat_label.AutoSize = true;
            this.fiyat_label.BackColor = System.Drawing.Color.Transparent;
            this.fiyat_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.fiyat_label.Location = new System.Drawing.Point(1107, 23);
            this.fiyat_label.Name = "fiyat_label";
            this.fiyat_label.Size = new System.Drawing.Size(50, 21);
            this.fiyat_label.TabIndex = 21;
            this.fiyat_label.Text = "Fiyatı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.urunAdi_label);
            this.panel1.Controls.Add(this.fiyat_label);
            this.panel1.Controls.Add(this.stokAdedi_label);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 70);
            this.panel1.TabIndex = 22;
            // 
            // stokControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "stokControl";
            this.Size = new System.Drawing.Size(1307, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomLabel urunAdi_label;
        public Bunifu.Framework.UI.BunifuCustomLabel stokAdedi_label;
        public Bunifu.Framework.UI.BunifuCustomLabel fiyat_label;
        private System.Windows.Forms.Panel panel1;
    }
}

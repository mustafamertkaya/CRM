namespace CRM
{
    partial class musterilerControl
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
            this.isim_label = new System.Windows.Forms.Label();
            this.sirket_label = new System.Windows.Forms.Label();
            this.pozisyon_label = new System.Windows.Forms.Label();
            this.tarih_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isim_label
            // 
            this.isim_label.AutoSize = true;
            this.isim_label.BackColor = System.Drawing.Color.Transparent;
            this.isim_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.isim_label.Location = new System.Drawing.Point(14, 24);
            this.isim_label.Name = "isim_label";
            this.isim_label.Size = new System.Drawing.Size(34, 20);
            this.isim_label.TabIndex = 5;
            this.isim_label.Text = "isim";
            // 
            // sirket_label
            // 
            this.sirket_label.AutoSize = true;
            this.sirket_label.BackColor = System.Drawing.Color.Transparent;
            this.sirket_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sirket_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.sirket_label.Location = new System.Drawing.Point(335, 24);
            this.sirket_label.Name = "sirket_label";
            this.sirket_label.Size = new System.Drawing.Size(46, 20);
            this.sirket_label.TabIndex = 6;
            this.sirket_label.Text = "sirket";
            // 
            // pozisyon_label
            // 
            this.pozisyon_label.AutoSize = true;
            this.pozisyon_label.BackColor = System.Drawing.Color.Transparent;
            this.pozisyon_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozisyon_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pozisyon_label.Location = new System.Drawing.Point(759, 24);
            this.pozisyon_label.Name = "pozisyon_label";
            this.pozisyon_label.Size = new System.Drawing.Size(71, 20);
            this.pozisyon_label.TabIndex = 7;
            this.pozisyon_label.Text = "pozisyon";
            // 
            // tarih_label
            // 
            this.tarih_label.AutoSize = true;
            this.tarih_label.BackColor = System.Drawing.Color.Transparent;
            this.tarih_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tarih_label.Location = new System.Drawing.Point(1119, 24);
            this.tarih_label.Name = "tarih_label";
            this.tarih_label.Size = new System.Drawing.Size(41, 20);
            this.tarih_label.TabIndex = 8;
            this.tarih_label.Text = "tarih";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.isim_label);
            this.panel1.Controls.Add(this.tarih_label);
            this.panel1.Controls.Add(this.sirket_label);
            this.panel1.Controls.Add(this.pozisyon_label);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 70);
            this.panel1.TabIndex = 9;
            // 
            // musterilerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "musterilerControl";
            this.Size = new System.Drawing.Size(1301, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label isim_label;
        public System.Windows.Forms.Label sirket_label;
        public System.Windows.Forms.Label pozisyon_label;
        public System.Windows.Forms.Label tarih_label;
        private System.Windows.Forms.Panel panel1;
    }
}

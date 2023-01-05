namespace CRM
{
    partial class calısanlarControl
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
            this.calisanAdi_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.calisanUnvan_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.calisanTarih_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calisanAdi_label
            // 
            this.calisanAdi_label.AutoSize = true;
            this.calisanAdi_label.BackColor = System.Drawing.Color.Transparent;
            this.calisanAdi_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanAdi_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.calisanAdi_label.Location = new System.Drawing.Point(25, 21);
            this.calisanAdi_label.Name = "calisanAdi_label";
            this.calisanAdi_label.Size = new System.Drawing.Size(102, 21);
            this.calisanAdi_label.TabIndex = 20;
            this.calisanAdi_label.Text = "Çalışan  Adı";
            // 
            // calisanUnvan_label
            // 
            this.calisanUnvan_label.AutoSize = true;
            this.calisanUnvan_label.BackColor = System.Drawing.Color.Transparent;
            this.calisanUnvan_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanUnvan_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.calisanUnvan_label.Location = new System.Drawing.Point(568, 21);
            this.calisanUnvan_label.Name = "calisanUnvan_label";
            this.calisanUnvan_label.Size = new System.Drawing.Size(65, 21);
            this.calisanUnvan_label.TabIndex = 21;
            this.calisanUnvan_label.Text = "Ünvanı";
            // 
            // calisanTarih_label
            // 
            this.calisanTarih_label.AutoSize = true;
            this.calisanTarih_label.BackColor = System.Drawing.Color.Transparent;
            this.calisanTarih_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanTarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.calisanTarih_label.Location = new System.Drawing.Point(1051, 21);
            this.calisanTarih_label.Name = "calisanTarih_label";
            this.calisanTarih_label.Size = new System.Drawing.Size(145, 21);
            this.calisanTarih_label.TabIndex = 24;
            this.calisanTarih_label.Text = "İşe Başlama Tarihi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.calisanTarih_label);
            this.panel1.Controls.Add(this.calisanAdi_label);
            this.panel1.Controls.Add(this.calisanUnvan_label);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 70);
            this.panel1.TabIndex = 25;
            // 
            // calısanlarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "calısanlarControl";
            this.Size = new System.Drawing.Size(1304, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomLabel calisanAdi_label;
        public Bunifu.Framework.UI.BunifuCustomLabel calisanUnvan_label;
        public Bunifu.Framework.UI.BunifuCustomLabel calisanTarih_label;
        private System.Windows.Forms.Panel panel1;
    }
}

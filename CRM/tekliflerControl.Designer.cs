namespace CRM
{
    partial class tekliflerControl
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
            this.tklfVeren_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tklfSirket_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tklfDeger_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tarih_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tklfVeren_label
            // 
            this.tklfVeren_label.AutoSize = true;
            this.tklfVeren_label.BackColor = System.Drawing.Color.Transparent;
            this.tklfVeren_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tklfVeren_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tklfVeren_label.Location = new System.Drawing.Point(19, 24);
            this.tklfVeren_label.Name = "tklfVeren_label";
            this.tklfVeren_label.Size = new System.Drawing.Size(97, 21);
            this.tklfVeren_label.TabIndex = 20;
            this.tklfVeren_label.Text = "Teklif Veren";
            // 
            // tklfSirket_label
            // 
            this.tklfSirket_label.AutoSize = true;
            this.tklfSirket_label.BackColor = System.Drawing.Color.Transparent;
            this.tklfSirket_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tklfSirket_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tklfSirket_label.Location = new System.Drawing.Point(372, 24);
            this.tklfSirket_label.Name = "tklfSirket_label";
            this.tklfSirket_label.Size = new System.Drawing.Size(148, 21);
            this.tklfSirket_label.TabIndex = 21;
            this.tklfSirket_label.Text = "Teklif Verilen Şirket";
            // 
            // tklfDeger_label
            // 
            this.tklfDeger_label.AutoSize = true;
            this.tklfDeger_label.BackColor = System.Drawing.Color.Transparent;
            this.tklfDeger_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tklfDeger_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tklfDeger_label.Location = new System.Drawing.Point(782, 24);
            this.tklfDeger_label.Name = "tklfDeger_label";
            this.tklfDeger_label.Size = new System.Drawing.Size(102, 21);
            this.tklfDeger_label.TabIndex = 22;
            this.tklfDeger_label.Text = "Teklif Değeri";
            // 
            // tarih_label
            // 
            this.tarih_label.AutoSize = true;
            this.tarih_label.BackColor = System.Drawing.Color.Transparent;
            this.tarih_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tarih_label.Location = new System.Drawing.Point(1096, 24);
            this.tarih_label.Name = "tarih_label";
            this.tarih_label.Size = new System.Drawing.Size(47, 21);
            this.tarih_label.TabIndex = 23;
            this.tarih_label.Text = "Tarih";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tklfDeger_label);
            this.panel1.Controls.Add(this.tarih_label);
            this.panel1.Controls.Add(this.tklfVeren_label);
            this.panel1.Controls.Add(this.tklfSirket_label);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 70);
            this.panel1.TabIndex = 24;
            // 
            // tekliflerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "tekliflerControl";
            this.Size = new System.Drawing.Size(1298, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomLabel tklfVeren_label;
        public Bunifu.Framework.UI.BunifuCustomLabel tklfSirket_label;
        public Bunifu.Framework.UI.BunifuCustomLabel tklfDeger_label;
        public Bunifu.Framework.UI.BunifuCustomLabel tarih_label;
        private System.Windows.Forms.Panel panel1;
    }
}

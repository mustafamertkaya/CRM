namespace CRM
{
    partial class siparislerControl
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
            this.siparisVeren_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.siparisUrun_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.siparisMiktar_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.siparisTarih_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siparisVeren_label
            // 
            this.siparisVeren_label.AutoSize = true;
            this.siparisVeren_label.BackColor = System.Drawing.Color.Transparent;
            this.siparisVeren_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisVeren_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siparisVeren_label.Location = new System.Drawing.Point(23, 23);
            this.siparisVeren_label.Name = "siparisVeren_label";
            this.siparisVeren_label.Size = new System.Drawing.Size(107, 21);
            this.siparisVeren_label.TabIndex = 21;
            this.siparisVeren_label.Text = "Siparis Veren";
            // 
            // siparisUrun_label
            // 
            this.siparisUrun_label.AutoSize = true;
            this.siparisUrun_label.BackColor = System.Drawing.Color.Transparent;
            this.siparisUrun_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisUrun_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siparisUrun_label.Location = new System.Drawing.Point(424, 23);
            this.siparisUrun_label.Name = "siparisUrun_label";
            this.siparisUrun_label.Size = new System.Drawing.Size(46, 21);
            this.siparisUrun_label.TabIndex = 22;
            this.siparisUrun_label.Text = "Ürün";
            // 
            // siparisMiktar_label
            // 
            this.siparisMiktar_label.AutoSize = true;
            this.siparisMiktar_label.BackColor = System.Drawing.Color.Transparent;
            this.siparisMiktar_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisMiktar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siparisMiktar_label.Location = new System.Drawing.Point(865, 23);
            this.siparisMiktar_label.Name = "siparisMiktar_label";
            this.siparisMiktar_label.Size = new System.Drawing.Size(113, 21);
            this.siparisMiktar_label.TabIndex = 23;
            this.siparisMiktar_label.Text = "Sipariş Miktarı";
            // 
            // siparisTarih_label
            // 
            this.siparisTarih_label.AutoSize = true;
            this.siparisTarih_label.BackColor = System.Drawing.Color.Transparent;
            this.siparisTarih_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparisTarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.siparisTarih_label.Location = new System.Drawing.Point(1115, 23);
            this.siparisTarih_label.Name = "siparisTarih_label";
            this.siparisTarih_label.Size = new System.Drawing.Size(47, 21);
            this.siparisTarih_label.TabIndex = 24;
            this.siparisTarih_label.Text = "Tarih";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.siparisUrun_label);
            this.panel1.Controls.Add(this.siparisTarih_label);
            this.panel1.Controls.Add(this.siparisVeren_label);
            this.panel1.Controls.Add(this.siparisMiktar_label);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 70);
            this.panel1.TabIndex = 25;
            // 
            // siparislerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "siparislerControl";
            this.Size = new System.Drawing.Size(1294, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomLabel siparisVeren_label;
        public Bunifu.Framework.UI.BunifuCustomLabel siparisUrun_label;
        public Bunifu.Framework.UI.BunifuCustomLabel siparisMiktar_label;
        public Bunifu.Framework.UI.BunifuCustomLabel siparisTarih_label;
        private System.Windows.Forms.Panel panel1;
    }
}

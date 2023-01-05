namespace CRM
{
    partial class UserControl1
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
            this.acıklama_label = new System.Windows.Forms.Label();
            this.tarih_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acıklama_label
            // 
            this.acıklama_label.AutoSize = true;
            this.acıklama_label.BackColor = System.Drawing.Color.Transparent;
            this.acıklama_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acıklama_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.acıklama_label.Location = new System.Drawing.Point(12, 24);
            this.acıklama_label.Name = "acıklama_label";
            this.acıklama_label.Size = new System.Drawing.Size(119, 20);
            this.acıklama_label.TabIndex = 4;
            this.acıklama_label.Text = "deneme ekledi";
            // 
            // tarih_label
            // 
            this.tarih_label.AutoSize = true;
            this.tarih_label.BackColor = System.Drawing.Color.Transparent;
            this.tarih_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tarih_label.Location = new System.Drawing.Point(1121, 24);
            this.tarih_label.Name = "tarih_label";
            this.tarih_label.Size = new System.Drawing.Size(69, 20);
            this.tarih_label.TabIndex = 5;
            this.tarih_label.Text = "18 subat";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.acıklama_label);
            this.panel1.Controls.Add(this.tarih_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1304, 70);
            this.panel1.TabIndex = 6;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1304, 85);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label acıklama_label;
        public System.Windows.Forms.Label tarih_label;
        private System.Windows.Forms.Panel panel1;
    }
}

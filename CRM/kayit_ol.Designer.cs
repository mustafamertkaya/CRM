namespace CRM
{
    partial class kayit_ol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_ol));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.kayitol_panel = new System.Windows.Forms.Panel();
            this.Kayit_btn_girisyap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.kayit_bildirim = new System.Windows.Forms.Label();
            this.sifre_kontrol1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kayit_btn_kayitol = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.kayit = new System.Windows.Forms.Label();
            this.kayit_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kayit_kullaniciadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kayitol_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // kayitol_panel
            // 
            this.kayitol_panel.Controls.Add(this.Kayit_btn_girisyap);
            this.kayitol_panel.Controls.Add(this.kayit_bildirim);
            this.kayitol_panel.Controls.Add(this.sifre_kontrol1);
            this.kayitol_panel.Controls.Add(this.pictureBox2);
            this.kayitol_panel.Controls.Add(this.pictureBox3);
            this.kayitol_panel.Controls.Add(this.kayit_btn_kayitol);
            this.kayitol_panel.Controls.Add(this.label2);
            this.kayitol_panel.Controls.Add(this.kayit);
            this.kayitol_panel.Controls.Add(this.kayit_sifre);
            this.kayitol_panel.Controls.Add(this.kayit_kullaniciadi);
            this.kayitol_panel.Location = new System.Drawing.Point(0, 0);
            this.kayitol_panel.Name = "kayitol_panel";
            this.kayitol_panel.Size = new System.Drawing.Size(450, 350);
            this.kayitol_panel.TabIndex = 0;
            this.kayitol_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kayitol_panel_MouseMove);
            // 
            // Kayit_btn_girisyap
            // 
            this.Kayit_btn_girisyap.ActiveBorderThickness = 1;
            this.Kayit_btn_girisyap.ActiveCornerRadius = 20;
            this.Kayit_btn_girisyap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Kayit_btn_girisyap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Kayit_btn_girisyap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Kayit_btn_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Kayit_btn_girisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kayit_btn_girisyap.BackgroundImage")));
            this.Kayit_btn_girisyap.ButtonText = "Giriş Yap";
            this.Kayit_btn_girisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kayit_btn_girisyap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kayit_btn_girisyap.ForeColor = System.Drawing.Color.SeaGreen;
            this.Kayit_btn_girisyap.IdleBorderThickness = 1;
            this.Kayit_btn_girisyap.IdleCornerRadius = 20;
            this.Kayit_btn_girisyap.IdleFillColor = System.Drawing.Color.White;
            this.Kayit_btn_girisyap.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Kayit_btn_girisyap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Kayit_btn_girisyap.Location = new System.Drawing.Point(110, 265);
            this.Kayit_btn_girisyap.Margin = new System.Windows.Forms.Padding(5);
            this.Kayit_btn_girisyap.Name = "Kayit_btn_girisyap";
            this.Kayit_btn_girisyap.Size = new System.Drawing.Size(194, 41);
            this.Kayit_btn_girisyap.TabIndex = 33;
            this.Kayit_btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kayit_btn_girisyap.Click += new System.EventHandler(this.Kayit_btn_girisyap_Click);
            // 
            // kayit_bildirim
            // 
            this.kayit_bildirim.AutoSize = true;
            this.kayit_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_bildirim.ForeColor = System.Drawing.Color.OrangeRed;
            this.kayit_bildirim.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.kayit_bildirim.Location = new System.Drawing.Point(8, 318);
            this.kayit_bildirim.Name = "kayit_bildirim";
            this.kayit_bildirim.Size = new System.Drawing.Size(57, 20);
            this.kayit_bildirim.TabIndex = 32;
            this.kayit_bildirim.Text = "bildirim";
            this.kayit_bildirim.Visible = false;
            // 
            // sifre_kontrol1
            // 
            this.sifre_kontrol1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sifre_kontrol1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sifre_kontrol1.Checked = false;
            this.sifre_kontrol1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.sifre_kontrol1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifre_kontrol1.ForeColor = System.Drawing.Color.White;
            this.sifre_kontrol1.Location = new System.Drawing.Point(418, 152);
            this.sifre_kontrol1.Name = "sifre_kontrol1";
            this.sifre_kontrol1.Size = new System.Drawing.Size(20, 20);
            this.sifre_kontrol1.TabIndex = 31;
            this.sifre_kontrol1.OnChange += new System.EventHandler(this.sifre_kontrol1_OnChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 152);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // kayit_btn_kayitol
            // 
            this.kayit_btn_kayitol.ActiveBorderThickness = 1;
            this.kayit_btn_kayitol.ActiveCornerRadius = 20;
            this.kayit_btn_kayitol.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.kayit_btn_kayitol.ActiveForecolor = System.Drawing.Color.Transparent;
            this.kayit_btn_kayitol.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.kayit_btn_kayitol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.kayit_btn_kayitol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kayit_btn_kayitol.BackgroundImage")));
            this.kayit_btn_kayitol.ButtonText = "Kayıt Ol";
            this.kayit_btn_kayitol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayit_btn_kayitol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayit_btn_kayitol.ForeColor = System.Drawing.Color.SeaGreen;
            this.kayit_btn_kayitol.IdleBorderThickness = 1;
            this.kayit_btn_kayitol.IdleCornerRadius = 20;
            this.kayit_btn_kayitol.IdleFillColor = System.Drawing.Color.White;
            this.kayit_btn_kayitol.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.kayit_btn_kayitol.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.kayit_btn_kayitol.Location = new System.Drawing.Point(110, 214);
            this.kayit_btn_kayitol.Margin = new System.Windows.Forms.Padding(5);
            this.kayit_btn_kayitol.Name = "kayit_btn_kayitol";
            this.kayit_btn_kayitol.Size = new System.Drawing.Size(194, 41);
            this.kayit_btn_kayitol.TabIndex = 28;
            this.kayit_btn_kayitol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kayit_btn_kayitol.Click += new System.EventHandler(this.kayit_btn_kayitol_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 1);
            this.label2.TabIndex = 27;
            this.label2.Visible = false;
            // 
            // kayit
            // 
            this.kayit.AutoSize = true;
            this.kayit.BackColor = System.Drawing.Color.Transparent;
            this.kayit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit.ForeColor = System.Drawing.Color.White;
            this.kayit.Location = new System.Drawing.Point(162, 16);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(83, 23);
            this.kayit.TabIndex = 26;
            this.kayit.Text = "Kayıt Ol";
            this.kayit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kayit_MouseMove);
            // 
            // kayit_sifre
            // 
            this.kayit_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayit_sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.kayit_sifre.ForeColor = System.Drawing.Color.White;
            this.kayit_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.kayit_sifre.HintText = "";
            this.kayit_sifre.isPassword = false;
            this.kayit_sifre.LineFocusedColor = System.Drawing.Color.Blue;
            this.kayit_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.kayit_sifre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.kayit_sifre.LineThickness = 3;
            this.kayit_sifre.Location = new System.Drawing.Point(76, 152);
            this.kayit_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.kayit_sifre.Name = "kayit_sifre";
            this.kayit_sifre.Size = new System.Drawing.Size(335, 33);
            this.kayit_sifre.TabIndex = 25;
            this.kayit_sifre.TabStop = false;
            this.kayit_sifre.Text = "Parola";
            this.kayit_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kayit_sifre.Enter += new System.EventHandler(this.kayit_sifre_Enter);
            this.kayit_sifre.Leave += new System.EventHandler(this.kayit_sifre_Leave);
            // 
            // kayit_kullaniciadi
            // 
            this.kayit_kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayit_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.kayit_kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.kayit_kullaniciadi.HintForeColor = System.Drawing.Color.Empty;
            this.kayit_kullaniciadi.HintText = "";
            this.kayit_kullaniciadi.isPassword = false;
            this.kayit_kullaniciadi.LineFocusedColor = System.Drawing.Color.Blue;
            this.kayit_kullaniciadi.LineIdleColor = System.Drawing.Color.Gray;
            this.kayit_kullaniciadi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.kayit_kullaniciadi.LineThickness = 3;
            this.kayit_kullaniciadi.Location = new System.Drawing.Point(76, 76);
            this.kayit_kullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.kayit_kullaniciadi.Name = "kayit_kullaniciadi";
            this.kayit_kullaniciadi.Size = new System.Drawing.Size(335, 33);
            this.kayit_kullaniciadi.TabIndex = 24;
            this.kayit_kullaniciadi.TabStop = false;
            this.kayit_kullaniciadi.Text = "Kullanıcı Adı";
            this.kayit_kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kayit_kullaniciadi.Enter += new System.EventHandler(this.kayit_kullaniciadi_Enter);
            this.kayit_kullaniciadi.Leave += new System.EventHandler(this.kayit_kullaniciadi_Leave);
            // 
            // kayit_ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.kayitol_panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayit_ol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.kayit_ol_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kayit_ol_MouseMove);
            this.kayitol_panel.ResumeLayout(false);
            this.kayitol_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel kayitol_panel;
        public Bunifu.Framework.UI.BunifuThinButton2 Kayit_btn_girisyap;
        public System.Windows.Forms.Label kayit_bildirim;
        public Bunifu.Framework.UI.BunifuCheckbox sifre_kontrol1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.Framework.UI.BunifuThinButton2 kayit_btn_kayitol;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label kayit;
        public Bunifu.Framework.UI.BunifuMaterialTextbox kayit_sifre;
        public Bunifu.Framework.UI.BunifuMaterialTextbox kayit_kullaniciadi;
    }
}
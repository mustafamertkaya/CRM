namespace CRM
{
    partial class giris_yap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris_yap));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.girisyap_panel = new System.Windows.Forms.Panel();
            this.giris_bildirim = new System.Windows.Forms.Label();
            this.sifre_kontrol = new Bunifu.Framework.UI.BunifuCheckbox();
            this.text_kullaniciadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_kayitol = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_girisyap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.login = new System.Windows.Forms.Label();
            this.text_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.girisyap_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // girisyap_panel
            // 
            this.girisyap_panel.Controls.Add(this.giris_bildirim);
            this.girisyap_panel.Controls.Add(this.sifre_kontrol);
            this.girisyap_panel.Controls.Add(this.text_kullaniciadi);
            this.girisyap_panel.Controls.Add(this.pictureBox2);
            this.girisyap_panel.Controls.Add(this.pictureBox3);
            this.girisyap_panel.Controls.Add(this.btn_kayitol);
            this.girisyap_panel.Controls.Add(this.label1);
            this.girisyap_panel.Controls.Add(this.btn_girisyap);
            this.girisyap_panel.Controls.Add(this.login);
            this.girisyap_panel.Controls.Add(this.text_sifre);
            this.girisyap_panel.Location = new System.Drawing.Point(0, 0);
            this.girisyap_panel.Name = "girisyap_panel";
            this.girisyap_panel.Size = new System.Drawing.Size(450, 350);
            this.girisyap_panel.TabIndex = 0;
            this.girisyap_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.girisyap_panel_MouseMove);
            // 
            // giris_bildirim
            // 
            this.giris_bildirim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giris_bildirim.AutoSize = true;
            this.giris_bildirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_bildirim.ForeColor = System.Drawing.Color.OrangeRed;
            this.giris_bildirim.Location = new System.Drawing.Point(77, 318);
            this.giris_bildirim.Name = "giris_bildirim";
            this.giris_bildirim.Size = new System.Drawing.Size(57, 20);
            this.giris_bildirim.TabIndex = 53;
            this.giris_bildirim.Text = "bildirim";
            this.giris_bildirim.Visible = false;
            // 
            // sifre_kontrol
            // 
            this.sifre_kontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sifre_kontrol.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.sifre_kontrol.Checked = false;
            this.sifre_kontrol.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.sifre_kontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifre_kontrol.ForeColor = System.Drawing.Color.White;
            this.sifre_kontrol.Location = new System.Drawing.Point(418, 152);
            this.sifre_kontrol.Name = "sifre_kontrol";
            this.sifre_kontrol.Size = new System.Drawing.Size(20, 20);
            this.sifre_kontrol.TabIndex = 52;
            this.sifre_kontrol.TabStop = false;
            this.sifre_kontrol.OnChange += new System.EventHandler(this.sifre_kontrol_OnChange);
            // 
            // text_kullaniciadi
            // 
            this.text_kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.text_kullaniciadi.HintForeColor = System.Drawing.Color.White;
            this.text_kullaniciadi.HintText = "";
            this.text_kullaniciadi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.text_kullaniciadi.isPassword = false;
            this.text_kullaniciadi.LineFocusedColor = System.Drawing.Color.Blue;
            this.text_kullaniciadi.LineIdleColor = System.Drawing.Color.Gray;
            this.text_kullaniciadi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text_kullaniciadi.LineThickness = 3;
            this.text_kullaniciadi.Location = new System.Drawing.Point(76, 76);
            this.text_kullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.text_kullaniciadi.Name = "text_kullaniciadi";
            this.text_kullaniciadi.Size = new System.Drawing.Size(335, 33);
            this.text_kullaniciadi.TabIndex = 44;
            this.text_kullaniciadi.Text = "Kullanıcı Adı";
            this.text_kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_kullaniciadi.Enter += new System.EventHandler(this.text_kullaniciadi_Enter);
            this.text_kullaniciadi.Leave += new System.EventHandler(this.text_kullaniciadi_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
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
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.ActiveBorderThickness = 1;
            this.btn_kayitol.ActiveCornerRadius = 20;
            this.btn_kayitol.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_kayitol.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_kayitol.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_kayitol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_kayitol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kayitol.BackgroundImage")));
            this.btn_kayitol.ButtonText = "Kayıt Ol";
            this.btn_kayitol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayitol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kayitol.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_kayitol.IdleBorderThickness = 1;
            this.btn_kayitol.IdleCornerRadius = 20;
            this.btn_kayitol.IdleFillColor = System.Drawing.Color.White;
            this.btn_kayitol.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_kayitol.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_kayitol.Location = new System.Drawing.Point(110, 265);
            this.btn_kayitol.Margin = new System.Windows.Forms.Padding(5);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(194, 41);
            this.btn_kayitol.TabIndex = 47;
            this.btn_kayitol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 1);
            this.label1.TabIndex = 49;
            this.label1.Visible = false;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.ActiveBorderThickness = 1;
            this.btn_girisyap.ActiveCornerRadius = 20;
            this.btn_girisyap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_girisyap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_girisyap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btn_girisyap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_girisyap.BackgroundImage")));
            this.btn_girisyap.ButtonText = "Giriş Yap";
            this.btn_girisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_girisyap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_girisyap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_girisyap.IdleBorderThickness = 1;
            this.btn_girisyap.IdleCornerRadius = 20;
            this.btn_girisyap.IdleFillColor = System.Drawing.Color.White;
            this.btn_girisyap.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_girisyap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_girisyap.Location = new System.Drawing.Point(110, 214);
            this.btn_girisyap.Margin = new System.Windows.Forms.Padding(5);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(194, 41);
            this.btn_girisyap.TabIndex = 46;
            this.btn_girisyap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(160, 16);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 23);
            this.login.TabIndex = 48;
            this.login.Text = "Giriş Yap";
            this.login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            // 
            // text_sifre
            // 
            this.text_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_sifre.ForeColor = System.Drawing.Color.White;
            this.text_sifre.HintForeColor = System.Drawing.Color.Empty;
            this.text_sifre.HintText = "";
            this.text_sifre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.text_sifre.isPassword = false;
            this.text_sifre.LineFocusedColor = System.Drawing.Color.Blue;
            this.text_sifre.LineIdleColor = System.Drawing.Color.Gray;
            this.text_sifre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text_sifre.LineThickness = 3;
            this.text_sifre.Location = new System.Drawing.Point(76, 152);
            this.text_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.text_sifre.Name = "text_sifre";
            this.text_sifre.Size = new System.Drawing.Size(335, 33);
            this.text_sifre.TabIndex = 45;
            this.text_sifre.Text = "Parola";
            this.text_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_sifre.Enter += new System.EventHandler(this.text_sifre_Enter);
            this.text_sifre.Leave += new System.EventHandler(this.text_sifre_Leave);
            // 
            // giris_yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.girisyap_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris_yap";
            this.Text = "giris_yap";
            this.girisyap_panel.ResumeLayout(false);
            this.girisyap_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel girisyap_panel;
        public System.Windows.Forms.Label giris_bildirim;
        public Bunifu.Framework.UI.BunifuCheckbox sifre_kontrol;
        public Bunifu.Framework.UI.BunifuMaterialTextbox text_kullaniciadi;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_kayitol;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btn_girisyap;
        public System.Windows.Forms.Label login;
        public Bunifu.Framework.UI.BunifuMaterialTextbox text_sifre;
    }
}
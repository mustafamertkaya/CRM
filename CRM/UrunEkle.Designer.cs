namespace CRM
{
    partial class UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.urunEkle_Panel = new System.Windows.Forms.Panel();
            this.urnEkle_bildirim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urnFiyat_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_urnEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.urnstok_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.urnAd_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.scroll_Panel = new System.Windows.Forms.Panel();
            this.mstr_kapama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mstr_altalma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.urunEkle_Panel.SuspendLayout();
            this.scroll_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // urunEkle_Panel
            // 
            this.urunEkle_Panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.urunEkle_Panel.Controls.Add(this.urnEkle_bildirim);
            this.urunEkle_Panel.Controls.Add(this.label3);
            this.urunEkle_Panel.Controls.Add(this.urnFiyat_text);
            this.urunEkle_Panel.Controls.Add(this.btn_urnEkle);
            this.urunEkle_Panel.Controls.Add(this.label2);
            this.urunEkle_Panel.Controls.Add(this.label1);
            this.urunEkle_Panel.Controls.Add(this.urnstok_text);
            this.urunEkle_Panel.Controls.Add(this.urnAd_text);
            this.urunEkle_Panel.Location = new System.Drawing.Point(0, 37);
            this.urunEkle_Panel.Name = "urunEkle_Panel";
            this.urunEkle_Panel.Size = new System.Drawing.Size(520, 432);
            this.urunEkle_Panel.TabIndex = 0;
            // 
            // urnEkle_bildirim
            // 
            this.urnEkle_bildirim.AutoSize = true;
            this.urnEkle_bildirim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnEkle_bildirim.Location = new System.Drawing.Point(214, 385);
            this.urnEkle_bildirim.Name = "urnEkle_bildirim";
            this.urnEkle_bildirim.Size = new System.Drawing.Size(59, 20);
            this.urnEkle_bildirim.TabIndex = 36;
            this.urnEkle_bildirim.Text = "bildirim";
            this.urnEkle_bildirim.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fiyatı";
            // 
            // urnFiyat_text
            // 
            this.urnFiyat_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urnFiyat_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.urnFiyat_text.ForeColor = System.Drawing.Color.Black;
            this.urnFiyat_text.HintForeColor = System.Drawing.Color.Empty;
            this.urnFiyat_text.HintText = "";
            this.urnFiyat_text.isPassword = false;
            this.urnFiyat_text.LineFocusedColor = System.Drawing.Color.Blue;
            this.urnFiyat_text.LineIdleColor = System.Drawing.Color.Gray;
            this.urnFiyat_text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.urnFiyat_text.LineThickness = 3;
            this.urnFiyat_text.Location = new System.Drawing.Point(64, 264);
            this.urnFiyat_text.Margin = new System.Windows.Forms.Padding(4);
            this.urnFiyat_text.Name = "urnFiyat_text";
            this.urnFiyat_text.Size = new System.Drawing.Size(379, 33);
            this.urnFiyat_text.TabIndex = 3;
            this.urnFiyat_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urnFiyat_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnFiyat_text_KeyPress);
            // 
            // btn_urnEkle
            // 
            this.btn_urnEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_urnEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_urnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_urnEkle.BorderRadius = 7;
            this.btn_urnEkle.ButtonText = "Ürün Ekle";
            this.btn_urnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_urnEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_urnEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_urnEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_urnEkle.Iconimage")));
            this.btn_urnEkle.Iconimage_right = null;
            this.btn_urnEkle.Iconimage_right_Selected = null;
            this.btn_urnEkle.Iconimage_Selected = null;
            this.btn_urnEkle.IconMarginLeft = 0;
            this.btn_urnEkle.IconMarginRight = 0;
            this.btn_urnEkle.IconRightVisible = true;
            this.btn_urnEkle.IconRightZoom = 0D;
            this.btn_urnEkle.IconVisible = true;
            this.btn_urnEkle.IconZoom = 60D;
            this.btn_urnEkle.IsTab = false;
            this.btn_urnEkle.Location = new System.Drawing.Point(185, 319);
            this.btn_urnEkle.Name = "btn_urnEkle";
            this.btn_urnEkle.Normalcolor = System.Drawing.Color.SkyBlue;
            this.btn_urnEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_urnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_urnEkle.selected = false;
            this.btn_urnEkle.Size = new System.Drawing.Size(129, 48);
            this.btn_urnEkle.TabIndex = 33;
            this.btn_urnEkle.Text = "Ürün Ekle";
            this.btn_urnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_urnEkle.Textcolor = System.Drawing.Color.Black;
            this.btn_urnEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urnEkle.Click += new System.EventHandler(this.btn_urnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Stok Adedi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ürün Adı";
            // 
            // urnstok_text
            // 
            this.urnstok_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urnstok_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.urnstok_text.ForeColor = System.Drawing.Color.Black;
            this.urnstok_text.HintForeColor = System.Drawing.Color.Empty;
            this.urnstok_text.HintText = "";
            this.urnstok_text.isPassword = false;
            this.urnstok_text.LineFocusedColor = System.Drawing.Color.Blue;
            this.urnstok_text.LineIdleColor = System.Drawing.Color.Gray;
            this.urnstok_text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.urnstok_text.LineThickness = 3;
            this.urnstok_text.Location = new System.Drawing.Point(64, 173);
            this.urnstok_text.Margin = new System.Windows.Forms.Padding(4);
            this.urnstok_text.Name = "urnstok_text";
            this.urnstok_text.Size = new System.Drawing.Size(379, 33);
            this.urnstok_text.TabIndex = 2;
            this.urnstok_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urnstok_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnstok_text_KeyPress);
            // 
            // urnAd_text
            // 
            this.urnAd_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.urnAd_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.urnAd_text.ForeColor = System.Drawing.Color.Black;
            this.urnAd_text.HintForeColor = System.Drawing.Color.Empty;
            this.urnAd_text.HintText = "";
            this.urnAd_text.isPassword = false;
            this.urnAd_text.LineFocusedColor = System.Drawing.Color.Blue;
            this.urnAd_text.LineIdleColor = System.Drawing.Color.Gray;
            this.urnAd_text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.urnAd_text.LineThickness = 3;
            this.urnAd_text.Location = new System.Drawing.Point(64, 78);
            this.urnAd_text.Margin = new System.Windows.Forms.Padding(4);
            this.urnAd_text.Name = "urnAd_text";
            this.urnAd_text.Size = new System.Drawing.Size(379, 33);
            this.urnAd_text.TabIndex = 1;
            this.urnAd_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.urnAd_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urnAd_text_KeyPress);
            // 
            // scroll_Panel
            // 
            this.scroll_Panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.scroll_Panel.Controls.Add(this.mstr_kapama);
            this.scroll_Panel.Controls.Add(this.mstr_altalma);
            this.scroll_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.scroll_Panel.ForeColor = System.Drawing.Color.Transparent;
            this.scroll_Panel.Location = new System.Drawing.Point(0, 0);
            this.scroll_Panel.Name = "scroll_Panel";
            this.scroll_Panel.Size = new System.Drawing.Size(520, 36);
            this.scroll_Panel.TabIndex = 40;
            this.scroll_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scroll_Panel_MouseDown);
            this.scroll_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scroll_Panel_MouseMove);
            this.scroll_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scroll_Panel_MouseUp);
            // 
            // mstr_kapama
            // 
            this.mstr_kapama.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.mstr_kapama.BackColor = System.Drawing.Color.Transparent;
            this.mstr_kapama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mstr_kapama.BorderRadius = 0;
            this.mstr_kapama.ButtonText = "";
            this.mstr_kapama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mstr_kapama.DisabledColor = System.Drawing.Color.Gray;
            this.mstr_kapama.Iconcolor = System.Drawing.Color.Transparent;
            this.mstr_kapama.Iconimage = ((System.Drawing.Image)(resources.GetObject("mstr_kapama.Iconimage")));
            this.mstr_kapama.Iconimage_right = null;
            this.mstr_kapama.Iconimage_right_Selected = null;
            this.mstr_kapama.Iconimage_Selected = null;
            this.mstr_kapama.IconMarginLeft = 0;
            this.mstr_kapama.IconMarginRight = 0;
            this.mstr_kapama.IconRightVisible = true;
            this.mstr_kapama.IconRightZoom = 0D;
            this.mstr_kapama.IconVisible = true;
            this.mstr_kapama.IconZoom = 60D;
            this.mstr_kapama.IsTab = false;
            this.mstr_kapama.Location = new System.Drawing.Point(478, 1);
            this.mstr_kapama.Name = "mstr_kapama";
            this.mstr_kapama.Normalcolor = System.Drawing.Color.Transparent;
            this.mstr_kapama.OnHovercolor = System.Drawing.Color.LightGray;
            this.mstr_kapama.OnHoverTextColor = System.Drawing.Color.DarkOrchid;
            this.mstr_kapama.selected = false;
            this.mstr_kapama.Size = new System.Drawing.Size(35, 32);
            this.mstr_kapama.TabIndex = 37;
            this.mstr_kapama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mstr_kapama.Textcolor = System.Drawing.Color.White;
            this.mstr_kapama.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstr_kapama.Click += new System.EventHandler(this.mstr_kapama_Click);
            // 
            // mstr_altalma
            // 
            this.mstr_altalma.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.mstr_altalma.BackColor = System.Drawing.Color.Transparent;
            this.mstr_altalma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mstr_altalma.BorderRadius = 0;
            this.mstr_altalma.ButtonText = "";
            this.mstr_altalma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mstr_altalma.DisabledColor = System.Drawing.Color.Gray;
            this.mstr_altalma.Iconcolor = System.Drawing.Color.Transparent;
            this.mstr_altalma.Iconimage = ((System.Drawing.Image)(resources.GetObject("mstr_altalma.Iconimage")));
            this.mstr_altalma.Iconimage_right = null;
            this.mstr_altalma.Iconimage_right_Selected = null;
            this.mstr_altalma.Iconimage_Selected = null;
            this.mstr_altalma.IconMarginLeft = 0;
            this.mstr_altalma.IconMarginRight = 0;
            this.mstr_altalma.IconRightVisible = true;
            this.mstr_altalma.IconRightZoom = 0D;
            this.mstr_altalma.IconVisible = true;
            this.mstr_altalma.IconZoom = 60D;
            this.mstr_altalma.IsTab = false;
            this.mstr_altalma.Location = new System.Drawing.Point(437, 1);
            this.mstr_altalma.Name = "mstr_altalma";
            this.mstr_altalma.Normalcolor = System.Drawing.Color.Transparent;
            this.mstr_altalma.OnHovercolor = System.Drawing.Color.LightGray;
            this.mstr_altalma.OnHoverTextColor = System.Drawing.Color.DarkOrchid;
            this.mstr_altalma.selected = false;
            this.mstr_altalma.Size = new System.Drawing.Size(35, 32);
            this.mstr_altalma.TabIndex = 36;
            this.mstr_altalma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mstr_altalma.Textcolor = System.Drawing.Color.White;
            this.mstr_altalma.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstr_altalma.Click += new System.EventHandler(this.mstr_altalma_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 470);
            this.Controls.Add(this.scroll_Panel);
            this.Controls.Add(this.urunEkle_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunEkle";
            this.urunEkle_Panel.ResumeLayout(false);
            this.urunEkle_Panel.PerformLayout();
            this.scroll_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel urunEkle_Panel;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox urnFiyat_text;
        private Bunifu.Framework.UI.BunifuFlatButton btn_urnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox urnstok_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox urnAd_text;
        private System.Windows.Forms.Panel scroll_Panel;
        private Bunifu.Framework.UI.BunifuFlatButton mstr_kapama;
        private Bunifu.Framework.UI.BunifuFlatButton mstr_altalma;
        private System.Windows.Forms.Label urnEkle_bildirim;
    }
}
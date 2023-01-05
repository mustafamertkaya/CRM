namespace CRM
{
    partial class siparisEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(siparisEkleForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sprsEkle_panel = new System.Windows.Forms.Panel();
            this.stokadedilabel = new System.Windows.Forms.Label();
            this.sprsEkle_bildirim = new System.Windows.Forms.Label();
            this.btn_sprsEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.sprsMiktar_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sprsVeren_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.scroll_Panel = new System.Windows.Forms.Panel();
            this.mstr_kapama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mstr_altalma = new Bunifu.Framework.UI.BunifuFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sprsEkle_panel.SuspendLayout();
            this.scroll_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // sprsEkle_panel
            // 
            this.sprsEkle_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sprsEkle_panel.Controls.Add(this.comboBox1);
            this.sprsEkle_panel.Controls.Add(this.stokadedilabel);
            this.sprsEkle_panel.Controls.Add(this.sprsEkle_bildirim);
            this.sprsEkle_panel.Controls.Add(this.btn_sprsEkle);
            this.sprsEkle_panel.Controls.Add(this.bunifuCustomLabel3);
            this.sprsEkle_panel.Controls.Add(this.bunifuCustomLabel2);
            this.sprsEkle_panel.Controls.Add(this.bunifuCustomLabel1);
            this.sprsEkle_panel.Controls.Add(this.sprsMiktar_text);
            this.sprsEkle_panel.Controls.Add(this.sprsVeren_text);
            this.sprsEkle_panel.Location = new System.Drawing.Point(0, 37);
            this.sprsEkle_panel.Name = "sprsEkle_panel";
            this.sprsEkle_panel.Size = new System.Drawing.Size(520, 424);
            this.sprsEkle_panel.TabIndex = 0;
            // 
            // stokadedilabel
            // 
            this.stokadedilabel.AutoSize = true;
            this.stokadedilabel.ForeColor = System.Drawing.SystemColors.Control;
            this.stokadedilabel.Location = new System.Drawing.Point(472, 374);
            this.stokadedilabel.Name = "stokadedilabel";
            this.stokadedilabel.Size = new System.Drawing.Size(0, 13);
            this.stokadedilabel.TabIndex = 59;
            this.stokadedilabel.Visible = false;
            // 
            // sprsEkle_bildirim
            // 
            this.sprsEkle_bildirim.AutoSize = true;
            this.sprsEkle_bildirim.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sprsEkle_bildirim.Location = new System.Drawing.Point(224, 369);
            this.sprsEkle_bildirim.Name = "sprsEkle_bildirim";
            this.sprsEkle_bildirim.Size = new System.Drawing.Size(59, 20);
            this.sprsEkle_bildirim.TabIndex = 58;
            this.sprsEkle_bildirim.Text = "bildirim";
            this.sprsEkle_bildirim.Visible = false;
            // 
            // btn_sprsEkle
            // 
            this.btn_sprsEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sprsEkle.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_sprsEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sprsEkle.BorderRadius = 7;
            this.btn_sprsEkle.ButtonText = "Sipariş Ekle";
            this.btn_sprsEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sprsEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sprsEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sprsEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sprsEkle.Iconimage")));
            this.btn_sprsEkle.Iconimage_right = null;
            this.btn_sprsEkle.Iconimage_right_Selected = null;
            this.btn_sprsEkle.Iconimage_Selected = null;
            this.btn_sprsEkle.IconMarginLeft = 0;
            this.btn_sprsEkle.IconMarginRight = 0;
            this.btn_sprsEkle.IconRightVisible = true;
            this.btn_sprsEkle.IconRightZoom = 0D;
            this.btn_sprsEkle.IconVisible = true;
            this.btn_sprsEkle.IconZoom = 70D;
            this.btn_sprsEkle.IsTab = false;
            this.btn_sprsEkle.Location = new System.Drawing.Point(190, 305);
            this.btn_sprsEkle.Name = "btn_sprsEkle";
            this.btn_sprsEkle.Normalcolor = System.Drawing.Color.SkyBlue;
            this.btn_sprsEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_sprsEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sprsEkle.selected = false;
            this.btn_sprsEkle.Size = new System.Drawing.Size(129, 48);
            this.btn_sprsEkle.TabIndex = 54;
            this.btn_sprsEkle.Text = "Sipariş Ekle";
            this.btn_sprsEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sprsEkle.Textcolor = System.Drawing.Color.Black;
            this.btn_sprsEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sprsEkle.Click += new System.EventHandler(this.btn_sprsEkle_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(79, 228);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(113, 21);
            this.bunifuCustomLabel3.TabIndex = 53;
            this.bunifuCustomLabel3.Text = "Sipariş Miktarı";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(79, 135);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(46, 21);
            this.bunifuCustomLabel2.TabIndex = 52;
            this.bunifuCustomLabel2.Text = "Ürün";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(79, 40);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(107, 21);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "Siparis Veren";
            // 
            // sprsMiktar_text
            // 
            this.sprsMiktar_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sprsMiktar_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sprsMiktar_text.ForeColor = System.Drawing.Color.Black;
            this.sprsMiktar_text.HintForeColor = System.Drawing.Color.Empty;
            this.sprsMiktar_text.HintText = "";
            this.sprsMiktar_text.isPassword = false;
            this.sprsMiktar_text.LineFocusedColor = System.Drawing.Color.Blue;
            this.sprsMiktar_text.LineIdleColor = System.Drawing.Color.Gray;
            this.sprsMiktar_text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sprsMiktar_text.LineThickness = 3;
            this.sprsMiktar_text.Location = new System.Drawing.Point(73, 253);
            this.sprsMiktar_text.Margin = new System.Windows.Forms.Padding(4);
            this.sprsMiktar_text.Name = "sprsMiktar_text";
            this.sprsMiktar_text.Size = new System.Drawing.Size(379, 33);
            this.sprsMiktar_text.TabIndex = 3;
            this.sprsMiktar_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sprsMiktar_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sprsMiktar_text_KeyPress);
            // 
            // sprsVeren_text
            // 
            this.sprsVeren_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sprsVeren_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sprsVeren_text.ForeColor = System.Drawing.Color.Black;
            this.sprsVeren_text.HintForeColor = System.Drawing.Color.Empty;
            this.sprsVeren_text.HintText = "";
            this.sprsVeren_text.isPassword = false;
            this.sprsVeren_text.LineFocusedColor = System.Drawing.Color.Blue;
            this.sprsVeren_text.LineIdleColor = System.Drawing.Color.Gray;
            this.sprsVeren_text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sprsVeren_text.LineThickness = 3;
            this.sprsVeren_text.Location = new System.Drawing.Point(73, 65);
            this.sprsVeren_text.Margin = new System.Windows.Forms.Padding(4);
            this.sprsVeren_text.Name = "sprsVeren_text";
            this.sprsVeren_text.Size = new System.Drawing.Size(379, 33);
            this.sprsVeren_text.TabIndex = 1;
            this.sprsVeren_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sprsVeren_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sprsVeren_text_KeyPress);
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
            this.scroll_Panel.TabIndex = 42;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(379, 21);
            this.comboBox1.TabIndex = 60;
            // 
            // siparisEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 460);
            this.Controls.Add(this.scroll_Panel);
            this.Controls.Add(this.sprsEkle_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siparisEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "siparisEkle";
            this.Load += new System.EventHandler(this.siparisEkleForm_Load);
            this.sprsEkle_panel.ResumeLayout(false);
            this.sprsEkle_panel.PerformLayout();
            this.scroll_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel sprsEkle_panel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sprsMiktar_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sprsVeren_text;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sprsEkle;
        private System.Windows.Forms.Panel scroll_Panel;
        private Bunifu.Framework.UI.BunifuFlatButton mstr_kapama;
        private Bunifu.Framework.UI.BunifuFlatButton mstr_altalma;
        private System.Windows.Forms.Label sprsEkle_bildirim;
        private System.Windows.Forms.Label stokadedilabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
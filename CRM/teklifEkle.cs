using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class teklifEkle : Form
    {
        public teklifEkle()
        {
            InitializeComponent();
        }


        #region Ayar
        private void mstr_kapama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mstr_altalma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void scroll_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void scroll_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void scroll_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void teklifdgr_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void teklifvrn_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion



        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

        private void btn_tklfEkle_Click(object sender, EventArgs e)
        {
            if (teklifvrn_text.Text == "" || teklifsrkt_text.Text == "" || teklifdgr_text.Text == "")
            {
                tekliEkle_bildirim.Location = new Point(213, 367);
                tekliEkle_bildirim.ForeColor = Color.Red;
                tekliEkle_bildirim.Location = new Point(tekliEkle_bildirim.Location.X - 85, 367);
                tekliEkle_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                tekliEkle_bildirim.Visible = true;
            }
            else
            {
                loginbaglanti.Open();
                string tklf_veren = teklifvrn_text.Text;
                string tklf_sirket = teklifsrkt_text.Text;
                string tklf_deger = teklifdgr_text.Text;

                SqlCommand komut = new SqlCommand("select * from teklifEkle where teklifVeren='" + tklf_veren + "' and teklifVerilenSirket='" + tklf_sirket + "' and teklifDeger='" + tklf_deger + "'", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    tekliEkle_bildirim.ForeColor = Color.Red;
                    tekliEkle_bildirim.Location = new Point(213, 367);
                    tekliEkle_bildirim.Location = new Point(tekliEkle_bildirim.Location.X - 38, 367);
                    tekliEkle_bildirim.Text = "Böyle Bir Teklif Mevcut.";
                    tekliEkle_bildirim.Visible = true;
                }
                else
                {

                    oku.Close();
                    DateTime bugun = DateTime.Now;
                    string Tarih = bugun.ToString();
                    SqlCommand ekle = new SqlCommand("insert into teklifEkle(teklifVeren,teklifVerilenSirket,teklifDeger,tarih) values('" + tklf_veren + "' , '" + tklf_sirket + "' ,'" + tklf_deger + "', '" + bugun + "')", loginbaglanti);
                    ekle.ExecuteNonQuery();
                    tekliEkle_bildirim.ForeColor = Color.Black;
                    tekliEkle_bildirim.Location = new Point(213, 367);
                    tekliEkle_bildirim.Location = new Point(tekliEkle_bildirim.Location.X - 95, 367);
                    tekliEkle_bildirim.Text = "Başarılı Bir Şekilde Teklif eklendi.";
                    tekliEkle_bildirim.Visible = true;


                    DateTime gun = DateTime.Now;
                    string aciklama = tklf_veren + " tarafından " + tklf_sirket + " sirketine teklif verildi.";
                    SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                    ekle_ack.ExecuteNonQuery();
                    ekle_ack.Clone();
                }

                loginbaglanti.Close();
            }
        }

        
    }
}

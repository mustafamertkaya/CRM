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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
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

        private void urnstok_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urnAd_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void urnFiyat_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion



        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

        private void btn_urnEkle_Click(object sender, EventArgs e)
        {
            if (urnAd_text.Text == "" || urnstok_text.Text == "" || urnFiyat_text.Text == "")
            {
                urnEkle_bildirim.Location = new Point(214, 385);
                urnEkle_bildirim.ForeColor = Color.Red;
                urnEkle_bildirim.Location = new Point(urnEkle_bildirim.Location.X - 85, 385);
                urnEkle_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                urnEkle_bildirim.Visible = true;
            }
            else
            {
                loginbaglanti.Open();
                string urn_ad = urnAd_text.Text;
                string urn_stok = urnstok_text.Text;
                string urn_fiyat = urnFiyat_text.Text;

                SqlCommand komut = new SqlCommand("select * from urunEkle where urunAdı='" + urn_ad + "' ", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    urnEkle_bildirim.ForeColor = Color.Red;
                    urnEkle_bildirim.Location = new Point(214, 385);
                    urnEkle_bildirim.Location = new Point(urnEkle_bildirim.Location.X - 38, 385);
                    urnEkle_bildirim.Text = "Bu Ürün Kayıtlı.";
                    urnEkle_bildirim.Visible = true;
                }
                else
                {

                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into urunEkle(urunAdı,stokAdedi,Fiyat) values('" + urn_ad + "' , '" + urn_stok + "' ,'" + urn_fiyat + "')", loginbaglanti);
                    ekle.ExecuteNonQuery();
                    urnEkle_bildirim.ForeColor = Color.Black;
                    urnEkle_bildirim.Location = new Point(214, 385);
                    urnEkle_bildirim.Location = new Point(urnEkle_bildirim.Location.X - 95, 385);
                    urnEkle_bildirim.Text = "Başarılı Bir Şekilde Ürün eklendi.";
                    urnEkle_bildirim.Visible = true;


                    DateTime gun = DateTime.Now;
                    string aciklama = urn_ad + " ürününden " + urn_stok + " adet stoklara eklendi.";
                    SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                    ekle_ack.ExecuteNonQuery();
                    ekle_ack.Clone();
                }

                loginbaglanti.Close();
            }
        }

        
    }
}

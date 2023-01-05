using Microsoft.VisualBasic.Devices;
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
    public partial class musteriEkle : Form
    {
        public musteriEkle()
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

        private void mstrAd_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void mstrsirket_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion



        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");


        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            if (mstrAd_text.Text == "" || mstrsirket_text.Text == "" || mstrPozisyon_text.Text == "")
            {
                mstrEkle_bildirim.Location = new Point(221, 370);
                mstrEkle_bildirim.ForeColor = Color.Red;
                mstrEkle_bildirim.Location = new Point(mstrEkle_bildirim.Location.X - 85, 370);
                mstrEkle_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                mstrEkle_bildirim.Visible = true;
            }
            else
            {
                loginbaglanti.Open();
                string mstr_user = mstrAd_text.Text;
                string mstr_sirket = mstrsirket_text.Text;
                string mstr_pozisyon = mstrPozisyon_text.Text;

                SqlCommand komut = new SqlCommand("select * from musteriEkle where isim='" + mstr_user + "' and sirket='" + mstr_sirket + "' and pozisyon='" + mstr_pozisyon + "'", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    mstrEkle_bildirim.ForeColor = Color.Red;
                    mstrEkle_bildirim.Location = new Point(221, 370);
                    mstrEkle_bildirim.Location = new Point(mstrEkle_bildirim.Location.X - 38, 370);
                    mstrEkle_bildirim.Text = "Bu müşteri Kayıtlı.";
                    mstrEkle_bildirim.Visible = true;
                }
                else
                {
                   
                    oku.Close();
                    DateTime bugun = DateTime.Now;
                    SqlCommand ekle = new SqlCommand("insert into musteriEkle(isim,sirket,pozisyon,tarih) values('" + mstr_user + "' , '" + mstr_sirket + "' ,'" + mstr_pozisyon + "', '" + bugun + "')", loginbaglanti);
                    ekle.ExecuteNonQuery();
                    mstrEkle_bildirim.ForeColor = Color.Black;
                    mstrEkle_bildirim.Location = new Point(221, 370);
                    mstrEkle_bildirim.Location = new Point(mstrEkle_bildirim.Location.X - 95, 370);
                    mstrEkle_bildirim.Text = "Başarılı Bir Şekilde Müşteri eklendi.";
                    mstrEkle_bildirim.Visible = true;


                    DateTime gun = DateTime.Now;
                    string aciklama = mstr_sirket + " şirketinden " + mstr_user + " isimli müşteri Eklendi."; 
                    SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" +   gun  + "')", loginbaglanti);
                    ekle_ack.ExecuteNonQuery();
                    ekle_ack.Clone();
                }

                loginbaglanti.Close();
            }
        }

        
    }
}

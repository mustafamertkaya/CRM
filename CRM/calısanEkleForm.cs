using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class calısanEkleForm : Form
    {
        public calısanEkleForm()
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

        private void calısanSprs_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion



        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");
        calısantableDataContext dc = new calısantableDataContext();
        List<calısanlarControl> tils = new List<calısanlarControl>();

        private void btn_calısanEkle_Click(object sender, EventArgs e)
        {
            if (calısanAdı_text.Text == "" || calısanUnvan_text.Text == "")
            {
                clsnEkle_bildirim.Location = new Point(210, 300);
                clsnEkle_bildirim.ForeColor = Color.Red;
                clsnEkle_bildirim.Location = new Point(clsnEkle_bildirim.Location.X - 85, 300);
                clsnEkle_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                clsnEkle_bildirim.Visible = true;
            }
            else
            {
                loginbaglanti.Open();
                string calisanAdi = calısanAdı_text.Text;
                string unvan = calısanUnvan_text.Text;


                SqlCommand komut = new SqlCommand("select * from calısanEkle where calisanAdi='" + calisanAdi + "' and unvan='" + unvan + "'", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    clsnEkle_bildirim.ForeColor = Color.Red;
                    clsnEkle_bildirim.Location = new Point(210, 300);
                    clsnEkle_bildirim.Location = new Point(clsnEkle_bildirim.Location.X - 38, 300);
                    clsnEkle_bildirim.Text = "Bu Çalışan Kayıtlı.";
                    clsnEkle_bildirim.Visible = true;
                }
                else
                {

                    oku.Close();
                    DateTime bugun = DateTime.Now;
                    string Tarih = bugun.ToString();
                    SqlCommand ekle = new SqlCommand("insert into calısanEkle(calisanAdi,unvan,tarih) values('" + calisanAdi + "' , '" + unvan + "' , '" + bugun + "')", loginbaglanti);
                    ekle.ExecuteNonQuery();
                    clsnEkle_bildirim.ForeColor = Color.Black;
                    clsnEkle_bildirim.Location = new Point(210, 300);
                    clsnEkle_bildirim.Location = new Point(clsnEkle_bildirim.Location.X - 95, 300);
                    clsnEkle_bildirim.Text = "Başarılı Bir Şekilde Çalışan eklendi.";
                    clsnEkle_bildirim.Visible = true;
                    calısanlar calisanlar= new calısanlar();
                    

                    DateTime gun = DateTime.Now;
                    string aciklama = unvan + " ünvanlı  " + calisanAdi + " isimli Çalışan aramıza katıldı.";
                    SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                    ekle_ack.ExecuteNonQuery();
                    ekle_ack.Clone();
                  
                }

                loginbaglanti.Close();
            }
        }


        
    }
}

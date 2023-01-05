using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Devices;

namespace CRM
{
    public partial class kayit_ol : Form
    {
        public kayit_ol()
        {
            InitializeComponent();
        }
        private void kayit_ol_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
            sifre_kontrol1.Checked = false;


        }
        

        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

       

        private void kayit_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible= true;
        }

        private void kayit_ol_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible= false;
        }

        private void kayitol_panel_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }



        #region TXT
        private void kayit_kullaniciadi_Enter(object sender, EventArgs e)
        {
            if (kayit_kullaniciadi.Text == "Kullanıcı Adı")
            {
                kayit_kullaniciadi.Text = "";
            }
        }

        private void kayit_kullaniciadi_Leave(object sender, EventArgs e)
        {
            if (kayit_kullaniciadi.Text == "")
            {
                kayit_kullaniciadi.Text = "Kullanıcı Adı";
            }
        }

        private void kayit_sifre_Enter(object sender, EventArgs e)
        {
            if (kayit_sifre.Text == "Parola")
            {
                kayit_sifre.Text = "";
                kayit_sifre.isPassword = true;

            }
        }

        private void kayit_sifre_Leave(object sender, EventArgs e)
        {
            if (kayit_sifre.Text == "")
            {
                kayit_sifre.Text = "Parola";
                kayit_sifre.isPassword = false;
            }
        }
        #endregion

               

        private void sifre_kontrol1_OnChange(object sender, EventArgs e)
        {
            if (sifre_kontrol1.Checked)
            {
                //karakteri göster.
                kayit_sifre.isPassword = false;
            }
            else
            {

                kayit_sifre.isPassword = true;
            }
        }

        private void kayit_btn_kayitol_Click(object sender, EventArgs e)
        {

            if (kayit_kullaniciadi.Text == "Kullanıcı Adı" || kayit_sifre.Text == "Parola" || kayit_kullaniciadi.Text == "" || kayit_sifre.Text == "")
            {
                kayit_bildirim.Location = new Point(8, 318);
                kayit_bildirim.ForeColor = Color.Red;
                kayit_bildirim.Location = new Point(kayit_bildirim.Location.X + 83, 318);
                kayit_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                kayit_bildirim.Visible = true;
            }
            else
            {
                loginbaglanti.Open();
                string user = kayit_kullaniciadi.Text;
                string password = kayit_sifre.Text;

                SqlCommand komut = new SqlCommand("select * from login1 where username='" + user + "'", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    kayit_bildirim.ForeColor = Color.Red;
                    kayit_bildirim.Location = new Point(8, 318);
                    kayit_bildirim.Location = new Point(kayit_bildirim.Location.X +5, 318);
                    kayit_bildirim.Text = "Bu Kullanıcı adı kullanılıyor Lütfen başka kullanıcı adı giriniz.";
                    kayit_bildirim.Visible = true;
                }
                else if (kayit_sifre.Text.Length < 6)
                {
                    kayit_bildirim.ForeColor = Color.Red;
                    kayit_bildirim.Location = new Point(8, 318);
                    kayit_bildirim.Location = new Point(kayit_bildirim.Location.X + 46, 318);
                    kayit_bildirim.Text = "Lütfen minumum 6 karakterli şifre kullanınız.";
                    kayit_bildirim.Visible = true;
                }
                else
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into login1(username,password) values('" + user + "' , '" + password + "')", loginbaglanti);
                    ekle.ExecuteNonQuery();
                    kayit_bildirim.ForeColor = Color.White;
                    kayit_bildirim.Location = new Point(8, 318);
                    kayit_bildirim.Location = new Point(kayit_bildirim.Location.X + 78, 318);
                    kayit_bildirim.Text = "Başarılı Bir Şekilde Kayıt oldunuz.";
                    kayit_bildirim.Visible = true;

                }

                loginbaglanti.Close();
            }
        }

        private void Kayit_btn_girisyap_Click(object sender, EventArgs e)
        {
            kayitol_panel.Controls.Clear();
            giris_yap giris_Yap = new giris_yap();
            giris_Yap.TopLevel = false;
            kayitol_panel.Controls.Add(giris_Yap);
            giris_Yap.Show();

        }

       
    }
}

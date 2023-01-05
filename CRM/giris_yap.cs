using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class giris_yap : Form
    {
        public giris_yap()
        {
            InitializeComponent();
        }


        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

       
        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = true;
        }

        private void girisyap_panel_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
        }



        #region TXT
        private void text_kullaniciadi_Enter(object sender, EventArgs e)
        {
            if (text_kullaniciadi.Text == "Kullanıcı Adı")
            {
                text_kullaniciadi.Text = "";
            }
        }

        private void text_kullaniciadi_Leave(object sender, EventArgs e)
        {
            if (text_kullaniciadi.Text == "")
            {
                text_kullaniciadi.Text = "Kullanıcı Adı";
            }
        }

        private void text_sifre_Enter(object sender, EventArgs e)
        {
            if (text_sifre.Text == "Parola")
            {
                text_sifre.Text = "";
                text_sifre.isPassword = true;
            }
        }

        private void text_sifre_Leave(object sender, EventArgs e)
        {
            if (text_sifre.Text == "")
            {
                text_sifre.Text = "Parola";
                text_sifre.isPassword = false;
            }
        }
        #endregion


      
        
        private void btn_kayitol_Click(object sender, EventArgs e)
        {
           
            girisyap_panel.Controls.Clear();
            kayit_ol kayitol = new kayit_ol();
            kayitol.TopLevel = false;
            girisyap_panel.Controls.Add(kayitol);
            kayitol.Show();

        }
      
        public void btn_girisyap_Click(object sender, EventArgs e)
        {

            if (text_kullaniciadi.Text == "Kullanıcı Adı" || text_sifre.Text == "Parola" || text_kullaniciadi.Text == "" || text_sifre.Text == "")
            {
                giris_bildirim.Location = new Point(77, 318);
                giris_bildirim.Location = new Point(giris_bildirim.Location.X + 17, 318);
                giris_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                giris_bildirim.Visible = true;


            }
            else
            {
                loginbaglanti.Open();
                string user = text_kullaniciadi.Text;
                string password = text_sifre.Text;

                HesapGirisi form1 = new HesapGirisi();
                CRM c = new CRM();
                SqlCommand komut = new SqlCommand("select * from login1 where username='" + user + "' and password='" + password + "'", loginbaglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    form1.Close();
                    c.ShowDialog();                   
                    
                }
                else
                {
                    giris_bildirim.Location = new Point(77, 318);
                    giris_bildirim.Text = "Hatalı Kullanıcı adı veya şifre girdiniz";
                    giris_bildirim.Visible = true;


                }

                loginbaglanti.Close();
            }

        }
       
        private void sifre_kontrol_OnChange(object sender, EventArgs e)
        {
            if (sifre_kontrol.Checked)
            {
                //karakteri göster.
                text_sifre.isPassword = false;
            }
            else
            {

                text_sifre.isPassword = true;
            }
        }
    }
}

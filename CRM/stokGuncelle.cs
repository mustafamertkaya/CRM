using Amazon.DynamoDBv2.Model;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using NHibernate.Mapping;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRM
{
    public partial class stokGuncelle : Form
    {
        public stokGuncelle()
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

        private void stokAdt_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void stkurunAd_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion




        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");
        private void stokGuncelle_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM urunEkle";
            komut.Connection = loginbaglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            loginbaglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["urunAdı"]);
            }
            loginbaglanti.Close();
        }


        private void btn_mevcutStok_Click(object sender, EventArgs e)
        {
            
           
            
            
            
            if (comboBox1.SelectedIndex != -1)
            {
                string urunadi = comboBox1.SelectedItem.ToString();
                loginbaglanti.Open();
               
                    SqlCommand verioku = new SqlCommand("select * from urunEkle where urunAdı = '" + urunadi + "'", loginbaglanti);
                    verioku.ExecuteNonQuery();
                    SqlDataReader veriyioku = verioku.ExecuteReader();

                    string stokadedi;
                    while (veriyioku.Read())
                    {
                        stokadedilabel.Text = veriyioku["stokAdedi"].ToString();

                    }
                    veriyioku.Close();

                    stokadedi = stokadedilabel.Text;

                    int stk_deger = Convert.ToInt32(stokadedi);


                    stokDegeri.Text = stk_deger.ToString();
                    stokDegeri.Visible = true;   
                
                loginbaglanti.Close();
            }
        }




        private void btn_stkarttır_Click(object sender, EventArgs e)
        {
            
            #region Nevcut Stok
            
            string stkAdet = stokAdt_text.Text;
            

            if (comboBox1.SelectedIndex != -1)
            {
                string urunadi = comboBox1.SelectedItem.ToString();
                int stk_adet = Convert.ToInt32(stokAdt_text.Text);
                loginbaglanti.Open();
                SqlCommand verioku = new SqlCommand("select * from urunEkle where urunAdı = '" + urunadi + "'", loginbaglanti);
                verioku.ExecuteNonQuery();
                SqlDataReader veriyioku;
                veriyioku = verioku.ExecuteReader();

                string stokadedi;
                while (veriyioku.Read())
                {
                    stokadedilabel.Text = veriyioku["stokAdedi"].ToString();

                }
                veriyioku.Close();
                int stk_degeri;
                stokadedi = stokadedilabel.Text;

                stk_degeri = Convert.ToInt32(stokadedi);
                stk_degeri += stk_adet;
                #endregion

                string sql = "update urunEkle set stokAdedi = '" + stk_degeri + "' where urunAdı = '" + urunadi + "' ";
                SqlCommand cmd = new SqlCommand(sql, loginbaglanti);
                cmd.ExecuteNonQuery(); 
               


                stkguncelle_bildirim.ForeColor = Color.Black;
                stkguncelle_bildirim.Location = new Point(223, 364);
                stkguncelle_bildirim.Location = new Point(stkguncelle_bildirim.Location.X - 63, 364);
                stkguncelle_bildirim.Text = "Stok Başarılı Bir Şekilde Arttırıldı.";
                stkguncelle_bildirim.Visible = true;

                DateTime gun = DateTime.Now;
                string aciklama = urunadi + " ürününe " + stk_adet + " adet stok takviyesi yapıldı.";
                SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                ekle_ack.ExecuteNonQuery();
              
                loginbaglanti.Close();
            }
            else
            {
                stkguncelle_bildirim.ForeColor = Color.Red;
                stkguncelle_bildirim.Location = new Point(223, 364);
                stkguncelle_bildirim.Location = new Point(stkguncelle_bildirim.Location.X - 60, 364);
                stkguncelle_bildirim.Text = "Lütfen Tüm Alanları Doldurunuz.";
                stkguncelle_bildirim.Visible = true;
            }

        }



        private void btn_stkazalt_Click(object sender, EventArgs e)
        {

            #region Nevcut Stok

            string stkAdet = stokAdt_text.Text;


            if (comboBox1.SelectedIndex != -1)
            {
                string urunadi = comboBox1.SelectedItem.ToString();
                int stk_adet = Convert.ToInt32(stokAdt_text.Text);
                loginbaglanti.Open();
                SqlCommand verioku = new SqlCommand("select * from urunEkle where urunAdı = '" + urunadi + "'", loginbaglanti);
                verioku.ExecuteNonQuery();
                SqlDataReader veriyioku;
                veriyioku = verioku.ExecuteReader();

                string stokadedi;
                while (veriyioku.Read())
                {
                    stokadedilabel.Text = veriyioku["stokAdedi"].ToString();

                }
                veriyioku.Close();
                int stk_degeri;
                stokadedi = stokadedilabel.Text;

                stk_degeri = Convert.ToInt32(stokadedi);
                stk_degeri -= stk_adet;
                #endregion

                string sql = "update urunEkle set stokAdedi = '" + stk_degeri + "' where urunAdı = '" + urunadi + "' ";
                SqlCommand cmd = new SqlCommand(sql, loginbaglanti);
                cmd.ExecuteNonQuery();



                stkguncelle_bildirim.ForeColor = Color.Black;
                stkguncelle_bildirim.Location = new Point(223, 364);
                stkguncelle_bildirim.Location = new Point(stkguncelle_bildirim.Location.X - 63, 364);
                stkguncelle_bildirim.Text = "Stok Başarılı Bir Şekilde Azaltıldı.";
                stkguncelle_bildirim.Visible = true;

                DateTime gun = DateTime.Now;
                string aciklama = urunadi + " ürünü " + stk_adet + " adet stok eksiltildi.";
                SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                ekle_ack.ExecuteNonQuery();

                loginbaglanti.Close();
            }
            else
            {
                stkguncelle_bildirim.ForeColor = Color.Red;
                stkguncelle_bildirim.Location = new Point(223, 364);
                stkguncelle_bildirim.Location = new Point(stkguncelle_bildirim.Location.X - 60, 364);
                stkguncelle_bildirim.Text = "Lütfen Tüm Alanları Doldurunuz.";
                stkguncelle_bildirim.Visible = true;
            }
        }

        
    }
}

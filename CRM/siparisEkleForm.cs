using Microsoft.VisualBasic;
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
    public partial class siparisEkleForm : Form
    {
        public siparisEkleForm()
        {
            InitializeComponent();
        }

        private void siparisEkleForm_Load(object sender, EventArgs e)
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

        private void sprsMiktar_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void sprsVeren_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
        #endregion



        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

        private void btn_sprsEkle_Click(object sender, EventArgs e)
        {
            if (sprsVeren_text.Text == "" || comboBox1.SelectedIndex == -1 || sprsMiktar_text.Text == "")
            {
                sprsEkle_bildirim.Location = new Point(224, 369);
                sprsEkle_bildirim.ForeColor = Color.Red;
                sprsEkle_bildirim.Location = new Point(sprsEkle_bildirim.Location.X - 85, 369);
                sprsEkle_bildirim.Text = "Lütfen Tüm Alanları doldurunuz.";
                sprsEkle_bildirim.Visible = true;
            }
            else
            {
                    loginbaglanti.Open();
                    string sprs_veren = sprsVeren_text.Text;
                    string sprs_urun = comboBox1.SelectedItem.ToString();
                    string sprs_miktar = sprsMiktar_text.Text;

                
                    SqlCommand verioku = new SqlCommand("select * from urunEkle where urunAdı = '" + sprs_urun + "'", loginbaglanti);
                    verioku.ExecuteNonQuery();
                    SqlDataReader veriyioku;
                    veriyioku = verioku.ExecuteReader();

                    string stokadedi;
                    while (veriyioku.Read())
                    {
                        stokadedilabel.Text = veriyioku["stokAdedi"].ToString();

                    }
                    veriyioku.Close();

                    stokadedi = stokadedilabel.Text;
                    int stk_deger =Convert.ToInt32(stokadedi);
                    int sprs_deger =Convert.ToInt32(sprs_miktar);

                    if (stk_deger > sprs_deger )
                    {
                        DateTime bugun = DateTime.Now;
                        string Tarih = bugun.ToString();
                        SqlCommand ekle = new SqlCommand("insert into siparisEkle(siparisVeren,siparisUrun,siparisMiktari,tarih) values('" + sprs_veren + "' , '" + sprs_urun + "' ,'" + sprs_miktar + "', '" + bugun + "')", loginbaglanti);
                        ekle.ExecuteNonQuery();
                        sprsEkle_bildirim.ForeColor = Color.Black;
                        sprsEkle_bildirim.Location = new Point(224, 369);
                        sprsEkle_bildirim.Location = new Point(sprsEkle_bildirim.Location.X - 95, 369);
                        sprsEkle_bildirim.Text = "Başarılı Bir Şekilde Sipariş Verildi.";
                        sprsEkle_bildirim.Visible = true;


                        DateTime gun = DateTime.Now;
                        string aciklama = sprs_veren + " tarafından " + sprs_urun + " ürününden "+ sprs_miktar + " adet sipariş verildi.";
                        SqlCommand ekle_ack = new SqlCommand("insert into pano(aciklama,tarih) values( '" + aciklama + "' , '" + gun + "')", loginbaglanti);
                        ekle_ack.ExecuteNonQuery();
                        ekle_ack.Clone();


                        stk_deger = stk_deger - sprs_deger;
                        string sql = "update urunEkle set stokAdedi = '" + stk_deger + "' where urunAdı = '" + sprs_urun + "' ";
                        SqlCommand cmd = new SqlCommand(sql, loginbaglanti);
                        cmd.ExecuteNonQuery(); 
                        loginbaglanti.Close();
                    }
                    else
                    {
                        sprsEkle_bildirim.ForeColor = Color.Black;
                        sprsEkle_bildirim.Location = new Point(224, 369);
                        sprsEkle_bildirim.Location = new Point(sprsEkle_bildirim.Location.X - 95, 369);
                        sprsEkle_bildirim.Text = "Stokta Bu kadar Ürün Bulunmamaktadır.";
                        sprsEkle_bildirim.Visible = true;
                    }
                    
                    loginbaglanti.Close();
            }  
        }

        
    }
}

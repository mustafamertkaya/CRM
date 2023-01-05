using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using NHibernate.Id;
using Amazon.DynamoDBv2;
using Bunifu.Framework.Lib;

namespace CRM
{
    public partial class HesapGirisi : Form
    {
        public HesapGirisi()
        {
            InitializeComponent();
        }

        bool move;
        int mouse_x;
        int mouse_y;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;            
            panel1.Controls.Clear();
            giris_yap giris_Yap = new giris_yap();
            giris_Yap.TopLevel = false;
            panel1.Controls.Add(giris_Yap);
            giris_Yap.Show();

            kayit_ol kayitol= new kayit_ol();
            tabloOlustur();
            
        
        }

        

        public void tabloOlustur()
        {
            string VeritataniAdi = "CRM";
            //SQL sunucu icin baglanti oluştur
           
            SqlConnection baglanti = new SqlConnection("server=MERT\\MSSQLSERVER01;database=Master; Integrated Security=SSPI");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT Count(name) FROM master.dbo.sysdatabases WHERE name=@prmVeritabani", baglanti);
            //Komut nesnesine parametre ile kontrol edilecek veritabanin adini geciyoruz. 
            komut.Parameters.AddWithValue("@prmVeriTabani", VeritataniAdi);
            //Baglantiyi ac.
            
            //Executescalar ile sorgu sonucunda dönen degeri aliyoruz. Veritabanı varsa 1 yoksa 0 dönecektir.
            int sonuc = (int)komut.ExecuteScalar();
            //işlem bitti. Baglantiyi kapatiyoruz.
            baglanti.Close();
            //Veritabanı var ise yapılacaklar
            if (sonuc != 0)
            {
                //Veritabanı ve tablolar var
            }
            else
            {
                
                baglanti.Open();
                //Veritabanı yok ise yapılacaklar
                //Veritabanı yarat
                komut.CommandText = "Create Database " + VeritataniAdi;
                komut.ExecuteNonQuery();
                baglanti.Close();
                SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");
                loginbaglanti.Open();
                
                SqlCommand tablelogin = new SqlCommand("create table " + "login1" + " (" + "id" + " " + "tinyint" + "," + "username" + " " + "nvarchar(20)" + "," + "password" + " " + "nvarchar(20)" + ")", loginbaglanti);
                tablelogin.ExecuteNonQuery();

                SqlCommand tablepano = new SqlCommand("create table " + "pano" + " (" + "id" + " " + "tinyint" + "," + "aciklama" + " " + "nvarchar(200)" + "," + "tarih" + " " + "nvarchar(50)" + ")", loginbaglanti);
                tablepano.ExecuteNonQuery();

                SqlCommand tablemusteriekle = new SqlCommand("create table " + "musteriEkle" + " (" + "id" + " " + "tinyint" + "," + "isim" + " " + "nvarchar(50)" + "," + "sirket" + " " + "nvarchar(50)" + "," + "pozisyon" + " " + "nvarchar(50)" + "," + "tarih" + " " + "nvarchar(50)" + ")", loginbaglanti);
                tablemusteriekle.ExecuteNonQuery();


                SqlCommand tablemurunekle = new SqlCommand("create table " + "urunEkle" + " (" + "id" + " " + "tinyint" + "," + "urunAdı" + " " + "nvarchar(50)" + "," + "stokAdedi" + " " + "int" + "," + "Fiyat" + " " + "float" + ")", loginbaglanti);
                tablemurunekle.ExecuteNonQuery();

                SqlCommand tablesiparisekle = new SqlCommand("create table " + "siparisEkle" + " (" + "id" + " " + "tinyint" + "," + "siparisVeren" + " " + "nvarchar(50)" + "," + "siparisUrun" + " " + "nvarchar(50)" + "," + "siparisMiktari" + " " + "int" + "," + "tarih" + " " + "nvarchar(50)" + ")", loginbaglanti);
                tablesiparisekle.ExecuteNonQuery();

                SqlCommand tableteklifekle = new SqlCommand("create table " + "teklifEkle" + " (" + "id" + " " + "tinyint" + "," + "teklifVeren" + " " + "nvarchar(50)" + "," + "teklifVerilenSirket" + " " + "nvarchar(50)" + "," + "teklifDeger" + " " + "float" + "," + "tarih" + " " + "nvarchar(50)" + ")", loginbaglanti);
                tableteklifekle.ExecuteNonQuery();

                SqlCommand tablecalisanekle = new SqlCommand("create table " + "calısanEkle" + " (" + "id" + " " + "tinyint" + "," + "calisanAdi" + " " + "nvarchar(50)" + "," + "unvan" + " " + "nvarchar(50)" + "," + "tarih" + " " + "nvarchar(50)" + ")", loginbaglanti);
                tablecalisanekle.ExecuteNonQuery();
                /*               
                SqlCommand tablecalisanekle = new SqlCommand("create Table calısanEkle" + "(id tinyint , calisanAdi nvarchar(50) , unvan nvarchar(50) , tarih nvarchar(50))", loginbaglanti);
                tablecalisanekle.ExecuteNonQuery();
                */
                loginbaglanti.Close();
            }
            
        }


        private void altalma_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {       
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}

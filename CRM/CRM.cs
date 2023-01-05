using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class CRM : Form
    {
        public CRM()
        {
            InitializeComponent();
        }
        

        public void aktiviteler_Load(object sender, EventArgs e)
        {
            btn_pano.Normalcolor = Color.PowderBlue;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_stok.Normalcolor = Color.Transparent;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;

            

            genel_Panel.Controls.Clear();
            pano panon = new pano();
            panon.TopLevel = false;
            genel_Panel.Controls.Add(panon);
            panon.Show();
        }



        #region Ayar
        bool move;
        int mouse_x;
        int mouse_y;

        private void aktivite_altalma_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void aktivite_kapama_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        #endregion



        public void btn_hesap_Click(object sender, EventArgs e)
        {
            HesapGirisi form1 = new HesapGirisi();
            this.Hide();
            form1.ShowDialog();
        }



        private void btn_pano_Click(object sender, EventArgs e)
        {
            btn_pano.Normalcolor = Color.PowderBlue;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_stok.Normalcolor = Color.Transparent;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;


            genel_Panel.Controls.Clear();
            pano panon = new pano();
            panon.TopLevel = false;
            genel_Panel.Controls.Add(panon);
            panon.Show();
        }



        private void btn_musteri_Click(object sender, EventArgs e)
        {
            btn_musteri.Normalcolor = Color.PowderBlue;
            btn_pano.Normalcolor = Color.Transparent;
            btn_stok.Normalcolor = Color.Transparent;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;


            genel_Panel.Controls.Clear();
            musteriler musteri = new musteriler();
            musteri.TopLevel = false;
            genel_Panel.Controls.Add(musteri);
            musteri.Show();
        }



        private void btn_stok_Click(object sender, EventArgs e)
        {
            btn_stok.Normalcolor = Color.PowderBlue;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_pano.Normalcolor = Color.Transparent;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;

            genel_Panel.Controls.Clear();
            stok stok_durum = new stok();
            stok_durum.TopLevel = false;
            genel_Panel.Controls.Add(stok_durum);
            stok_durum.Show();
        }



        private void btn_teklif_Click(object sender, EventArgs e)
        {
            btn_teklif.Normalcolor = Color.PowderBlue;
            btn_stok.Normalcolor = Color.Transparent;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_pano.Normalcolor = Color.Transparent;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;

            genel_Panel.Controls.Clear();
            Teklifler teklif = new Teklifler();
            teklif.TopLevel = false;
            genel_Panel.Controls.Add(teklif);
            teklif.Show();
        }



        private void btn_siparis_Click(object sender, EventArgs e)
        {
            btn_siparis.Normalcolor = Color.PowderBlue;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_stok.Normalcolor = Color.Transparent;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_pano.Normalcolor = Color.Transparent;
            btn_calısan.Normalcolor = Color.Transparent;

            genel_Panel.Controls.Clear();
            siparisler siparis = new siparisler();
            siparis.TopLevel = false;
            genel_Panel.Controls.Add(siparis);
            siparis.Show();
        }



        private void btn_calısan_Click(object sender, EventArgs e)
        {
            btn_calısan.Normalcolor = Color.PowderBlue;
            btn_siparis.Normalcolor = Color.Transparent;
            btn_teklif.Normalcolor = Color.Transparent;
            btn_stok.Normalcolor = Color.Transparent;
            btn_musteri.Normalcolor = Color.Transparent;
            btn_pano.Normalcolor = Color.Transparent;

            genel_Panel.Controls.Clear();
            calısanlar calısan = new calısanlar();
            calısan.TopLevel = false;
            genel_Panel.Controls.Add(calısan);
            calısan.Show();
        }
    }
}


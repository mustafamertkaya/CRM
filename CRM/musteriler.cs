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
    public partial class musteriler : Form
    {
        public musteriler()
        {
            InitializeComponent();
        }

        

        musteritableDataContext dc = new musteritableDataContext();
        List<musterilerControl> tils = new List<musterilerControl>();

        private void musteriler_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.musteriEkle)
            {
                yerlestir(deg.isim,deg.sirket,deg.pozisyon, deg.tarih);
            }

        }
        public void yerlestir(string isim, string sirket, string pozisyon, string tarih)
        {
            musterilerControl it = new musterilerControl();
            it.isim_label.Text = isim;
            it.sirket_label.Text= sirket;
            it.pozisyon_label.Text= pozisyon;
            it.tarih_label.Text = tarih;
            it.Dock= DockStyle.Top;
            tils.Add(it);
            musteri_Panel.Controls.Add(it);
        }

        public void temizle()
        {
            musteri_Panel.Controls.Clear();
        }

        private void btn_mstrEkle_Click(object sender, EventArgs e)
        {

            musteriEkle musteriekle = new musteriEkle();
            musteriekle.ShowDialog();

            temizle();
            foreach (var deg in dc.musteriEkle)
            {
                yerlestir(deg.isim, deg.sirket, deg.pozisyon, deg.tarih);
            }
        }
       
        
    }
}

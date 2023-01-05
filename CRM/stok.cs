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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }


        stoktableDataContext dc = new stoktableDataContext();
        List<stokControl> tils = new List<stokControl>();

        private void stok_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.urunEkle)
            {
                yerlestir(deg.urunAdı, deg.stokAdedi, Convert.ToString(deg.Fiyat));
            }
        }


        public void yerlestir(string urunAdı, int stokAdedi, string Fiyat)
        {
            stokControl it = new stokControl();
            it.urunAdi_label.Text = urunAdı;
            it.stokAdedi_label.Text = stokAdedi.ToString();
            it.fiyat_label.Text = Fiyat;
            it.Dock = DockStyle.Top;
            tils.Add(it);
            stok_Panel.Controls.Add(it);
        }

        public void temizle()
        {
            stok_Panel.Controls.Clear();
        }

        private void btn_urunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunekle = new UrunEkle();             
            urunekle.ShowDialog();
            temizle();
            foreach (var deg in dc.urunEkle)
            {
                yerlestir(deg.urunAdı, deg.stokAdedi, Convert.ToString(deg.Fiyat));
            }
        }

        private void btn_stokGuncelle_Click(object sender, EventArgs e)
        {
            stokGuncelle stokguncelle = new stokGuncelle();            
            stokguncelle.ShowDialog();
            temizle();
            foreach (var deg in dc.urunEkle)
            {
                yerlestir(deg.urunAdı, deg.stokAdedi, Convert.ToString(deg.Fiyat));
            }
        }
    }
}

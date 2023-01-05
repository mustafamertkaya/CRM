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
    public partial class Teklifler : Form
    {
        public Teklifler()
        {
            InitializeComponent();
        }


        tekliftableDataContext dc = new tekliftableDataContext();
        List<tekliflerControl> tils = new List<tekliflerControl>();

        private void Teklifler_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.teklifEkle)
            {
                yerlestir(deg.teklifVeren, deg.teklifVerilenSirket, Convert.ToString(deg.teklifDeger), deg.tarih);
            }
        }

        public void temizle()
        {
            teklif_Panel.Controls.Clear();
        }

        public void yerlestir(string teklifVeren, string teklifVerilenSirket, string teklifDeger, string tarih)
        {
            tekliflerControl it = new tekliflerControl();
            it.tklfVeren_label.Text = teklifVeren;
            it.tklfSirket_label.Text = teklifVerilenSirket;
            it.tklfDeger_label.Text = teklifDeger;
            it.tarih_label.Text = tarih;
            it.Dock = DockStyle.Top;
            tils.Add(it);
            teklif_Panel.Controls.Add(it);
        }



        private void btn_teklifEkle_Click(object sender, EventArgs e)
        {

            teklifEkle teklifekle = new teklifEkle();
            teklifekle.ShowDialog();
            temizle();
            foreach (var deg in dc.teklifEkle)
            {
                yerlestir(deg.teklifVeren, deg.teklifVerilenSirket, Convert.ToString(deg.teklifDeger), deg.tarih);
            }
        }


       
    }
}

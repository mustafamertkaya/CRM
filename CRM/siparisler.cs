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
    public partial class siparisler : Form
    {
        public siparisler()
        {
            InitializeComponent();
        }

        siparistableDataContext dc = new siparistableDataContext();
        List<siparislerControl> tils = new List<siparislerControl>();

        private void siparisler_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.siparisEkle)
            {
                yerlestir(deg.siparisVeren, deg.siparisUrun, Convert.ToString(deg.siparisMiktari), deg.tarih);
            }
        }

        public void temizle()
        {
            panel1.Controls.Clear();
        }

        public void yerlestir(string siparisVeren, string siparisUrun, string siparisMiktari, string tarih)
        {
            siparislerControl it = new siparislerControl();
            it.siparisVeren_label.Text = siparisVeren;
            it.siparisUrun_label.Text = siparisUrun;
            it.siparisMiktar_label.Text = siparisMiktari;
            it.siparisTarih_label.Text = tarih;
            it.Dock = DockStyle.Top;
            tils.Add(it);
            panel1.Controls.Add(it);
        }

        private void btn_siparisEkle_Click(object sender, EventArgs e)
        {

            siparisEkleForm siparisekle = new siparisEkleForm();
            siparisekle.ShowDialog();
            temizle();
            foreach (var deg in dc.siparisEkle)
            {
                yerlestir(deg.siparisVeren, deg.siparisUrun, Convert.ToString(deg.siparisMiktari), deg.tarih);
            }
        }

        
    }
}

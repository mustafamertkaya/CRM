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
    public partial class calısanlar : Form
    {
        public calısanlar()
        {
            InitializeComponent();
        }

        calısantableDataContext dc = new calısantableDataContext();
        List<calısanlarControl> tils = new List<calısanlarControl>();

        private void calısanlar_Load(object sender, EventArgs e)
        {
            temizle();
            foreach (var deg in dc.calısanEkle)
            {
                yerlestir(deg.calisanAdi, deg.unvan, deg.tarih);
            }
        }

        public void temizle()
        {
            panel1.Controls.Clear();
        }

        public void yerlestir(string calisanAdi, string unvan, string tarih)
        {
            calısanlarControl it = new calısanlarControl();
            it.calisanAdi_label.Text = calisanAdi;
            it.calisanUnvan_label.Text = unvan;
            it.calisanTarih_label.Text = tarih;
            it.Dock = DockStyle.Top;
            tils.Add(it);
            panel1.Controls.Add(it);
        }

        private void btn_siparisEkle_Click(object sender, EventArgs e)
        {
            calısanEkleForm calısanekle = new calısanEkleForm();            
            calısanekle.ShowDialog();
            temizle();
            foreach (var deg in dc.calısanEkle)
            {
                yerlestir(deg.calisanAdi, deg.unvan, deg.tarih);
            }
        }
    }
}

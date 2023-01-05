using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class pano : Form
    {
        public pano()
        {
            InitializeComponent();
        }

        SqlConnection loginbaglanti = new SqlConnection(@"Data Source=MERT\MSSQLSERVER01;Initial Catalog=CRM;Integrated Security=True");

        ticketsDataContext dc = new ticketsDataContext();
        List<UserControl1> tils = new List<UserControl1>();

        
        
        private void pano_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.pano)
            {
                
                yerlestir(deg.aciklama, deg.tarih);
            }


        }

       
        public void yerlestir(string aciklama, string tarih )
        {
            
           
            UserControl1 it = new UserControl1();
            it.acıklama_label.Text = aciklama;
            it.tarih_label.Text=tarih;
            it.Dock = DockStyle.Top;
            tils.Add( it );
            panel1.Controls.Add( it );
        }
       



        
       


    }
}

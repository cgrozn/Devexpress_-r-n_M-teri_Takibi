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

namespace EvdeCalisma
{
    public partial class frmHareketler : Form
    {
        public frmHareketler()
        {
            InitializeComponent();
        }

      
        void ListeleFirma()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec FirmaHareket", baglan);
            da.Fill(dt);
            gridControl2.DataSource = dt;
            baglan.Close();
        }
        void listeMusteri()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            DataTable d2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("exec MusteriHareket", baglan);
            da2.Fill(d2);
            gridControl1.DataSource = d2;
            baglan.Close();


        }

        private void frmHareketler_Load(object sender, EventArgs e)
        {

            listeMusteri();
            ListeleFirma();
        }
    }
}

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
    public partial class frmStokDetay : Form
    {
        public frmStokDetay()
        {
            InitializeComponent();
        }
        public string ad;
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void frmStokDetay_Load(object sender, EventArgs e)
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tblUrunler where UrunAd='" + ad + "'",baglan);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }
    }
}

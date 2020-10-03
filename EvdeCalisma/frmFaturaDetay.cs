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
    public partial class frmFaturaDetay : Form
    {
        public frmFaturaDetay()
        {
            InitializeComponent();
        }
        public string id;
        private void frmFaturaDetay_Load(object sender, EventArgs e)
        {
            Liste();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        void Liste()
        {

            baglan.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select *from tblFaturaDetay where FaturaId='" + id + "'", baglan);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaDuzenle fr = new frmFaturaDuzenle();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.urunid = dr["FaturaUrunId"].ToString();
            }
            fr.Show();
        }
    }
}

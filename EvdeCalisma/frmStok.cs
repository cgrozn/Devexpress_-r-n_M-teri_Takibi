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
    public partial class frmStok : Form
    {
        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStok_Load(object sender, EventArgs e)
        {
            listeUrun();
            CharGetir();
            c();
           
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        void CharGetir()
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select UrunAd,Sum(adet) as'Miktar' from tblUrunler group by UrunAd", baglan);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));


            }
            baglan.Close();

           
           
        }
        void c()
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select IL,Count(*) From tblFirma Group by IL", baglan);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));


            }
            baglan.Close();

        }
        void listeUrun()
        {

            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select UrunAd,Sum(adet) as'Miktar' from tblUrunler group by UrunAd", baglan);
            DataTable dt = new DataTable();

            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmStokDetay fr = new frmStokDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.ad = dr["UrunAd"].ToString();
            }
            fr.Show();
        }
    }
}

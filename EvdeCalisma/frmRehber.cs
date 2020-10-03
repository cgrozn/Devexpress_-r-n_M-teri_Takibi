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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }

        private void frmRehber_Load(object sender, EventArgs e)
        {
            MusteriListele();
            FirmaListe();

        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void MusteriListele()
        {

            baglan.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ad,Soyad,Telefon,Telefon2,Mail from tblMusteriler", baglan);
            da.Fill(table);
            gridControl1.DataSource = table;
            baglan.Close();


        }
        void FirmaListe()
        {
            baglan.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ad,YetkiliAdSoy,Telefon,Telefon2,Mail,Fax from tblFirma", baglan);

            da.Fill(dt);
            gridControl2.DataSource = dt;
            baglan.Close();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                frm.mail = dr["Mail"].ToString();

            }
            frm.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmMail frm1 = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                frm1.mail = dr["Mail"].ToString();
            }
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}

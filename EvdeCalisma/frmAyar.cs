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
    public partial class frmAyar : Form
    {
        public frmAyar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void Kaydet_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblAdmin(KullaniciAd,Parola)values(@p1,@p2)", baglan);

            cmd.Parameters.AddWithValue("p1", k_ad.Text);
            cmd.Parameters.AddWithValue("p2", k_sifre.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeKullanici();

        }
        void listeKullanici()
        {
            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter("select *from tblAdmin", baglan);
            DataTable dt = new DataTable();

            da.Fill(dt);
            gridControl1.DataSource = dt;

            baglan.Close();
        }
        private void frmAyar_Load(object sender, EventArgs e)
        {
            listeKullanici();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblAdmin set KulllaniciAd=@p1,Parola=@p2", baglan);
            cmd.Parameters.AddWithValue("p1", k_ad.Text);
            cmd.Parameters.AddWithValue("p2", k_sifre.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeKullanici();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblAdmin where Id=@p1", baglan);
            cmd.Parameters.AddWithValue("p1", txt_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeKullanici();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txt_id.Text = dr["Id"].ToString();
                k_ad.Text = dr["KullaniciAd"].ToString();
                k_sifre.Text = dr["Parola"].ToString();
            }
        }
    }
}

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
    public partial class frmFaturalar : Form
    {
        public frmFaturalar()
        {
            InitializeComponent();
        }

        private void frmFaturalar_Load(object sender, EventArgs e)
        {
            listeFatura();
            Temizle();

        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        void listeFatura()
        {

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dr=new SqlDataAdapter("select *from tblFaturabilgi", baglan);
            dr.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            baglan.Open();
            if (fbilgi_id.Text == "")
            {
                SqlCommand cmd = new SqlCommand("insert into tblFaturaBilgi(Seri,SıraNo,VergiDaire,Alici,TeslimEden,TeslimAlan)" +
                    "values(@p1,@p2,@p3,@p4,@p5,@p6)", baglan);

                cmd.Parameters.AddWithValue("p1", fbilgi_seri.Text);
                cmd.Parameters.AddWithValue("p2", fbilgi_serino.Text);
                cmd.Parameters.AddWithValue("p3", fbilgi_vd.Text);
                cmd.Parameters.AddWithValue("p4", fbilgi_alici.Text);
                cmd.Parameters.AddWithValue("p5", fbilgi_teden.Text);
                cmd.Parameters.AddWithValue("p6", fbilgi_talan.Text);

                cmd.ExecuteNonQuery();
              

            }
            if (fbilgi_id.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(fdetay_fiyat.Text);
                 miktar = Convert.ToDouble(fdetay_miktar.Text);
                tutar = fiyat * miktar;
                fdetay_tutar.Text = tutar.ToString();

                SqlCommand cmd2 = new SqlCommand("insert into tblFaturaDetay(UrunAd,Miktar,Fiyat,Tutar,FaturaId)" +
                    "values(@p1,@p2,@p3,@p4,@p5)", baglan);

                cmd2.Parameters.AddWithValue("p1", fdetay_ad.Text);

                cmd2.Parameters.AddWithValue("p2", fdetay_miktar.Text);

                cmd2.Parameters.AddWithValue("p3", fdetay_fiyat.Text);
                cmd2.Parameters.AddWithValue("p4", fdetay_tutar.Text);
                cmd2.Parameters.AddWithValue("p5", fdetay_faturaid.Text);
                cmd2.ExecuteNonQuery();

            }
            baglan.Close();
            listeFatura();
            Temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from tblFaturaBilgi where FaturaBilgiId=@p1", baglan);
            cmd.Parameters.AddWithValue("p1", fbilgi_id.Text);
            cmd.ExecuteNonQuery();

            baglan.Close();
            listeFatura();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fbilgi_id.Text = dr["FaturaBilgiId"].ToString();
                fbilgi_seri.Text = dr["Seri"].ToString();
                fbilgi_serino.Text = dr["SıraNo"].ToString();
                fbilgi_vd.Text = dr["VergiDaire"].ToString();
                fbilgi_alici.Text = dr["Alici"].ToString();
                fbilgi_teden.Text = dr["TeslimEden"].ToString();
                fbilgi_talan.Text = dr["TeslimAlan"].ToString();
            }
        }
        void Temizle()
        {
            fbilgi_id.Text = "";
            fbilgi_seri.Text = "";
            fbilgi_serino.Text = "";
            fbilgi_vd.Text = "";
            fbilgi_alici.Text = "";
            fbilgi_teden.Text = "";
            fbilgi_talan.Text = "";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tblFaturaBilgi set Seri=@p1,SıraNo=@p2,VergiDaire=@p3,Alici=@p4,TeslimEden=@p5,Teslimalan=@p6 where FaturaBilgiId=@p11", baglan);

            cmd.Parameters.AddWithValue("p1", fbilgi_seri.Text);
            cmd.Parameters.AddWithValue("p2", fbilgi_serino.Text);
            cmd.Parameters.AddWithValue("p3", fbilgi_vd.Text);
            cmd.Parameters.AddWithValue("p4", fbilgi_alici.Text);
            cmd.Parameters.AddWithValue("p5", fbilgi_teden.Text);
            cmd.Parameters.AddWithValue("p6", fbilgi_talan.Text);

            cmd.Parameters.AddWithValue("p11", fbilgi_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeFatura();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaDetay fr = new frmFaturaDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["FaturaBilgiId"].ToString();
            }
            fr.Show();
        }
    }
}

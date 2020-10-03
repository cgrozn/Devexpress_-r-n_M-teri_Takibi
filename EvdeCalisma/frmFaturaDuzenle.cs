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
    public partial class frmFaturaDuzenle : Form
    {
        public frmFaturaDuzenle()
        {
            InitializeComponent();
        }
        public string urunid;
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void frmFaturaDuzenle_Load(object sender, EventArgs e)
        {
            fdetay_id.Text = urunid;



            baglan.Open();

            SqlCommand cmd = new SqlCommand("select *from tblFaturaDetay where FaturaUrunId=@p1", baglan);

            cmd.Parameters.AddWithValue("p1", urunid);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                fdetay_ad .Text= dr[1].ToString();
                fdetay_fiyat.Text = dr[3].ToString();
                fdetay_miktar.Text = dr[2].ToString();
                fdetay_tutar.Text = dr[4].ToString();

            }
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd2 = new SqlCommand("update tblFaturaDetay set UrunAd=@p1, Miktar=@p2, Fiyat=@p3,Tutar=@p4 where FaturaUrunId=@p5", baglan);

            cmd2.Parameters.AddWithValue("p1", fdetay_ad.Text);

            cmd2.Parameters.AddWithValue("p2", fdetay_miktar.Text);

            cmd2.Parameters.AddWithValue("p3", decimal.Parse(fdetay_fiyat.Text) );
            cmd2.Parameters.AddWithValue("p4",decimal.Parse(fdetay_tutar.Text));
            cmd2.Parameters.AddWithValue("p5", fdetay_id.Text);
            cmd2.ExecuteNonQuery();
            baglan.Close();



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblFaturaDetay where FaturaUrunId=@p5 ", baglan);
            cmd.Parameters.AddWithValue("p5", fdetay_id.Text);
            baglan.Close();

        }
    }
}

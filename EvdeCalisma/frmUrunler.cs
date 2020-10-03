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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

     

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblUrunler where Id='"+txt_id.Text+"'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            UrunListe();
            Temizle();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            UrunListe();
            Temizle();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void UrunListe()
        {
            baglan.Open();
            DataTable dt = new DataTable();
           SqlDataAdapter liste = new SqlDataAdapter("select *from tblUrunler ",baglan);

            liste.Fill(dt);
            gridControl1.DataSource = dt;

            baglan.Close();

        }

        private void urun_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblUrunler (UrunAd," +
              "Marka," +
              "Model," +
              "Yil,Adet,AlisFiyat,SatisFiyat) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan);

            cmd.Parameters.AddWithValue("@p1", txt_ad.Text);
            cmd.Parameters.AddWithValue("@p2", txt_marka.Text);
            cmd.Parameters.AddWithValue("@p3", txt_model.Text);
            cmd.Parameters.AddWithValue("@p4", mask_yil.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse((urun_adet.Value).ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(txt_alis.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(txt_satis.Text));
            // cmd.Parameters.AddWithValue("@p8", rchDetay.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            UrunListe();
            Temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tblUrunler set UrunAd=@p1,Marka=@p2,Model=@p3,Yil=@p4,Adet=@p5," +
                "AlisFiyat=@p6,SatisFiyat=@p7 where Id=@p8", baglan);
            cmd.Parameters.AddWithValue("p1", txt_ad.Text);
            cmd.Parameters.AddWithValue("p2", txt_marka.Text);
            cmd.Parameters.AddWithValue("p3", txt_model.Text);
            cmd.Parameters.AddWithValue("p4", mask_yil.Text);
            cmd.Parameters.AddWithValue("p5", int.Parse((urun_adet.Value).ToString()));
            cmd.Parameters.AddWithValue("p6", decimal.Parse(txt_alis.Text));
            cmd.Parameters.AddWithValue("p7", decimal.Parse(txt_satis.Text));
            cmd.Parameters.AddWithValue("p8", txt_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            UrunListe();
            Temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txt_id.Text = dr["Id"].ToString();
                txt_ad.Text = dr["UrunAd"].ToString();
                txt_marka.Text = dr["Marka"].ToString();
                txt_model.Text = dr["Model"].ToString();
                mask_yil.Text = dr["Yil"].ToString();
                urun_adet.Text = dr["Adet"].ToString();
                txt_alis.Text = dr["AlisFiyat"].ToString();
                txt_satis.Text = dr["SatisFiyat"].ToString();

            }
        }
        void Temizle()
        {
            txt_id.Text = "";
            txt_ad.Text = "";
            txt_marka.Text = "";
            txt_model.Text = "";
            mask_yil.Text = "";
            urun_adet.Text = "";
            txt_alis.Text = "";
            txt_satis.Text = "";
        }




    }
}

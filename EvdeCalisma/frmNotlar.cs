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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        void listeleNot()
        {

            baglan.Open();

            SqlDataAdapter da = new SqlDataAdapter("select *from tblNotlar", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblNotlar(Baslik,Detay,NotOlusturan,NotHitap)" +
                "values(@p1,@p2,@p3,@p4)", baglan);
            cmd.Parameters.AddWithValue("p1", not_baslik.Text);
            cmd.Parameters.AddWithValue("p2", not_detaylar.Text);
            cmd.Parameters.AddWithValue("p3", not_olus.Text);
            cmd.Parameters.AddWithValue("p4", not_hitap.Text);
            cmd.ExecuteNonQuery();
                baglan.Close();
            listeleNot();
            Temizle();

        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listeleNot();
            Temizle();

        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");


        private void simpleButton3_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from tblNotlar where Id='"+not_id.Text+"'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeleNot();
                            Temizle();



        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                not_baslik.Text = dr["Baslik"].ToString();
                not_id.Text = dr["Id"].ToString();
                not_detaylar.Text = dr["Detay"].ToString();
                not_olus.Text= dr["NotOlusturan"].ToString();
                not_hitap.Text= dr["NotHitap"].ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-R8EL9PH\SQLEXPRESS;Initial Catalog=UrunOtomasyan;Integrated Security=True");

            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblNotlar set Baslik=@p1,Detay=@p2,NotOlusturan=@p3,NotHitap=@p4 where Id=@p5", baglan);
            cmd.Parameters.AddWithValue("p1", not_baslik.Text);
            cmd.Parameters.AddWithValue("p2", not_detaylar.Text);
            cmd.Parameters.AddWithValue("p3", not_olus.Text);
            cmd.Parameters.AddWithValue("p4", not_hitap.Text);
            cmd.Parameters.AddWithValue("p5", not_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            listeleNot();
            Temizle();

        }
        void Temizle()
        {
            not_baslik.Text = "";
            not_id.Text = "";
            not_detaylar.Text = "";
            not_olus.Text = "";
            not_hitap.Text = "";
            not_id.Text = "";

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay fr = new frmNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin = dr["Detay"].ToString();
            }
            fr.Show();
        }
    }
}

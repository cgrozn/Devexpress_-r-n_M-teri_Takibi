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
using DevExpress.Charts;

namespace EvdeCalisma
{
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }


        private void frmGider_Load(object sender, EventArgs e)
        {
            ListeGider();
            Temizle();
        }
        void ListeGider()
        {
            baglan.Open();

            DataTable dt = new DataTable();

            SqlDataAdapter da=new SqlDataAdapter("select *from tblGiderler", baglan);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("insert into tblGiderler(Ay,Yil,Elektrik,Su,Dogalgaz,Internet,Maaslar,Notlar)values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglan);
            cmd.Parameters.AddWithValue("p2", gider_ay.Text);
            cmd.Parameters.AddWithValue("p3", gider_yil.Text);
            cmd.Parameters.AddWithValue("p4", decimal.Parse(gider_elek.Text));
            cmd.Parameters.AddWithValue("p5", decimal.Parse(gider_su.Text));
            cmd.Parameters.AddWithValue("p6", decimal.Parse(gider_dogal.Text));
            cmd.Parameters.AddWithValue("p7", decimal.Parse(gider_inter.Text));
            cmd.Parameters.AddWithValue("p8", decimal.Parse(gider_maas.Text));
            cmd.Parameters.AddWithValue("p9", (gider_not.Text));

            cmd.ExecuteNonQuery();
            baglan.Close();
            ListeGider();
            Temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                gider_id.Text = dr["Id"].ToString();
                gider_ay.Text = dr["Ay"].ToString();
                gider_yil.Text = dr["Yil"].ToString();
                gider_elek.Text = dr["Elektrik"].ToString();
                gider_su.Text = dr["Su"].ToString();
                gider_dogal.Text = dr["Dogalgaz"].ToString();
                gider_inter.Text = dr["Internet"].ToString();
                gider_maas.Text = dr["Maaslar"].ToString();
                gider_not.Text = dr["Notlar"].ToString();
            }

        }
        void Temizle()
        {
            gider_id.Text = "";
            gider_elek.Text = "";
            gider_su.Text = "";
            gider_dogal.Text = "";
            gider_inter.Text = "";
            gider_maas.Text = "";
            gider_not.Text = "";
            gider_ay.Text = "";
            gider_yil.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from tblGiderler where Id=@p1", baglan);
            cmd.Parameters.AddWithValue("p1", gider_id.Text);
            cmd.ExecuteNonQuery();
            ListeGider();
            Temizle();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tblGiderler set Ay=@p1,Yil=@p2,Elektrik=@p3,Su=@p4,Dogalgaz=@p5,Internet=@p6,Maaslar=@p7,Notlar=@p8 where Id=@p9", baglan);
            cmd.Parameters.AddWithValue("p1", gider_ay.Text);
            cmd.Parameters.AddWithValue("p2", gider_yil.Text);
            cmd.Parameters.AddWithValue("p3", decimal.Parse(gider_elek.Text));
            cmd.Parameters.AddWithValue("p4", decimal.Parse(gider_su.Text));
            cmd.Parameters.AddWithValue("p5", decimal.Parse(gider_dogal.Text));
            cmd.Parameters.AddWithValue("p6", decimal.Parse(gider_inter.Text));
            cmd.Parameters.AddWithValue("p7", decimal.Parse(gider_maas.Text));
            cmd.Parameters.AddWithValue("p8", gider_not.Text);
            cmd.Parameters.AddWithValue("p9",gider_id.Text);

            cmd.ExecuteNonQuery();
            baglan.Close();
            ListeGider();
            Temizle();
        }
       
    }
}

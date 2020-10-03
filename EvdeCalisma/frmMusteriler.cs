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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            ListeIller();
            MusteriListele();

        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void MusteriListele()
        {

            baglan.Open();

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tblMusteriler", baglan);
            da.Fill(table);
            gridControl1.DataSource = table;
            baglan.Close();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmMusteriEkle f2 = new frmMusteriEkle();
            f2.MdiParent = this.ParentForm;
            f2.Show();
        }

        void ListeIller()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select  sehir from iller", baglan);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                musteri_il.Properties.Items.Add(dr[0]);
            }

            baglan.Close();
        }

        private void musteri_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            musteri_ilce.Properties.Items.Clear();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select ilce from ilceler where sehir=@p1", baglan);
            cmd.Parameters.AddWithValue("@p1", musteri_il.SelectedIndex+1);

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                musteri_ilce.Properties.Items.Add(dr[0]);
            }
            baglan.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into tblMusteriler(Ad,Soyad,Telefon,Telefon2,Tc,Mail,IL,Ilce,Adres,VergiDaire)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglan);

            cmd.Parameters.AddWithValue("p1", musteri_ad.Text);
            cmd.Parameters.AddWithValue("p2", musteri_soy.Text);
            cmd.Parameters.AddWithValue("p3", musteri_tel.Text);
            cmd.Parameters.AddWithValue("p4", musteri_tel2.Text);
            cmd.Parameters.AddWithValue("p5", musteri_tc.Text);
            cmd.Parameters.AddWithValue("p6", musteri_mail.Text);
            cmd.Parameters.AddWithValue("p7", musteri_il.Text);
            cmd.Parameters.AddWithValue("p8", musteri_ilce.Text);
            cmd.Parameters.AddWithValue("p9", musteri_adress.Text);
            cmd.Parameters.AddWithValue("p10", musteri_vergi.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MusteriListele();
            temizle();



        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                musteri_id.Text = dr["Id"].ToString();
                musteri_ad.Text = dr["Ad"].ToString();
                musteri_soy.Text = dr["Soyad"].ToString();
                musteri_tel.Text = dr["Telefon"].ToString();
                musteri_tel2.Text = dr["Telefon2"].ToString();
                musteri_tc.Text = dr["Tc"].ToString();
                musteri_mail.Text = dr["Mail"].ToString();
                musteri_il.Text = dr["IL"].ToString();
                musteri_ilce.Text = dr["Ilce"].ToString();
                musteri_adress.Text = dr["Adres"].ToString();
                musteri_vergi.Text = dr["VergiDaire"].ToString();
            }
        }

        void temizle()
        {
            musteri_id.Text = "";
            musteri_ad.Text = "";
            musteri_soy.Text = "";
            musteri_tel.Text = "";
            musteri_tel2.Text = "";
            musteri_tc.Text = "";
            musteri_mail.Text = "";
            musteri_il.Text = "";
            musteri_ilce.Text = "";
            musteri_adress.Text = "";
            musteri_vergi.Text = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tblMusteriler set Ad=@p1,Soyad=@p2,Telefon=@p3,Telefon2=@p4,Tc=@p5,Mail=@p6,IL=@p7,Ilce=@p8,Adres=@p9,VergiDaire=@p10 where Id=@p11", baglan);
            cmd.Parameters.AddWithValue("p1", musteri_ad.Text);
            cmd.Parameters.AddWithValue("p2", musteri_soy.Text);
            cmd.Parameters.AddWithValue("p3", musteri_tel.Text);
            cmd.Parameters.AddWithValue("p4", musteri_tel2.Text);
            cmd.Parameters.AddWithValue("p5", musteri_tc.Text);
            cmd.Parameters.AddWithValue("p6", musteri_mail.Text);
            cmd.Parameters.AddWithValue("p7", musteri_il.Text);
            cmd.Parameters.AddWithValue("p8", musteri_ilce.Text);
            cmd.Parameters.AddWithValue("p9", musteri_adress.Text);
            cmd.Parameters.AddWithValue("p10", musteri_vergi.Text);
            cmd.Parameters.AddWithValue("p11", musteri_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MusteriListele();
            temizle();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblMusteriler where Id='" + musteri_id.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            MusteriListele();
            temizle();
        }
    }
}

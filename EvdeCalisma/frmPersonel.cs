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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into tblPersonel (Ad,Soyad,Telefon,Tc,Mail,Il,Ilce,Adres,Gorev) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglan);

            cmd.Parameters.AddWithValue("@p1", person_ad.Text);
            cmd.Parameters.AddWithValue("@p2", person_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", person_tel.Text);
            cmd.Parameters.AddWithValue("@p4", person_tc.Text);
            cmd.Parameters.AddWithValue("@p5", person_mail.Text);

            cmd.Parameters.AddWithValue("@p6", comboBoxEdit1.Text);
            cmd.Parameters.AddWithValue("@p7", comboBoxEdit2.Text);
            cmd.Parameters.AddWithValue("@p8", person_adres.Text);
            cmd.Parameters.AddWithValue("@p9", person_gorev.Text);

            cmd.ExecuteNonQuery();

            baglan.Close();
            PersonelListe();
            Temizle();

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            PersonelListe();
            Cekil();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        void Cekil()
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select sehir from iller", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0].ToString());
                    }

        }

        void PersonelListe()
        {

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblPersonel", baglan);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        void Temizle()
        {
            person_ad.Text = "";
            person_soyad.Text = "";
            person_tel.Text = "";
            person_gorev.Text = "";
            person_id.Text = "";
            person_mail.Text = "";
            person_tc.Text = "";

            person_adres.Text = "";
           
            person_ad.Focus();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();


            baglan.Open();
            SqlCommand cmd = new SqlCommand("select ilce from ilceler  where sehir=@p1", baglan);

            cmd.Parameters.AddWithValue("p1", comboBoxEdit1.SelectedIndex+1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit2.Properties.Items.Add(dr[0].ToString());
            }


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update tblPersonel set Ad=@p1,Soyad=@p2,Telefon=@p3,Tc=@p4,Mail=@p5," +
                "Il=@p6,Ilce=@p7,Adres=@p8,Gorev=@p9 where Id=@p10", baglan);
            cmd.Parameters.AddWithValue("@p1", person_ad.Text);
            cmd.Parameters.AddWithValue("@p2", person_soyad.Text);
            cmd.Parameters.AddWithValue("@p3", person_tel.Text);
            cmd.Parameters.AddWithValue("@p4", person_tc.Text);
            cmd.Parameters.AddWithValue("@p5", person_mail.Text);

            cmd.Parameters.AddWithValue("@p6", comboBoxEdit1.Text);
            cmd.Parameters.AddWithValue("@p7", comboBoxEdit2.Text);
            cmd.Parameters.AddWithValue("@p8", person_adres.Text);
            cmd.Parameters.AddWithValue("@p9", person_gorev.Text);
            cmd.Parameters.AddWithValue("@p10", person_id.Text);

            cmd.ExecuteNonQuery();

            baglan.Close();
            PersonelListe();
            Temizle();

        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                person_id.Text = dr["Id"].ToString();
                person_ad.Text = dr["Ad"].ToString();
                person_soyad.Text = dr["Soyad"].ToString();
                person_tel.Text = dr["Telefon"].ToString();
                person_tc.Text = dr["Tc"].ToString();
                person_mail.Text = dr["Mail"].ToString();
                comboBoxEdit1.Text = dr["Il"].ToString();
                comboBoxEdit2.Text = dr["Ilce"].ToString();
                person_adres.Text = dr["Adres"].ToString();
                person_gorev.Text = dr["Gorev"].ToString();
              
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from tblPersonel where Id='" + person_id.Text + "'", baglan);
            cmd.ExecuteNonQuery();
            baglan.Close();
            Temizle();
            PersonelListe();
        }
    }
}

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
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        void Iller()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select sehir from iller", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);
            }
            baglan.Close();
        }

        void CekKod1()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select Firmakod1 from tblKodlar", baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ric_ozel1.Text = oku[0].ToString();
            }

            baglan.Close();
        }


        void CekKod2()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select Firmakod2 from tblKodlar", baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ric_ozel2.Text = oku[0].ToString();
            }
            baglan.Close();
        }


        void CekKod3()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select Firmakod3 from tblKodlar", baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ric_ozel3.Text = oku[0].ToString();
            }
            baglan.Close();

        }



        private void frmFirma_Load(object sender, EventArgs e)
        {
            FirmaListe();
            Iller();
            CekKod1();
            CekKod2();
            CekKod3();
            Temizle();
        }

        public void FirmaListe()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tblFirma", baglan);

            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();


        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");


            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into tblFirma" +
                "(AD," +
                "Yetkilistatu," +
                "YetkiliAdSoy," +
                "Telefon," +
                "Telefon2," +
                "Mail," +
                "Fax,IL,ILce,VergiDairesi,Adres," +
                "YetkiliTc," +
                "OzelKod1,OzelKod2,OzelKod3,Sektor)" +
                "values(@p1,@p2,@p3,@p4," +
                "@p5,@p6,@p7,@p8," +
                "@p9,@p10,@p11,@p12,@p13,@p14,@p15," +
                "@p16)", baglan);
            cmd.Parameters.AddWithValue("p1", firma_ad.Text);
            cmd.Parameters.AddWithValue("p2", firma_ygorev.Text);
            cmd.Parameters.AddWithValue("p3", firma_yetkili.Text);

            cmd.Parameters.AddWithValue("p4", firma_tel.Text);
            cmd.Parameters.AddWithValue("p5", firma_tel2.Text);
            cmd.Parameters.AddWithValue("p6", firma_mail.Text);
            cmd.Parameters.AddWithValue("p7", firma_fax.Text);

            cmd.Parameters.AddWithValue("p8", comboBoxEdit1.Text);
            cmd.Parameters.AddWithValue("p9", firma_ilce.Text);
            cmd.Parameters.AddWithValue("p10", firma_vergi.Text);
            cmd.Parameters.AddWithValue("p11", richTextBox1.Text);
            cmd.Parameters.AddWithValue("p12", firma_tc.Text);
            cmd.Parameters.AddWithValue("p13", firma_kod1.Text);
            cmd.Parameters.AddWithValue("p14", firma_kod2.Text);
            cmd.Parameters.AddWithValue("p15", firma_kod3.Text);
            cmd.Parameters.AddWithValue("p16", firma_sektor.Text);


            cmd.ExecuteNonQuery();
            baglan.Close();
            FirmaListe();
            Temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblFirma set AD=@p1,Yetkilistatu=@p2,YetkiliAdSoy=@p3," +
                "Telefon=@p4,Telefon2=@p5,Mail=@p6,Fax=@p7,IL=@p8,Ilce=@p9,VergiDairesi=@p10," +
                "Adres=@p11,YetkiliTc=@p12,OzelKod1=@p13,OzelKod2=@p14,OzelKod3=@p15,Sektor=@p16 where Id=@p17",baglan);
            cmd.Parameters.AddWithValue("p1", firma_ad.Text);
            cmd.Parameters.AddWithValue("p2", firma_ygorev.Text);
            cmd.Parameters.AddWithValue("p3", firma_yetkili.Text);

            cmd.Parameters.AddWithValue("p4", firma_tel.Text);
            cmd.Parameters.AddWithValue("p5", firma_tel2.Text);
            cmd.Parameters.AddWithValue("p6", firma_mail.Text);
            cmd.Parameters.AddWithValue("p7", firma_fax.Text);

            cmd.Parameters.AddWithValue("p8", comboBoxEdit1.Text);
            cmd.Parameters.AddWithValue("p9", firma_ilce.Text);
            cmd.Parameters.AddWithValue("p10", firma_vergi.Text);
            cmd.Parameters.AddWithValue("p11", richTextBox1.Text);
            cmd.Parameters.AddWithValue("p12", firma_tc.Text);
            cmd.Parameters.AddWithValue("p13", firma_kod1.Text);
            cmd.Parameters.AddWithValue("p14", firma_kod2.Text);
            cmd.Parameters.AddWithValue("p15", firma_kod3.Text);
            cmd.Parameters.AddWithValue("p16", firma_sektor.Text);
            cmd.Parameters.AddWithValue("p17", firma_id.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
            FirmaListe();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                firma_id.Text = dr["Id"].ToString();
                firma_ad.Text = dr["AD"].ToString();
                firma_yetkili.Text = dr["YetkiliStatu"].ToString();
                firma_sektor.Text = dr["Sektor"].ToString();
                firma_ygorev.Text = dr["YetkiliAdSoy"].ToString();
                firma_tel.Text = dr["Telefon"].ToString();
                firma_tel2.Text = dr["Telefon2"].ToString();
                firma_mail.Text = dr["Mail"].ToString();
                firma_fax.Text = dr["Fax"].ToString();
              //  firma_il.Text = dr["IL"].ToString();
              // firma_ilce.Text= dr["ILce"].ToString();
                richTextBox1.Text = dr["Adres"].ToString();
                firma_tc.Text = dr["YetkiliTc"].ToString();


            }
        }

        private void comboBoxEdit1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            firma_ilce.Properties.Items.Clear();

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select ilce from ilceler where sehir=@p1", baglan);

            cmd.Parameters.AddWithValue("p1", comboBoxEdit1.SelectedIndex + 1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                firma_ilce.Properties.Items.Add(dr[0]);

            }

            baglan.Close();
        }

        void Temizle()
        {
            firma_id.Text = "";
            firma_ad.Text = "";
            firma_yetkili.Text = "";
            firma_sektor.Text = "";
            firma_ygorev.Text = "";
            firma_tel.Text = "";
            firma_tel2.Text = "";
            firma_mail.Text = "";
            firma_fax.Text = "";
            comboBoxEdit1.Text = "";
            //  firma_il.Text = dr["IL"].ToString();
             firma_ilce.Text= "";
            richTextBox1.Text = "";
            firma_tc.Text = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from tblFirma where Id='" + firma_id.Text + "'",baglan);

            cmd.ExecuteNonQuery();
            baglan.Close();
            FirmaListe(); Temizle();

        }
    }
    }

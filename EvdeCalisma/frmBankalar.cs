using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EvdeCalisma
{
    public partial class frmBankalar : Form
    {
        public frmBankalar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into tblBankalar(BankaAdi,IL,ILce,Sube,Iban,HesapNo,Yetkili,Telefon,HesapTuru,FirmaId)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglan);

            cmd.Parameters.AddWithValue("p1", banka_ad.Text);
            cmd.Parameters.AddWithValue("p2", banka_il.Text);

            cmd.Parameters.AddWithValue("p3", banka_ilce.Text);

            cmd.Parameters.AddWithValue("p4",banka_sube.Text);
            cmd.Parameters.AddWithValue("p5", banka_iban.Text);
            cmd.Parameters.AddWithValue("p6",banka_hesap.Text);

            cmd.Parameters.AddWithValue("p7", banka_yet.Text);
            cmd.Parameters.AddWithValue("p8",banka_tel.Text);

            cmd.Parameters.AddWithValue("p9", banka_hesapturu.Text);
            cmd.Parameters.AddWithValue("p10", banka_firma.EditValue);

            cmd.ExecuteNonQuery();
            baglan.Close();
            ListeleBanka();
            Temizle();


        }



        void listeleFirma()
        {

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter dr= new SqlDataAdapter("select Id,Ad from tblFirma", baglan);
            dr.Fill(dt);
            banka_firma.Properties.ValueMember = "Id";
            banka_firma.Properties.DisplayMember = "Ad";
            banka_firma.Properties.DataSource = dt;
            baglan.Close();
        }

        void ListeleBanka()
        {

            baglan.Open();

            DataTable dt = new DataTable();

           SqlDataAdapter da = new SqlDataAdapter("execute bankabilgi", baglan);
        
            da.Fill(dt);
            gridControl1.DataSource = dt;

            baglan.Close();

        }

        private void frmBankalar_Load(object sender, EventArgs e)
        {
            ListeleBanka();
            Iller_liste();
            listeleFirma();
            Temizle();

        }

        void Iller_liste()
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("select sehir from iller", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                banka_il.Properties.Items.Add(dr[0].ToString());
            }

            baglan.Close();

        }

        private void banka_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            banka_ilce.Properties.Items.Clear();

            baglan.Open();

            SqlCommand cmd = new SqlCommand("select ilce from ilceler where sehir=@p1", baglan);
            cmd.Parameters.AddWithValue("p1", banka_il.SelectedIndex+1);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                banka_ilce.Properties.Items.Add(dr[0].ToString());
            }

            baglan.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                banka_id.Text = dr["Id"].ToString();
                banka_ad.Text = dr["BankaAdi"].ToString();
                banka_il.Text = dr["IL"].ToString();
                banka_ilce.Text = dr["ILce"].ToString();
                banka_sube.Text = dr["Sube"].ToString();
                banka_iban.Text = dr["Iban"].ToString();
                banka_hesap.Text = dr["HesapNo"].ToString();
                banka_yet.Text = dr["Yetkili"].ToString();
                banka_tel.Text = dr["Telefon"].ToString();
                banka_hesapturu.Text = dr["HesapTuru"].ToString();
                banka_firma.Text = dr["HesapTuru"].ToString();
              


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            baglan.Open();

            SqlCommand cmd = new SqlCommand("delete from tblbankalar where Id=@p1", baglan);
            cmd.Parameters.AddWithValue("p1", banka_id.Text);
            cmd.ExecuteNonQuery();


            baglan.Close();
            ListeleBanka();

            Temizle();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            baglan.Open();

            SqlCommand cmd = new SqlCommand("update tblBankalar set BankaAdi=@p1,IL=@p2,Ilce=@p3,Sube=@p4," +
                "Iban=@p5,HesapNo=@p6,Yetkili=@p7,Telefon=@p8,HesapTuru=@p9,FirmaId=@p11 where Id=@p10", baglan);

            cmd.Parameters.AddWithValue("p1", banka_ad.Text);
            cmd.Parameters.AddWithValue("p2", banka_il.Text);

            cmd.Parameters.AddWithValue("p3", banka_ilce.Text);

            cmd.Parameters.AddWithValue("p4", banka_sube.Text);
            cmd.Parameters.AddWithValue("p5", banka_iban.Text);
            cmd.Parameters.AddWithValue("p6", banka_hesap.Text);

            cmd.Parameters.AddWithValue("p7", banka_yet.Text);
            cmd.Parameters.AddWithValue("p8", banka_tel.Text);

            cmd.Parameters.AddWithValue("p9", banka_hesapturu.Text);
            cmd.Parameters.AddWithValue("p10", banka_id.Text);
            cmd.Parameters.AddWithValue("p11", banka_firma.EditValue);

            cmd.ExecuteNonQuery();
            baglan.Close();
            ListeleBanka();
            Temizle();

        }

        void Temizle()
        {
            banka_ad.Text = "";
            banka_il.Text = "";
            banka_ilce.Text = "";
            banka_sube.Text = "";
            banka_iban.Text = "";
            banka_hesap.Text = "";
            banka_yet.Text = "";
            banka_tel.Text = "";
            banka_hesapturu.Text = "";

           banka_firma.Text = "";
        
        }
    }
}

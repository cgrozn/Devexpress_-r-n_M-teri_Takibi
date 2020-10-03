using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Charts;

namespace EvdeCalisma
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");


        public string ad;
        private void frmKasa_Load(object sender, EventArgs e)
        {
            ListeGider();

            aktif.Text = ad;
            ListeFirma();
            ListeMusteri();
            //toplam tutar 
            KasaToplam();
            Odemeler();
            FimaSayisi();
            MusteriSayisi();
            PersonelMaas();
            SehirSAyFirma();
            SehirSAyMusteri();
            PesonelSayisi();
            StokSay();
           // Chart1();

            }
        void ListeMusteri()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("execute MusteriHareket ", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();

        }
        void ListeFirma()
        {
            baglan.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("execute FirmaHareket", baglan);
            DataTable dt2 = new DataTable();
            da1.Fill(dt2);
            gridControl3.DataSource = dt2;
            baglan.Close();


        }

        void KasaToplam()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select  sum(Tutar) from tblFaturaDetay", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                toplam_tutar.Text = dr[0].ToString() + "TL";
            }
            baglan.Close();
        }
        void Odemeler()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select  (Elektrik+Su+Dogalgaz+Maaslar+Internet) from  tblGiderler order by Id asc", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                odemeler.Text = dr[0].ToString() + "TL";
            }
            baglan.Close();

        }
        void MusteriSayisi()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from  tblMusteriler", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                m_sayisi.Text = dr[0].ToString();
            }
            baglan.Close();
        }

        void FimaSayisi()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from  tblFirma", baglan);
        SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               f_sayisi.Text = dr[0].ToString();
    }
    baglan.Close();
       
        }

        void SehirSAyFirma()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select count(distinct (IL)) from tblFirma", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                f_sehir.Text = dr[0].ToString();
            }
            baglan.Close();
        }
        void SehirSAyMusteri()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select count(distinct (IL)) from tblMusteriler", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                m_sehir.Text = dr[0].ToString();
            }
            baglan.Close();
        }



        void PersonelMaas()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select sum(Maaslar) from tblGiderler", baglan);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                p_maas.Text = dr[0].ToString();
            }
            baglan.Close();

        }


        void PesonelSayisi()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from tblPersonel", baglan);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                personel_say.Text = dr[0].ToString();
            }
            baglan.Close();

        }
      

        void StokSay()
        {


            baglan.Open();

            SqlCommand cmd = new SqlCommand("select sum(adet) from tblUrunler ", baglan);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                stok_say.Text = dr[0].ToString();

            }
            baglan.Close();
        }

        void Chart1()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select top 4 Ay,Elektrik from tblGiderler order by Id desc", baglan); ;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));



            }

            baglan.Close();
            baglan.Open();


            SqlCommand a = new SqlCommand("select top 4 Ay,Su from tblGiderler order by Id desc", baglan);
            SqlDataReader dr2 = a.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));



            }
            baglan.Close();

        }

       
        int sayac=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 0 && sayac <= 5)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "Elektrik";
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select top 4 Ay,Elektrik from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));



                }

                baglan.Close();

            }

                if (sayac >5 && sayac <= 10)
                {
                    chartControl1.Series["Aylar"].Points.Clear();
                    groupControl10.Text = "Su";
                    baglan.Open();
                    SqlCommand cmd2 = new SqlCommand("select top 4 Ay,Su from tblGiderler order by Id desc", baglan); ;

                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));



                    }

                    baglan.Close();
                }

            if (sayac > 10 && sayac <= 15)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "Doğalgaz";
                baglan.Open();
                SqlCommand cmd3 = new SqlCommand("select top 4 Ay,Dogalgaz from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));



                }

                baglan.Close();
            }

            if (sayac > 15 && sayac <= 20)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "İnternet";
                baglan.Open();
                SqlCommand cmd4 = new SqlCommand("select top 4 Ay,Internet from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr4[0], dr4[1]));



                }

                baglan.Close();
            }

            if (sayac > 20 && sayac <= 25)
            {
                chartControl1.Series["Aylar"].Points.Clear();

                groupControl10.Text = "Maaslar";
                baglan.Open();
                SqlCommand cmd5 = new SqlCommand("select top 4 Ay,Maaslar from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr5[0], dr5[1]));



                }

                baglan.Close();
                sayac = 0;
            }
               
           



            }


        void ListeGider()
        {
            baglan.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select *from tblGiderler", baglan);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            gridControl2.DataSource = dt;
            baglan.Close();
        }
        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {

            sayac2++;
            if (sayac2 > 0 && sayac2 <= 5)
            {
                chartControl5.Series["Aylar"].Points.Clear();

                groupControl11.Text = "Elektrik";
                baglan.Open();
                SqlCommand cmd = new SqlCommand("select top 4 Ay,Elektrik from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartControl5.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr[0], dr[1]));



                }

                baglan.Close();

            }

            if (sayac2 > 5 && sayac2 <= 10)
            {
                chartControl5.Series["Aylar"].Points.Clear();
                groupControl11.Text = "Su";
                baglan.Open();
                SqlCommand cmd2 = new SqlCommand("select top 4 Ay,Su from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl5.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));



                }

                baglan.Close();
            }

            if (sayac2 > 10 && sayac2 <= 15)
            {
                chartControl5.Series["Aylar"].Points.Clear();

                groupControl11.Text = "Doğalgaz";
                baglan.Open();
                SqlCommand cmd3 = new SqlCommand("select top 4 Ay,Dogalgaz from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    chartControl5.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr3[0], dr3[1]));



                }

                baglan.Close();
            }

            if (sayac2 > 15 && sayac2 <= 20)
            {
                chartControl5.Series["Aylar"].Points.Clear();

                groupControl11.Text = "İnternet";
                baglan.Open();
                SqlCommand cmd4 = new SqlCommand("select top 4 Ay,Internet from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr4 = cmd4.ExecuteReader();
                while (dr4.Read())
                {
                    chartControl5.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr4[0], dr4[1]));



                }

                baglan.Close();
            }

            if (sayac2 > 20 && sayac2 <= 25)
            {
                chartControl5.Series["Aylar"].Points.Clear();

                groupControl11.Text = "Maaslar";
                baglan.Open();
                SqlCommand cmd5 = new SqlCommand("select top 4 Ay,Maaslar from tblGiderler order by Id desc", baglan); ;

                SqlDataReader dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    chartControl5.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr5[0], dr5[1]));



                }

                baglan.Close();
                sayac = 0;
            }
        }
    }

      
    
}

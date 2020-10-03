using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvdeCalisma
{
    public partial class frmAnsayfa : Form
    {
        public frmAnsayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

        private void frmAnsayfa_Load(object sender, EventArgs e)
        {
            listeStok();
            Ajanda();
            ListeleFirma();
            EnCok();
          webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            //haberler();
        }

        void listeStok()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select UrunAd ,sum(Adet) as 'Adet' from tblUrunler  group by UrunAd having sum(adet)<=20 order by sum(adet) ", baglan);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            baglan.Close();
        }

        void Ajanda()
        {
            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 8 baslik,tarih,Detay from tblNotlar order by Id desc ", baglan);
            da.Fill(dt);
            gridControl2.DataSource = dt;
            baglan.Close();
            
        }
        void ListeleFirma()
        {

            baglan.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("exec Firma10", baglan);
            da.Fill(dt);
            gridControl3.DataSource = dt;
            baglan.Close();
        }

        void EnCok()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Ad,Telefon from tblFirma", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl4.DataSource = dt;
            baglan.Close();
        }
        //void haberler()
        //{

        //    XmlTextReader xml = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
        //    while (xml.Read())
        //    {
        //        if (xml.Name == "title")
        //        {
        //            listBoxControl1.Items.Add(xml.ReadString());
        //        }
        //    }
        //}
    }
}

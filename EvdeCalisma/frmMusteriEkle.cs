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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {
           Liste_il();

        }

      private void Liste_il()
        {
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand komut = new SqlCommand("select sehir from iller", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit1.Properties.Items.Add(dr[0]);

            }
            baglan.Close();
        }
        SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBoxEdit2.Properties.Items.Clear();

            baglan.Open();
            SqlCommand komut = new SqlCommand("select  ilce from ilceler where sehir=@p1", baglan);
            komut.Parameters.AddWithValue("@p1", comboBoxEdit1.SelectedIndex+1);


            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit2.Properties.Items.Add(dr[0]);

            }
            baglan.Close();
        }

        private void per_kayit_Click(object sender, EventArgs e)
        {

        }
    }
}

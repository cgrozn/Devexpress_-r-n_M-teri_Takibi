using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvdeCalisma
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        public string ad;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;
            SqlConnection baglan = new SqlConnection(@"data source =.; initial catalog = UrunOtomasyan; integrated security = True; MultipleActiveResultSets = True;");

            baglan.Open();
            SqlCommand cmd = new SqlCommand("select *from tblAdmin where KullaniciAd='" + txt_k.Text + "' and Parola='" + txt_s.Text + "'", baglan);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Home ho = new Home();
               ho.kullanici = txt_k.Text;

                ho.Show();
                this.Hide();
            }
            else
                MessageBox.Show("kullanici adi veya şifre hata");
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

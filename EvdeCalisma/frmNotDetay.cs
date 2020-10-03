using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvdeCalisma
{
    public partial class frmNotDetay : Form
    {
        public frmNotDetay()
        {
            InitializeComponent();
        }
        public string metin;
        private void frmNotDetay_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = metin;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

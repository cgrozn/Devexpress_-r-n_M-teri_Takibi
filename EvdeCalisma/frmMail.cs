using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace EvdeCalisma
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;

        private void frmMail_Load(object sender, EventArgs e)
        {
            txtMailAdres.Text = mail.ToString();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient();

            istemci.Credentials = new System.Net.NetworkCredential("cagriozencagri@gmail.com", "cagri123");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";

            istemci.EnableSsl = true;

            mesaj.To.Add(txtMailAdres.Text);

            mesaj.From = new MailAddress("cagriozencagri@gmail.com");
            mesaj.Subject = txtKonu.Text;
            mesaj.Body = txtMesaj.Text;
            istemci.Send(mesaj);

            this.Close();
                }
    }
}

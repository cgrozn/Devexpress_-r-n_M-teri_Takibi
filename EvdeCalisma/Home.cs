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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        frmUrunler urun;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urun == null || urun.IsDisposed)
            {
                urun = new frmUrunler();
                urun.MdiParent = this;
                urun.Show();
            }

        }
        frmMusteriler musteri;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null || musteri.IsDisposed)
            {
                musteri = new frmMusteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }

        }
        frmFirma firma;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (firma == null ||firma.IsDisposed)
            {
                firma = new frmFirma();
                firma.MdiParent = this;
                firma.Show();

            }

        }
        frmPersonel perso;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (perso == null || perso.IsDisposed)
            {
                perso = new frmPersonel();
                perso.MdiParent = this;
                perso.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        frmRehber rehber;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                rehber = new frmRehber();
                rehber.MdiParent = this;
                rehber.Show();
            }

        }
        frmGider gider;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gider == null || gider.IsDisposed)
            {
                gider = new frmGider();
                gider.MdiParent = this;
                gider.Show();

            }

        }
        frmBankalar bank;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bank ==null || bank.IsDisposed) {
                bank = new frmBankalar();
                bank.MdiParent = this;
                bank.Show();
            }

        }
        frmFaturalar fatura;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fatura == null || fatura.IsDisposed)
            {
                fatura = new frmFaturalar();
                fatura.MdiParent = this;
                fatura.Show();

            }
        }
        frmNotlar not;
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (not == null || not.IsDisposed)
            {
                not = new frmNotlar();
                not.MdiParent = this;
                not.Show();
            }

        }
        frmHareketler hareket;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (hareket == null || hareket.IsDisposed)
            {
                hareket = new frmHareketler();
                hareket.MdiParent = this;
                hareket.Show();
            }
        }
        frmStok stok;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stok == null || stok.IsDisposed)
            {
                stok = new frmStok();
                stok.MdiParent = this;
                stok.Show();
            }
          

        }
        frmAyar ay;

        private void A_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ay == null ||ay.IsDisposed)
            {
                ay = new frmAyar();
                ay.Show();

            }

        }
        frmKasa kasa;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null || kasa.IsDisposed)
            {
                
                kasa = new frmKasa();
                kasa.ad = kullanici;
                kasa.MdiParent = this;
                kasa.Show();
                
            }

        }
        public string kullanici;
        private void Home_Load(object sender, EventArgs e)
        {
            if (ana == null || ana.IsDisposed)
            {
                ana = new frmAnsayfa();
                ana.MdiParent = this;
                ana.Show();
            }
        }
        frmAnsayfa ana;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ana == null || ana.IsDisposed)
            {
                ana = new frmAnsayfa();
                ana.MdiParent = this;
                ana.Show();
            }

        }
    }
}

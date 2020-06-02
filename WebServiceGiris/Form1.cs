using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceGiris.ServiceReference;
using WebServiceGiris.tcknWebReference;

namespace WebServiceGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductWebService client = new ProductWebService();
            string msg = client.HelloWorld();
            MessageBox.Show(msg);
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            ProductWebService client = new ProductWebService();
            dgvListe.DataSource = client.ProductList();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            long tckn = Convert.ToInt64(txtTCKN.Text);
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int dogumYil = Convert.ToInt32(txtDogumYili.Text);
            KPSPublic client = new KPSPublic();
            bool sonuc = client.TCKimlikNoDogrula(tckn, ad, soyad, dogumYil);
            if (sonuc)
            {
                MessageBox.Show("Sistemde kayıtlı");
            }
            else
            {
                MessageBox.Show("Sistemde böyle bir kişi yok.");
            }
        }
    }
}

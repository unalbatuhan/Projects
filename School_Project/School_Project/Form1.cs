using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtToplam.Enabled = false;
        }
        double fiyat, adet, toplam,urunf;

        private void txtUrunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnKdv1_Click(object sender, EventArgs e)
        {
            fiyat = double.Parse(txtUrunFiyati.Text);
            adet = double.Parse(txtUrunAdet.Text);
            urunf = double.Parse(txtUrunFiyati.Text);
            toplam = fiyat * adet + urunf * adet * 1 / 100;
            txtToplam.Text = toplam.ToString();
        }

        private void btnKdv18_Click(object sender, EventArgs e)
        {
            fiyat = double.Parse(txtUrunFiyati.Text);
            adet = double.Parse(txtUrunAdet.Text);
            urunf = double.Parse(txtUrunFiyati.Text);
            toplam = fiyat *  adet + urunf *adet  * 18 / 100;
            txtToplam.Text = toplam.ToString();
        }

        private void btnUrunDetay_Click(object sender, EventArgs e)
        {
            
            txtUrunDetay.Text = "" + txtUrunAdi.Text + " ürününden " + txtUrunFiyati.Text + " TL fiyatından " + txtUrunAdet.Text + " tane alınmıştır. Toplam fiyat : " + txtToplam.Text + " TL";


        }

        private void txtUrunFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btnKdv8_Click(object sender, EventArgs e)
        {
            fiyat = double.Parse(txtUrunFiyati.Text);
            adet = double.Parse(txtUrunAdet.Text);
            urunf = double.Parse(txtUrunFiyati.Text);
            toplam = fiyat * adet + urunf * adet * 8 / 100;
            txtToplam.Text = toplam.ToString();

        }
    }
}

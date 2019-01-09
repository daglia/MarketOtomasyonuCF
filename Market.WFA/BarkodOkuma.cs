using Market.BLL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class BarkodOkuma : Form
    {
        public BarkodOkuma()
        {
            InitializeComponent();
        }

        private void BarkodOkuma_Load(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            Ean13Barcode2005.Ean13 barkod = new Ean13Barcode2005.Ean13();

            barkod.Height = 30f;
            barkod.Width = 70f;
            barkod.FontSize = 16f;
            //bu kod barkodun ilk 2 hanesi -ülke kodu
            barkod.CountryCode = "90";
            //Bu kod üretici-imalatçı numarası -bu kısımın legal illegal gibi durumları da var
            barkod.ManufacturerCode = "95525";
            //Bu kod ürün kodu
            barkod.ProductCode = UrunKodu();
            //Bu kısım boş geçilsede birşey değişmiyor EAN-13 te zaten 12 veri okuyorsunuz ,bu sayı  barkodun sonunda oluyor. kontrol kodu
            barkod.ChecksumDigit = "0";
            pbBarkod.Image = barkod.CreateBitmap();
            txtBarkod.Text = barkod.ToString();
            this.ActiveControl = txtBarkod;
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
        }
        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 10010);
            return sayi.ToString();
        }
        int kutuAdet;
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunBarkod == txtBarkod.Text);
                if (urun == null)
                {
                    string barkod = txtBarkod.Text;
                    kutuAdet = Convert.ToInt32(nudKutu.Value);
                    UrunIslemleri urunIslemleri = new UrunIslemleri();
                    urunIslemleri.Barkod(barkod, kutuAdet);
                    urunIslemleri.Show();
                }

                else urun.Kutu += kutuAdet;


                this.Close();
            }
        }
    }
}

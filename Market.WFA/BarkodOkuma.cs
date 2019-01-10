using Market.BLL.Repository;
using Market.Models.Entities;
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
        public string Barkod { get; set; }
        public int KutuAdet { get; set; }
        Urun urun;
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
            urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunBarkod == txtBarkod.Text);
            if (urun != null)
            {
                lblUrunAdi.Visible = true;
                lblUrunAdi.Text = "Gelen ürün: "+urun.UrunAdi;
                lblUrunAdi.Location = new Point((this.Width / 2)-5*(lblUrunAdi.Text.Length),lblUrunAdi.Location.Y);
            }
            this.ActiveControl = txtBarkod;
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;

        }
        private string UrunKodu()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 10005);
            return sayi.ToString();
        }
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (urun == null)
                {
                    Barkod = txtBarkod.Text;
                    KutuAdet = Convert.ToInt32(nudKutu.Value);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    var eskiStok = urun.Stok;
                    KutuAdet = Convert.ToInt32(nudKutu.Value);
                    urun.Kutu += KutuAdet;
                    new UrunRepo().Update();
                    MessageBox.Show($"{urun.UrunAdi} ekleme işlemi başarılı.\nEski stok: {eskiStok}\nYeni stok: {urun.Stok}");
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}

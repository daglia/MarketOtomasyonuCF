using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class UrunIslemleri : Form
    {
        public UrunIslemleri()
        {
            InitializeComponent();
        }
        public Urun Urun { get; set; }
        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            var kategoriler = new KategoriRepo().GetAll().ToList();
            cbKategori.DataSource = kategoriler;
            cbKategori.SelectedIndex = -1;
            if (Urun != null) UrunuGetir(Urun);
        }
        int kutuAdet;
        public void Barkod(string brk, int adet)
        {
            txtBarkodNo.Text = brk;
            kutuAdet = adet;

        }
        bool yeniUrunMu = true;
        public void UrunuGetir(Urun seciliUrun)
        {
            yeniUrunMu = false;
            txtBarkodNo.Text = seciliUrun.UrunBarkod;
            txtUrunAdi.Text = seciliUrun.UrunAdi;
            nudBirimFiyat.Value = seciliUrun.BirimFiyat;
            nudKutuBasinaAdet.Value = seciliUrun.KutuBasinaAdet;
            nudIndirim.Value = seciliUrun.Indirim;
            cbKategori.Text = seciliUrun.Kategori.KategoriAdi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (yeniUrunMu)
            {

                var secili = cbKategori.SelectedItem as Kategori;
                try
                {
                    new UrunRepo().Insert(new Urun()
                    {
                        UrunAdi = txtUrunAdi.Text,
                        BirimFiyat = nudBirimFiyat.Value,
                        KutuBasinaAdet = Convert.ToInt32(nudKutuBasinaAdet.Value),
                        UrunBarkod = txtBarkodNo.Text,
                        KategoriId = secili.KategoriId,
                        Stok = kutuAdet * Convert.ToInt32(nudKutuBasinaAdet.Value)
                    });

                    MessageBox.Show("Ürün kaydı başarılı");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    var seciliUrun = new UrunRepo().Queryable().First(x => x.UrunBarkod == txtBarkodNo.Text);
                    seciliUrun.UrunAdi = txtUrunAdi.Text;
                    seciliUrun.BirimFiyat = nudBirimFiyat.Value;
                    seciliUrun.KutuBasinaAdet = (int)nudKutuBasinaAdet.Value;
                    seciliUrun.Indirim = nudIndirim.Value;
                    seciliUrun.Kategori.KategoriAdi = (cbKategori.SelectedItem as Kategori).KategoriAdi;
                    new UrunRepo().Update();

                    MessageBox.Show("Ürün güncelleme başarılı");
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

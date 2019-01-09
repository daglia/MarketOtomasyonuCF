using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        private List<SatisDetayViewModel> satis = new List<SatisDetayViewModel>();

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            UrunleriGetir();
            SatislariGetir();
        }

        private void SatislariGetir()
        {
            lstSatis.Items.Clear();
            foreach (var _satis in satis)
            {
                lstSatis.Items.Add(_satis);
            }
        }

        private void UrunleriGetir()
        {
            var urunler = new UrunRepo().GetAll().ToList();
            lstUrunler.DataSource = urunler;
        }

        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoset.CheckState == CheckState.Checked)
            {
                nudPoset.Enabled = true;
                try
                {
                    
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else nudPoset.Enabled = false;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked == true) pnlNakit.Visible = true;
            else pnlNakit.Visible = false;
        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urun = lstUrunler.SelectedItem as Urun;
            txtBarkod.Text = new UrunRepo().GetById(urun.UrunId).UrunBarkod.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null || txtBarkod.Text == "") return;

            var seciliUrun = lstUrunler.SelectedItem as Urun;

            bool listedeMi = false;
            var listedekiUrun = new SatisDetayViewModel();
            foreach (var satisViewModel in satis)
            {
                if(seciliUrun.UrunId == satisViewModel.UrunId)
                {
                    listedeMi = true;
                    listedekiUrun = satisViewModel;
                    break;
                }
            }

            if (listedeMi) listedekiUrun.Adet += (int)nudAdet.Value;
            else
            {
                satis.Add(new SatisDetayViewModel()
                {
                    UrunId = seciliUrun.UrunId,
                    Indirim = seciliUrun.Indirim,
                    KDV = seciliUrun.Kategori.KDV,
                    Adet = (int)nudAdet.Value,
                    UrunAdi = seciliUrun.UrunAdi,
                    SatisFiyati = seciliUrun.BirimFiyat * (1 + seciliUrun.Kategori.KDV) * (1 - seciliUrun.Indirim)
                });
            }

            ToplamHesapla();
        }

        private decimal ToplamHesapla()
        {
            lstSatis.Items.Clear();
            foreach (var item in satis)
            {
                lstSatis.Items.Add(item);
            }
            var toplam = satis.Sum(x => x.SonFiyat);
            lblToplam.Text = $"{toplam:c2}";

            return toplam;
        }

        private void nudAlinanPara_ValueChanged(object sender, EventArgs e)
        {
            lblParaUstu.Text = (nudAlinanPara.Value - ToplamHesapla()).ToString("C2", CultureInfo.CurrentCulture);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstSatis.SelectedItem == null) return;

            var seciliSatis = lstSatis.SelectedItem as SatisViewModel;
            lstSatis.Items.Remove(seciliSatis);
            SatislariGetir();
        }

        private void btnIslemiBitir_Click(object sender, EventArgs e)
        {

        }
    }
}

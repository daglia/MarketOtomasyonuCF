using Market.BLL.Repository;
using Market.Models.Enums;
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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        private void Rapor_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;
            this.ControlBox = false;
            tabControl1.SelectedIndex = -1;

        }
        private void Rapor_Activated(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = -1;
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == -1) return;
            var secilitab = tabControl1.SelectedIndex;
            switch (secilitab)
            {
                case 0:
                    Stok();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    cmbYillar.Items.Clear();
                    dgvYillikSatislar.Columns.Clear();
                    for (int i = 2016; i <= 2019; i++)
                    {
                        cmbYillar.Items.Add(i.ToString());
                    }
                    if (cmbYillar.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen yıl seçiniz");
                        return;
                    }
                    break;
                case 4:
                    rbKrediKarti.Checked = false;
                    rbNakit.Checked = false;
                    dgvOdemeYontemi.Columns.Clear();
                    if (!(rbKrediKarti.Checked || rbNakit.Checked))
                    {
                        MessageBox.Show("Lütfen bir ödeme yöntemi seçin.");
                        return;
                    }
                    break;
                default:
                    break;
            }
        }
        private void Stok()
        {
            var urunler = new UrunRepo().GetAll();
            var kategoriler = new KategoriRepo().GetAll();
            var urunliste = from u in urunler
                            join k in kategoriler on u.KategoriId equals k.KategoriId
                            orderby k.KategoriAdi
                            select new
                            {
                                u.UrunBarkod,
                                k.KategoriAdi,
                                u.UrunAdi,
                                u.BirimFiyat,
                                u.Indirim,
                                u.KutuBasinaAdet,
                                u.Stok
                            };
            dgvStok.DataSource = urunliste.ToList();
        }
        public void GunlukSatislar()
        {

        }
        public void AylikSatislar()
        {

        }
        private void cmbYillar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliYil = Convert.ToInt32(cmbYillar.SelectedItem);
            YillikSatislar(seciliYil);
        }
        public void YillikSatislar(int yil)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            var yillikSatisListesi = from u in urunler
                                     join k in kategoriler on u.KategoriId equals k.KategoriId
                                     join sd in satisDetay on u.UrunId equals sd.UrunId
                                     join s in satis on sd.SatisId equals s.SatisId
                                     where s.SatisZamani.Year == yil
                                     group new
                                     {
                                         k,
                                         u,
                                         sd,
                                         s
                                     } by new
                                     {
                                         u.UrunBarkod,
                                         k.KategoriAdi,
                                         u.UrunAdi
                                     }
                                     into gp
                                     orderby gp.Key.KategoriAdi
                                     select new
                                     {
                                         gp.Key.UrunBarkod,
                                         gp.Key.KategoriAdi,
                                         gp.Key.UrunAdi,
                                         Toplam = gp.Sum(x => x.sd.Adet)
                                     };

            dgvYillikSatislar.DataSource = yillikSatisListesi.ToList();
        }
        private void rbNakit_CheckedChanged_1(object sender, EventArgs e)
        {
            var secilirb = OdemeYontemi.Nakit;
            OdemeYontemiGetir(secilirb);
        }

        private void rbKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            var secilirb = OdemeYontemi.KrediKartı;
            OdemeYontemiGetir(secilirb);
        }
        private void OdemeYontemiGetir(OdemeYontemi odeme)
        {
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urun = new UrunRepo().GetAll();

            var kksatisliste = from s in satis
                               join sd in satisDetay on s.SatisId equals sd.SatisId
                               join u in urun on sd.UrunId equals u.UrunId
                               where s.OdemeYontemi == odeme
                               select new
                               {
                                   s.SatisId,
                                   u.UrunAdi,
                                   sd.Adet,
                                   SatısZamanı = s.SatisZamani,
                                   OdemeYontemi = s.OdemeYontemi,
                               };
            dgvOdemeYontemi.DataSource = kksatisliste.ToList();
        }


    }
}

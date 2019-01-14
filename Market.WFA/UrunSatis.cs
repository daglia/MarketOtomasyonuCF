using iTextSharp.text;
using iTextSharp.text.pdf;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.Enums;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

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
            ListeyiTemizle();
        }

        private void ListeyiTemizle()
        {
            nudAdet.Value = 1;
            nudAlinanPara.Value = 0;
            nudPoset.Value = 0;
            txtBarkod.Clear();
            lstSatis.Items.Clear();
            cbPoset.CheckState = CheckState.Unchecked;
            rbNakit.Checked = false;
            rbKrediKarti.Checked = false;
            satis = new List<SatisDetayViewModel>();
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
                    satis.Add(new SatisDetayViewModel()
                    {
                        UrunId = 0,
                        UrunAdi = "Poşet",
                        Adet = (int)nudPoset.Value,
                        SatisFiyati = (decimal)0.25,
                        KDV = 0,
                        Indirim = 0
                    });
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else {
                nudPoset.Enabled = false;
                nudPoset.Value = 0;
                if(satis.Contains(satis.Find(x => x.UrunId.Equals(0))))
                    satis.Remove(satis.Find(x => x.UrunId.Equals(0)));
            }
            SatislariGetir();
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
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
        }

        private decimal ToplamHesapla()
        {
            lstSatis.Items.Clear();
            foreach (var item in satis)
            {
                lstSatis.Items.Add(item);
            }
            var toplam = satis.Sum(x => x.Toplam());
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

            var seciliSatis = lstSatis.SelectedItem as SatisDetayViewModel;
            satis.Remove(seciliSatis);
            SatislariGetir();
        }

        private void btnIslemiBitir_Click(object sender, EventArgs e)
        {
            var radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();
            if(!(rbNakit.Checked || rbKrediKarti.Checked))
            {
                MessageBox.Show("Lütfen önce bir ödeme yöntemi seçin.");
                return;
            }
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            try
            {
                var yeniSatis = new SatisRepo().Insert(new Satis()
                {
                    OdemeYontemi = (OdemeYontemi)selectedIndex,
                    SatisZamani = new SatisRepo().SatısTarihi()
                });

                foreach (var _satis in satis)
                {
                    if (_satis.UrunId == 0) continue;
                    new SatisDetayRepo().Insert(new SatisDetay()
                    {
                        SatisId = new SatisRepo()
                        .GetAll()
                        .Last()
                        .SatisId,
                        UrunId = _satis.UrunId,
                        Adet = _satis.Adet,
                        SatisFiyati = _satis.SatisFiyati
                    });
                    UrunRepo urun = new UrunRepo();
                    urun.GetById(_satis.UrunId).Stok -= _satis.Adet;
                    urun.Update();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A5.Rotate());
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();
                    var urunsatis = lstSatis.Items;

                        DateTime tarih = DateTime.Now;

                        iTextSharp.text.pdf.BaseFont Courier_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Courier", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

                        iTextSharp.text.Font font = new iTextSharp.text.Font(Courier_Turkish, 12, iTextSharp.text.Font.NORMAL);

                        doc.Add(new Paragraph("ZAF BIRLESIK MAGAZALAR A.S \nBesiktas/ISTANBUL \nKuloglu Mh., Barbaros Blv. Yıldız Is Hanı No:9",font));
                        doc.Add(new Paragraph($"\nFis No:{new SatisRepo().GetAll().Last().SatisId}\nTarih:{tarih.ToString("dd.MM.yyyy")}\n Saat:{tarih.ToString("HH:mm:ss")}",font));
                        doc.Add(new Paragraph("\nÜrün adı                        Adet    KDV    Fiyat\n",font));
                        foreach (var item in urunsatis)
                    {
                        doc.Add(new Paragraph(item.ToString(),font));
                    }
                        doc.Add(new Paragraph($"\nToplam : {lblToplam.Text:c2}",font));
                        if (rbNakit.Checked == true)
                        {
                            doc.Add(new Paragraph($"Alınan Miktar: {nudAlinanPara.Value.ToString()}\nPara Üstü:{lblParaUstu.Text:c2}",font));
                        }
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    doc.Close();
                }
            }

            MessageBox.Show("Satış başarılı");
            DialogResult = DialogResult.OK;
            ListeyiTemizle();
            SatislariGetir();
        }

        private void nudPoset_ValueChanged(object sender, EventArgs e)
        {
            SatisDetayViewModel poset = satis.Find(x => x.UrunId.Equals(0));
            poset.Adet = (int)nudPoset.Value;
            SatislariGetir();
            ToplamHesapla();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (lstUrunler.SelectedItem == null || txtBarkod.Text == "")
                {
                    MessageBox.Show("Lütfen listeden bir ürün seçin ya da barkodu girin.");
                    return;
                }

                var seciliUrun = lstUrunler.SelectedItem as Urun;

                if (seciliUrun.Stok == 0)
                {
                    MessageBox.Show("Ürünün stoğu yok!");
                    return;
                }

                if (nudAdet.Value > seciliUrun.Stok)
                {
                    MessageBox.Show("Stokta bu kadar ürün yok!");
                    return;
                }

                bool listedeMi = false;
                var listedekiUrun = new SatisDetayViewModel();
                foreach (var satisViewModel in satis)
                {
                    if (seciliUrun.UrunId == satisViewModel.UrunId)
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
                        KDV = new KategoriRepo().GetById(seciliUrun.KategoriId).KDV,
                        Adet = (int)nudAdet.Value,
                        UrunAdi = seciliUrun.UrunAdi,
                        SatisFiyati = seciliUrun.BirimFiyat * (1 + seciliUrun.Kategori.KDV + seciliUrun.Kategori.Kar) * (1 - seciliUrun.Indirim)
                    });
                }

                ToplamHesapla();
                nudAdet.Value = 1;
            }
        }

        private void nudAdet_ValueChanged(object sender, EventArgs e)
        {
            txtBarkod.Focus();
            txtBarkod.Select(0, 0);
            txtBarkod.SelectionStart = txtBarkod.MaxLength;
        }
    }
}

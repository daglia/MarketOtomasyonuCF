using Market.BLL.Repository;
using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            cmbYillar.SelectedIndex = -1;
            cmbAylar.SelectedIndex = -1;
            cmbYillarAylik.SelectedIndex = -1;
            dtpTarih.Value = DateTime.Now;
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
                    dtpTarih.Value = DateTime.Now;
                    GunlukSatislar(dtpTarih.Value);
                    break;
                case 2:
                    cmbYillarAylik.SelectedIndex = -1;
                    cmbAylar.SelectedIndex = -1;
                    dgvAylikSatislar.Columns.Clear();                    
                    if (cmbAylar.SelectedItem == null && cmbYillarAylik.SelectedItem==null)
                    {
                        //MessageBox.Show("Lütfen yıl ve ay seçiniz");
                        return;
                    }
                    break;
                case 3:
                    cmbYillar.SelectedIndex = -1;
                    dgvYillikSatislar.Columns.Clear();                    
                    if (cmbYillar.SelectedItem == null)
                    {
                        //MessageBox.Show("Lütfen yıl seçiniz");
                        return;
                    }
                    break;
                case 4:
                    rbKrediKarti.Checked = false;
                    rbNakit.Checked = false;
                    dgvOdemeYontemi.Columns.Clear();
                    if (!(rbKrediKarti.Checked || rbNakit.Checked))
                    {
                        //MessageBox.Show("Lütfen bir ödeme yöntemi seçin.");
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

            foreach (DataGridViewRow satir in dgvStok.Rows)
                if (Convert.ToInt32(satir.Cells[6].Value) < 100)
                {
                    satir.DefaultCellStyle.BackColor = Color.DarkSalmon;
                }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {          
           var tarih = dtpTarih.Value;
            GunlukSatislar(tarih);
        }
        public void GunlukSatislar(DateTime tarih)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            if (cbKategorilerGunluk.Checked)
            {
                var gunlukSatisListesi = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.ToShortDateString() == tarih.ToShortDateString()
                                         group new
                                         {
                                             k,
                                             sd,
                                             u,
                                             s
                                         } by new
                                         {
                                             k.KategoriAdi,
                                             k.Kar,
                                             k.KategoriId,
                                             u.BirimFiyat
                                         }
                                     into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.KategoriId,
                                             gp.Key.KategoriAdi,
                                             Toplam = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                         };
                dgvGunlukSatis.DataSource = gunlukSatisListesi.ToList();
            }
            else
            {
                var gunlukSatisListesi = from u in urunler
                                         join k in kategoriler on u.KategoriId equals k.KategoriId
                                         join sd in satisDetay on u.UrunId equals sd.UrunId
                                         join s in satis on sd.SatisId equals s.SatisId
                                         where s.SatisZamani.ToShortDateString() == tarih.ToShortDateString()
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
                                             u.UrunAdi,
                                             k.Kar,
                                             u.BirimFiyat,
                                             u.UrunId
                                         }
                                     into gp
                                         orderby gp.Key.UrunId
                                         select new
                                         {
                                             gp.Key.UrunId,
                                             gp.Key.UrunBarkod,
                                             gp.Key.UrunAdi,
                                             gp.Key.KategoriAdi,
                                             SatisAdedi = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                         };
                dgvGunlukSatis.DataSource = gunlukSatisListesi.ToList();
            }

            
        }
        private void cmbAylar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliYil = Convert.ToInt32(cmbYillarAylik.SelectedItem);
            if (cmbYillarAylik.SelectedItem == null)
            {
                if (cmbAylar.SelectedIndex != -1) {cmbAylar.SelectedIndex= -1;  return; }
                //MessageBox.Show("Lütfen önce yıl seçiniz");
                return;
            }         
            var seciliAy = Convert.ToInt32(cmbAylar.SelectedItem);    
            AylikSatislar(seciliAy,seciliYil);            
        }
        private void cmbYillarAylik_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAylikSatislar.Columns.Clear();
            cmbAylar.SelectedIndex = -1;
        }
        public void AylikSatislar(int ay,int yil)
        {
            var kategoriler = new KategoriRepo().GetAll();
            var satis = new SatisRepo().GetAll();
            var satisDetay = new SatisDetayRepo().GetAll();
            var urunler = new UrunRepo().GetAll();

            if (cbKategorilerAylik.Checked)
            {
                var aylikSatisListesi = from u in urunler
                                        join k in kategoriler on u.KategoriId equals k.KategoriId
                                        join sd in satisDetay on u.UrunId equals sd.UrunId
                                        join s in satis on sd.SatisId equals s.SatisId
                                        where s.SatisZamani.Month == ay && s.SatisZamani.Year == yil
                                        group new
                                        {
                                            k,
                                            u,
                                            sd,
                                            s
                                        } by new
                                        {
                                            k.KategoriId,
                                            k.KategoriAdi,
                                            u.BirimFiyat,
                                            k.Kar
                                        }
                                     into gp
                                        orderby gp.Key.KategoriId
                                        select new
                                        {
                                            gp.Key.KategoriId,
                                            gp.Key.KategoriAdi,
                                            ToplamAdet = gp.Sum(x => x.sd.Adet),
                                            ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                        };

                dgvAylikSatislar.DataSource = aylikSatisListesi.ToList();
            }
            else
            {
                var aylikSatisListesi = from u in urunler
                                        join k in kategoriler on u.KategoriId equals k.KategoriId
                                        join sd in satisDetay on u.UrunId equals sd.UrunId
                                        join s in satis on sd.SatisId equals s.SatisId
                                        where s.SatisZamani.Month == ay && s.SatisZamani.Year == yil
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
                                            u.UrunAdi,
                                            u.BirimFiyat,
                                            k.Kar
                                        }
                                     into gp
                                        orderby gp.Key.KategoriAdi
                                        select new
                                        {
                                            gp.Key.UrunBarkod,
                                            gp.Key.KategoriAdi,
                                            gp.Key.UrunAdi,
                                            Toplam = gp.Sum(x => x.sd.Adet),
                                            ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                        };

                dgvAylikSatislar.DataSource = aylikSatisListesi.ToList();
            }

            
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

            if (cbKategorilerYillik.Checked)
            {
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
                                             k.KategoriId,
                                             k.KategoriAdi,
                                             u.BirimFiyat,
                                             k.Kar
                                         }
                                     into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.KategoriId,
                                             gp.Key.KategoriAdi,
                                             Toplam = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                         };

                dgvYillikSatislar.DataSource = yillikSatisListesi.ToList();
            }
            else
            {
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
                                             u.UrunId,
                                             u.UrunBarkod,
                                             k.KategoriAdi,
                                             u.UrunAdi,
                                             u.BirimFiyat,
                                             k.Kar
                                         }
                                     into gp
                                         orderby gp.Key.KategoriAdi
                                         select new
                                         {
                                             gp.Key.UrunId,
                                             gp.Key.UrunBarkod,
                                             gp.Key.UrunAdi,
                                             Toplam = gp.Sum(x => x.sd.Adet),
                                             ToplamKar = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * gp.Key.Kar), 2)
                                         };

                dgvYillikSatislar.DataSource = yillikSatisListesi.ToList();
            }

            
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
            var kategoriler = new KategoriRepo().GetAll();

            var kksatisliste = from s in satis
                               join sd in satisDetay on s.SatisId equals sd.SatisId
                               join u in urun on sd.UrunId equals u.UrunId
                               join k in kategoriler on u.KategoriId equals k.KategoriId
                               where s.OdemeYontemi == odeme
                               group new
                               {
                                   s,
                                   sd,
                                   u,
                                   k
                               }
                               by new
                               {
                                   s.SatisId,
                                   s.SatisZamani,
                                   s.OdemeYontemi,
                                   u.BirimFiyat,
                                   k.Kar,
                                   k.KDV,
                                   sd.Adet,
                                   u.Indirim
                               }
                               into gp
                               orderby gp.Key.SatisId
                               select new
                               {
                                   gp.Key.SatisId,
                                   ToplamAdet = gp.Sum(x => x.sd.Adet),
                                   gp.Key.SatisZamani,
                                   gp.Key.OdemeYontemi,
                                   ToplamSatis = Math.Round((gp.Sum(x => x.sd.Adet) * gp.Key.BirimFiyat * (1+gp.Key.KDV) * gp.Key.Kar * (1-gp.Key.Indirim)), 2)
                               };
            dgvOdemeYontemi.DataSource = kksatisliste.ToList();
        }
        private void btnGunluk_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvGunlukSatis, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnStok_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvStok, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAylıkExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvAylikSatislar, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnYıllıkExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvYillikSatislar, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOdemeYontemi_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ToCsv(dgvOdemeYontemi, sfd.FileName);
                    MessageBox.Show("Excel e aktarma başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ToCsv(DataGridView dGv, string filename)
        {
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dGv.Columns.Count; j++)
            {
                sHeaders = sHeaders.ToString() + Convert.ToString(dGv.Columns[j].HeaderText) + "\t";
            }
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dGv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGv.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + Convert.ToString(dGv.Rows[i].Cells[j].Value) + "\t";
                }
                stOutput += stLine + "\r\n";
            }

            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}

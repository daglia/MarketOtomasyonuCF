using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.HazirData
{
    public class HazirData
    {
        public void VeriUret()
        {
            if (new KategoriRepo().GetAll().Any() || new UrunRepo().GetAll().Any()) return;

            KategoriUret();
            UrunUret();
            //SatisUret();
        }

        private void SatisUret()
        {
            throw new NotImplementedException();
        }

        private void UrunUret()
        {
            Urun urun = null;
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    switch (i)
                    {
                        case 0:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Ülker Çikolatalı Gofret",
                                BirimFiyat = 0.90m,
                                Kutu = 20,
                                KutuBasinaAdet = 200,
                                Indirim = 0.05m,
                                UrunBarkod = "8690504016700"
                            };
                            break;
                        case 1:
                            urun = new Urun()
                            {
                                KategoriId = 1,
                                UrunAdi = "Ankara Burgu Makarna 500 gr",
                                BirimFiyat = 1m,
                                Kutu = 20,
                                KutuBasinaAdet = 150,
                                Indirim = 0.00m,
                                UrunBarkod = "8690576029172"
                            };
                            break;
                        case 2:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Cif Krem Limon Kokulu Yüzey Temizleyicisi 750 ml",
                                BirimFiyat = 7m,
                                Kutu = 20,
                                KutuBasinaAdet = 180,
                                Indirim = 0.00m,
                                UrunBarkod = "8690637069840"
                            };
                            break;
                        case 3:
                            urun = new Urun()
                            {
                                KategoriId = 2,
                                UrunAdi = "Scotch-Brite 2'li Sünger",
                                BirimFiyat = 1.2m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8690734354764"
                            };
                            break;
                        case 4:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Piranha Kablosuz Kulaklık",
                                BirimFiyat = 30m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8698720989471"
                            };
                            break;
                        case 5:
                            urun = new Urun()
                            {
                                KategoriId = 3,
                                UrunAdi = "Golyat 3'lü Priz",
                                BirimFiyat = 20m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8680304700442"
                            };
                            break;
                        case 6:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Uykusuz",
                                BirimFiyat = 4m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "9771307761178"
                            };
                            break;
                        case 7:
                            urun = new Urun()
                            {
                                KategoriId = 4,
                                UrunAdi = "Bilim Çocuk",
                                BirimFiyat = 5m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "9771301746003"
                            };
                            break;
                        case 8:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "Faber Castell 6'lı Keçeli Kalem",
                                BirimFiyat = 8m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8690826232000"
                            };
                            break;
                        case 9:
                            urun = new Urun()
                            {
                                KategoriId = 5,
                                UrunAdi = "Mopak Defter 80 Sayfa",
                                BirimFiyat = 2m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8690830270135"
                            };
                            break;
                        case 10:
                            urun = new Urun()
                            {
                                KategoriId = 6,
                                UrunAdi = "Beyaz Ekmek",
                                BirimFiyat = 0.90m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.0m,
                                UrunBarkod = "8695077001207"
                            };
                            break;
                        case 11:
                            urun = new Urun()
                            {
                                KategoriId = 6,
                                UrunAdi = "Uno Kruvasan",
                                BirimFiyat = 5m,
                                Kutu = 20,
                                KutuBasinaAdet = 150,
                                Indirim = 0.00m,
                                UrunBarkod = "8690698503642"
                            };
                            break;
                        case 12:
                            urun = new Urun()
                            {
                                KategoriId = 7,
                                UrunAdi = "Pınar Mangal Keyfi Sucuk",
                                BirimFiyat = 15m,
                                Kutu = 20,
                                KutuBasinaAdet = 180,
                                Indirim = 0.10m,
                                UrunBarkod = "8690527021088"
                            };
                            break;
                        case 13:
                            urun = new Urun()
                            {
                                KategoriId = 7,
                                UrunAdi = "Şenpiliç Bütün Tavuk",
                                BirimFiyat = 13m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8696415042623"
                            };
                            break;
                        case 14:
                            urun = new Urun()
                            {
                                KategoriId = 8,
                                UrunAdi = "Gillette Blue3 Yedek Tıraş Bıçağı 6'lı",
                                BirimFiyat = 15m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "7702018037216"
                            };
                            break;
                        case 15:
                            urun = new Urun()
                            {
                                KategoriId = 8,
                                UrunAdi = "Nivea Krem 150 ml",
                                BirimFiyat = 10m,
                                Kutu = 25,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "4005800001192"
                            };
                            break;
                        case 16:
                            urun = new Urun()
                            {
                                KategoriId = 9,
                                UrunAdi = "Le Cola 2,5 L",
                                BirimFiyat = 2m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8695077305220"
                            };
                            break;
                        case 17:
                            urun = new Urun()
                            {
                                KategoriId = 9,
                                UrunAdi = "Le Porta 2,5 L",
                                BirimFiyat = 2m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8695077305221"
                            };
                            break;
                        case 18:
                            urun = new Urun()
                            {
                                KategoriId = 10,
                                UrunAdi = "6'lı Yünlü Çorap",
                                BirimFiyat = 12m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8690826232001"
                            };
                            break;
                        case 19:
                            urun = new Urun()
                            {
                                KategoriId = 10,
                                UrunAdi = "Beyaz Erkek İçlik",
                                BirimFiyat = 14m,
                                Kutu = 5,
                                KutuBasinaAdet = 200,
                                Indirim = 0.00m,
                                UrunBarkod = "8690830270136"
                            };
                            break;

                        default:
                            break;
                    }
                    new UrunRepo().Insert(urun);
                    urun = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void KategoriUret()
        {
            Kategori kategori = null;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    switch (i)
                    {
                        case 0:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Gıda Ürünleri",
                                Kar = (decimal)0.10,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 1:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Temizlik Ürünleri",
                                Kar = (decimal)0.10,
                                KDV = (decimal)0.18
                            };
                            break;
                        case 2:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Elektronik",
                                Kar = (decimal)0.20,
                                KDV = (decimal)0.25
                            };
                            break;
                        case 3:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Süreli Yayınlar",
                                Kar = (decimal)0.15,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 4:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Kırtasiye",
                                Kar = (decimal)0.20,
                                KDV = (decimal)0.18
                            };
                            break;
                        case 5:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Unlu Mamuller",
                                Kar = (decimal)0.15,
                                KDV = (decimal)0.01
                            };
                            break;
                        case 6:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Şarküteri",
                                Kar = (decimal)0.30,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 7:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Kişisel Bakım",
                                Kar = (decimal)0.30,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 8:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "İçecekler",
                                Kar = (decimal)0.20,
                                KDV = (decimal)0.08
                            };
                            break;
                        case 9:
                            kategori = new Kategori()
                            {
                                KategoriAdi = "Giyim",
                                Kar = (decimal)0.30,
                                KDV = (decimal)0.18
                            };
                            break;

                        default:
                            break;
                    }
                    new KategoriRepo().Insert(kategori);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class UrunViewModel
    {
        public int UrunId { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunAdi { get; set; }
        public int KutuBasinaAdet { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Kutu { get; set; }
        public int Stok
        {
            get => Kutu * KutuBasinaAdet;
            private set { }
        }

        public int KategoriId { get; set; }
        public override string ToString() => $"{UrunAdi} ({Stok})";
    }
}

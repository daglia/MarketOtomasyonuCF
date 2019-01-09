using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SatisDetayViewModel
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal SonFiyat {
            get => Adet * SatisFiyati;
            private set { }
        }
        public decimal KDV { get; set; }
        public decimal Indirim { get; set; }
        public int Adet { get; set; }
        public override string ToString() => $"{UrunAdi,-40} ⨯ {Adet,-6} %{KDV,-6} {SonFiyat:c2}";
    }
}

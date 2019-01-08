using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class KategoriViewModel
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public decimal KDV { get; set; }
       
        public decimal Kar { get; set; }

        public override string ToString() => $"{KategoriAdi}";
       


    }
}

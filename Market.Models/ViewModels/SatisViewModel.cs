using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class SatisViewModel
    {
        public int SatisId { get; set; }
        public DateTime SatisZamani { get; set; }
        public OdemeYontemi OdemeYontemi { get; set; }
    }
}

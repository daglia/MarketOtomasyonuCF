using Market.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis
    {
        [Key]
        public int SatisId { get; set; }
        public DateTime SatisZamani { get; set; } = DateTime.Now;
        public OdemeYontemi OdemeYontemi { get; set; }
        public virtual ICollection<SatisDetay> SatisDetaylari { get; set; } = new HashSet<SatisDetay>();
    }
}

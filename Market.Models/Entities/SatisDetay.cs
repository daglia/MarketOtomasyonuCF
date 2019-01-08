using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("SatisDetay")]
    public class SatisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SatisId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }
        [Required]
        public int Adet { get; set; }
        [ForeignKey("SatisId")]
        public virtual Satis Satis { get; set; }

        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [StringLength(20)]
        [Required]
        public string KategoriAdi { get; set; }

       
        [Required]
        public decimal KDV { get; set; }
        [Required]
        public decimal Kar { get; set; }

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
        public override string ToString() => $"{KategoriAdi}";
    }
}

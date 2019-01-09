using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int UrunId { get; set; }
        [Required]
        [StringLength(13)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Barkod sadece rakamlardan oluşmalıdır.")]
        public string UrunBarkod { get; set; }
        [Required]
        [StringLength(100)]
        public string UrunAdi { get; set; }
        [Required]
        public int KutuBasinaAdet { get; set; }
        [Required]
        public decimal BirimFiyat { get; set; }
        public decimal Indirim { get; set; } = 0;
        public int Kutu { get; set; } = 0;
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Stok
        {
            get => Kutu * KutuBasinaAdet;
            private set { }
        }

        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<SatisDetay> SatisDetaylari { get; set; } = new HashSet<SatisDetay>();

        public override string ToString() => $"{UrunAdi}";
    }
}

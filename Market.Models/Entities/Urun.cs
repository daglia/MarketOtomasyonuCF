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
        private static int _kutu, _kutuBasinaAdet;

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
        public int KutuBasinaAdet {
            get
            {
                return _kutuBasinaAdet;
            }
            set
            {
                _kutuBasinaAdet = value;
            }
        }
        [Required]
        public decimal BirimFiyat { get; set; }
        public decimal Indirim { get; set; } = 0;
        public int Kutu {
            get
            {
                return _kutu;
            }
            set
            {
                _kutu = value;
            }
        }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int Stok
        //{
        //    get => Kutu * KutuBasinaAdet;
        //    set { }
        //}

        public int Stok { get; set; } = _kutu * _kutuBasinaAdet;

        public int KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public virtual Kategori Kategori { get; set; }

        public virtual ICollection<SatisDetay> SatisDetaylari { get; set; } = new HashSet<SatisDetay>();

        public override string ToString() => $"{UrunAdi}";
    }
}

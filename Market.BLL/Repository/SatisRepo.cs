using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Repository
{
    public class SatisRepo : RepositoryBase<Satis,int>
    {
        public  DateTime SatısTarihi()
        {
            Random rnd = new Random();
            DateTime tarih = new DateTime(2016, 1, 1);
            int fark = (DateTime.Today - tarih).Days;
            return tarih.AddDays(rnd.Next(fark));
        }
    }
}

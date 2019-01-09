using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Repository
{
    public class SatisDetayRepo : RepositoryBase<SatisDetay,int>
    {
        public override List<SatisDetay> GetAll()
        {
            return base.GetAll();
        }
        public override int Insert(SatisDetay entity)
        {
            try
            {
                var satisDetay = db.SatisDetaylari.Find(entity.SatisId);
                return base.Insert(satisDetay);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

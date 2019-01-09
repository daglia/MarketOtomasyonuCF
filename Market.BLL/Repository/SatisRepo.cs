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
        public override List<Satis> GetAll()
        {
            return base.GetAll();
        }

        public override int Insert(Satis entity)
        {
            try
            {
                var satis = db.Satislar.Find(entity.SatisId);
                return base.Insert(satis);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}

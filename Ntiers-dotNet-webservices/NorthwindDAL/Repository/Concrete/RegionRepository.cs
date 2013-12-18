using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Repository.Concrete
{
    public class RegionRepository : Repository<Region>
    {
        public override Region FindById(object id)
        {
            if (id is Int32)
                return FindAll().FirstOrDefault(r => r.RegionID == (Int32)id);

            return null;
        }

        public override Region FindByEntity(Region entity)
        {
            return FindById(entity.RegionID);
        }
    }
}

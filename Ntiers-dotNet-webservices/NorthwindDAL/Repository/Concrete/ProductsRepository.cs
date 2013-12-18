using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Repository.Concrete
{
    public class ProductsRepository : Repository<Products>
    {
        public override Products FindById(object id)
        {
            if (id is Int32)
                return FindAll().FirstOrDefault(p => p.ProductID == (Int32)id);

            return null;
        }

        public override Products FindByEntity(Products entity)
        {
            return FindById(entity.ProductID);
        }
    }
}

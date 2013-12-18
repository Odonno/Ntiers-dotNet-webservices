using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL.Infrastructure;

namespace NorthwindDAL.Repository.Concrete
{
    public class CategoriesRepository : Repository<Categories>
    {
        public override Categories FindById(object id)
        {
            if (id is Int32)
                return FindAll().FirstOrDefault(c => c.CategoryID == (Int32) id);

            return null;
        }

        public override Categories FindByEntity(Categories entity)
        {
            return FindById(entity.CategoryID);
        }
    }
}

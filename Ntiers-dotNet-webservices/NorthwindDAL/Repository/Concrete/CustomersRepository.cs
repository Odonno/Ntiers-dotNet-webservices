using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL.Infrastructure;

namespace NorthwindDAL.Repository.Concrete
{
    public class CustomersRepository : Repository<Customers>
    {
        public override Customers FindById(object id)
        {
            var s = id as String;

            if (s != null && !String.IsNullOrWhiteSpace(s))
                return FindAll().FirstOrDefault(c => c.CustomerID == s);

            return null;
        }

        public override Customers FindByEntity(Customers entity)
        {
            return FindById(entity.CustomerID);
        }
    }
}

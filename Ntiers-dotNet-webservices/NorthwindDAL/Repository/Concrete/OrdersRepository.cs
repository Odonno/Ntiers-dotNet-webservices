using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL.Infrastructure;

namespace NorthwindDAL.Repository.Concrete
{
    public class OrdersRepository : Repository<Orders> 
    {
        public override Orders FindById(object id)
        {
            if (id is Int32)
                return FindAll().FirstOrDefault(o => o.OrderID == (Int32)id);

            return null;
        }

        public override Orders FindByEntity(Orders entity)
        {
            return FindById(entity.OrderID);
        }
    }
}

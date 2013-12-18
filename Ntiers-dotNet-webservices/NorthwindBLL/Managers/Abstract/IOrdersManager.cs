using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindBLL.Managers.Abstract
{
    public interface IOrdersManager
    {
        int OrderCount();

        Orders Order(Int32 orderID);

        IEnumerable<Orders> Orders();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindBLL.Managers.Abstract
{
    public interface ICustomersManager
    {
        Int32 CustomerCount();

        Customers Customer(String customerID);

        IEnumerable<Customers> Customers();
    }
}

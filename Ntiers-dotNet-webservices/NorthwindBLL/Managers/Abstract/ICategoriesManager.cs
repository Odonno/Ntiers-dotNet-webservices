using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindBLL.Managers.Abstract
{
    public interface ICategoriesManager
    {
        IEnumerable<Categories> Categories();
    }
}

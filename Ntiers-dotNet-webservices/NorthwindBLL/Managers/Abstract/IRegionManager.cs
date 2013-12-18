using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindBLL.Managers.Abstract
{
    public interface IRegionManager
    {
        IEnumerable<Region> Regions();
    }
}

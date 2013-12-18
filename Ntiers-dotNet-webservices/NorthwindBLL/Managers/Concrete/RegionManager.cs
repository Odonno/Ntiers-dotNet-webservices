using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindDAL.Repository.Abstract;

namespace NorthwindBLL.Managers.Concrete
{
    public class RegionManager : IRegionManager
    {
        private readonly IRepository<Region> _regionRepository;

        public RegionManager(IRepository<Region> regionRepository)
        {
            _regionRepository = regionRepository;
        }




        public IEnumerable<Region> Regions()
        {
            return _regionRepository.FindAll().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindDAL.Repository.Abstract;
using NorthwindDAL.Repository.Concrete;

namespace NorthwindBLL.Managers.Concrete
{
    public class CategoriesManager : ICategoriesManager
    {
        private readonly IRepository<Categories> _categoriesRepository;

        public CategoriesManager(IRepository<Categories> categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }




        public IEnumerable<Categories> Categories()
        {
            return _categoriesRepository.FindAll().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using NorthwindDAL;
using NorthwindDAL.Repository.Abstract;
using NorthwindDAL.Repository.Concrete;

namespace NorthwindBLL.Infrastructure
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            // repository bindings
            Bind<IRepository<Customers>>().To<CustomersRepository>();
            Bind<IRepository<Products>>().To<ProductsRepository>();
            Bind<IRepository<Orders>>().To<OrdersRepository>();
            Bind<IRepository<Categories>>().To<CategoriesRepository>();
            Bind<IRepository<Region>>().To<RegionRepository>();
        }
    }
}

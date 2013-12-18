using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication.Infrastructure;
using MvcApplication.MyNorthwindCategorieService;
using MvcApplication.MyNorthwindCustomerService;
using MvcApplication.MyNorthwindGeneralService;
using MvcApplication.MyNorthwindOrderService;
using MvcApplication.MyNorthwindProductService;
using MvcApplication.MyNorthwindRegionService;
using Ninject;

namespace MvcApplication
{
    // Remarque : pour obtenir des instructions sur l'activation du mode classique IIS6 ou IIS7, 
    // visitez http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            IKernel kernel = new StandardKernel();
            RegisterServices(kernel);

            // create resolver for MVC controller
            var ninjectDependencyResolver = new NinjectDependencyResolver(kernel);
            DependencyResolver.SetResolver(ninjectDependencyResolver);
        }


        private static void RegisterServices(IKernel kernel)
        {
            // This is where we tell Ninject how to resolve service requests
            kernel.Bind<ICustomerService>().To<CustomerServiceClient>();
            kernel.Bind<IProductService>().To<ProductServiceClient>();
            kernel.Bind<IGeneralService>().To<GeneralServiceClient>();
            kernel.Bind<IOrderService>().To<OrderServiceClient>();
            kernel.Bind<ICategorieService>().To<CategorieServiceClient>();
            kernel.Bind<IRegionService>().To<RegionServiceClient>();
        }
    }
}
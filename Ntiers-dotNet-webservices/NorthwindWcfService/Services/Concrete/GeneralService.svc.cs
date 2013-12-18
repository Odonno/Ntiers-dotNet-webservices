using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindBLL.Managers.Abstract;
using NorthwindWcfService.Services.Abstract;

namespace NorthwindWcfService.Services.Concrete
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "GeneralService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez GeneralService.svc ou GeneralService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class GeneralService : IGeneralService
    {
        private readonly ICustomersManager _customersManager;
        private readonly IProductsManager _productsManager;

        public GeneralService(ICustomersManager customersManager, IProductsManager productsManager)
        {
            _customersManager = customersManager;
            _productsManager = productsManager;
        }


        public Int32 GetCustomerCount()
        {
            return _customersManager.CustomerCount();
        }

        public Int32 GetProductCount()
        {
            return _productsManager.ProductCount(); ;
        }
    }
}

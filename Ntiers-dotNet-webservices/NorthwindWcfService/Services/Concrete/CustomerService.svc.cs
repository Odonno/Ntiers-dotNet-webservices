using System;
using System.Collections.Generic;
using NorthwindBLL;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindWcfService.Services.Abstract;

namespace NorthwindWcfService.Services.Concrete
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CustomerService" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CustomerService.svc ou CustomerService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CustomerService : ICustomerService
    {
        private readonly ICustomersManager _customersManager;

        public CustomerService(ICustomersManager customersManager)
        {
            _customersManager = customersManager;
        }

        public Customers GetCustomer(String customerID)
        {
            return _customersManager.Customer(customerID);
        }

        public IEnumerable<Customers> GetCustomers()
        {
            return _customersManager.Customers();
        }
    }
}

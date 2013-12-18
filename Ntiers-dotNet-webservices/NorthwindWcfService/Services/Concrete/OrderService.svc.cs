using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindWcfService.Services.Abstract;

namespace NorthwindWcfService.Services.Concrete
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "OrderService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez OrderService.svc ou OrderService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class OrderService : IOrderService
    {
        private readonly IOrdersManager _ordersManager;

        public OrderService(IOrdersManager ordersManager)
        {
            _ordersManager = ordersManager;
        }


        public Orders GetOrder(int orderID)
        {
            return _ordersManager.Order(orderID);
        }
        public IEnumerable<Orders> GetOrders()
        {
            return _ordersManager.Orders();
        }
    }
}

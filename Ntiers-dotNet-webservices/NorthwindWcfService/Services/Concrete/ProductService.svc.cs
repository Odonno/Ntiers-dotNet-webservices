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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ProductService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez ProductService.svc ou ProductService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ProductService : IProductService
    {
        private readonly IProductsManager _productsManager;

        public ProductService(IProductsManager productsManager)
        {
            _productsManager = productsManager;
        }



        public Products GetProduct(Int32 productID)
        {
            return _productsManager.Product(productID);
        }

        public IEnumerable<Products> GetProducts()
        {
            return _productsManager.Products();
        }

        public void AddProduct(Products products)
        {
            _productsManager.AddProduct(products);
        }

        public void RemoveProduct(int productID)
        {
            _productsManager.RemoveProduct(productID);
        }
    }
}

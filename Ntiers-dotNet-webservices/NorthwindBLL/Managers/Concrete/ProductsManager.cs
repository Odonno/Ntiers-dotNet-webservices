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
    public class ProductsManager : IProductsManager
    {
        private readonly IRepository<Products> _productsRepository;

        public ProductsManager(IRepository<Products> productsRepository)
        {
            _productsRepository = productsRepository;
        }




        public int ProductCount()
        {
            return _productsRepository.FindAll().Count();
        }

        public Products Product(Int32 productID)
        {
            return _productsRepository.FindById(productID);
        }

        public IEnumerable<Products> Products()
        {
            return _productsRepository.FindAll().ToList();
        }

        public void AddProduct(Products products)
        {
            _productsRepository.Add(products);
        }

        public void RemoveProduct(Int32 productID)
        {
            _productsRepository.Remove(Product(productID));
        }
    }
}

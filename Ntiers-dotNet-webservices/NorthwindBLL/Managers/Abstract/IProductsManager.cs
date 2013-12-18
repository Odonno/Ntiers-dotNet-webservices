using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindDAL;

namespace NorthwindBLL.Managers.Abstract
{
    public interface IProductsManager
    {
        Int32 ProductCount();

        IEnumerable<Products> Products();

        Products Product(Int32 productID);

        void AddProduct(Products products);

        void RemoveProduct(Int32 ProductID);
    }
}

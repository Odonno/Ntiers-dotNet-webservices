using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindDAL.Repository.Abstract;

namespace NorthwindBLL.Managers.Concrete
{
    public class OrdersManager : IOrdersManager
    {
        private readonly IRepository<Orders> _ordersRepository;

        public OrdersManager(IRepository<Orders> ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }




        public int OrderCount()
        {
            return _ordersRepository.FindAll().Count();
        }

        public Orders Order(Int32 orderID)
        {
            return _ordersRepository.FindById(orderID);
        }

        public IEnumerable<Orders> Orders()
        {
            return _ordersRepository.FindAll().OrderByDescending(o => o.OrderDate).Take(20);
        }
    }
}

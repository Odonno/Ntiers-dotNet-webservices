using System;
using System.Collections.Generic;
using System.Linq;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindDAL.Repository.Abstract;

namespace NorthwindBLL.Managers.Concrete
{
    public class CustomersManager : ICustomersManager
    {
        private readonly IRepository<Customers> _customersRepository;

        public CustomersManager(IRepository<Customers> customersRepository)
        {
            _customersRepository = customersRepository;
        }



        public Int32 CustomerCount()
        {
            return _customersRepository.FindAll().Count();
        }

        public Customers Customer(String customerID)
        {
            return _customersRepository.FindById(customerID);
        }

        public IEnumerable<Customers> Customers()
        {
            return _customersRepository.FindAll().ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.MyNorthwindCustomerService;

namespace MvcApplication.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }




        //
        // GET: /Customer/

        public ActionResult Index()
        {
            IEnumerable<Customers> customers = _customerService.GetCustomers();
            return View(customers);
        }

        //
        // GET: /Customer/Details/5

        public ActionResult Details(String id)
        {
            Customers customer = _customerService.GetCustomer(id);
            return View(customer);
        }

        //
        // GET: /Customer/Create

        /*public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Customer/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Customer/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Customer/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Customer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/
    }
}

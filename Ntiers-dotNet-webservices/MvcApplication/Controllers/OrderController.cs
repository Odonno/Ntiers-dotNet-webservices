using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.MyNorthwindOrderService;

namespace MvcApplication.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }




        //
        // GET: /Order/

        public ActionResult Index()
        {
            IEnumerable<Orders> orders = _orderService.GetOrders();
            return View(orders);
        }

        //
        // GET: /Order/Details/5

        public ActionResult Details(int id)
        {
            Orders order = _orderService.GetOrder(id);
            return View(order);
        }

        //
        // GET: /Order/Create

        /*public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order/Create

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
        // GET: /Order/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Order/Edit/5

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
        // GET: /Order/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Order/Delete/5

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

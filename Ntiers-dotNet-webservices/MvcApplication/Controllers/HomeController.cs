using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.MyNorthwindGeneralService;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private Random random;
        private readonly IGeneralService _generalService;

        public HomeController(IGeneralService generalService)
        {
            random = new Random();
            _generalService = generalService;
        }



        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.RandomNumber = random.Next(1, 100);

            var counts =
                new
                {
                    CustomerCount = _generalService.GetCustomerCount(),
                    ProductCount = _generalService.GetProductCount()
                };

            ViewBag.CustomerCount = counts.CustomerCount;
            ViewBag.ProductCount = counts.ProductCount;

            return View();
        }

        //
        // GET: /Home/Details/5

        /*public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

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
        // GET: /Home/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Home/Edit/5

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
        // GET: /Home/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Home/Delete/5

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

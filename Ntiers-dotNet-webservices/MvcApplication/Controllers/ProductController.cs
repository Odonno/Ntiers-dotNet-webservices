using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.MyNorthwindProductService;

namespace MvcApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }



        //
        // GET: /Product/

        public ActionResult Index()
        {
            IEnumerable<Products> products = _productService.GetProducts();
            return View(products);
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(Int32 id)
        {
            Products product = _productService.GetProduct(id);
            return View(product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        public ActionResult Create(Products products)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _productService.AddProduct(products);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.AddModelError("", "We cannot add this product. Verify your data entries !");
            }

            return View(products);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id)
        {
            Products product = _productService.GetProduct(id);
            return View(product);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Products products)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    products.ProductID = id;
                    _productService.AddProduct(products);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }

            return View();
        }

        //
        // GET: /Product/Delete/5

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Product/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, Products products)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //        _productService.RemoveProduct(id);

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}



        //
        // AJAX: /Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _productService.RemoveProduct(id);

            var results = new
            {
                DeleteId = id
            };

            return Json(results);
        }
    }
}

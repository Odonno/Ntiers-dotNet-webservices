using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.MyNorthwindCategorieService;

namespace MvcApplication.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ICategorieService _categorieService;

        public CategorieController(ICategorieService categorieService)
        {
            _categorieService = categorieService;
        }


        //
        // GET: /Categorie/

        public ActionResult Index()
        {
            IEnumerable<Categories> categories = _categorieService.GetCategories();
            return View(categories);
        }

        //
        // GET: /Categorie/Details/5

        /*public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Categorie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Categorie/Create

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
        // GET: /Categorie/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Categorie/Edit/5

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
        // GET: /Categorie/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Categorie/Delete/5

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

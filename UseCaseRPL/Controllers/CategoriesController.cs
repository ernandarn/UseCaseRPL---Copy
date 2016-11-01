using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using UseCaseRPL.DAL;
using UseCaseRPL.Models;

namespace UseCaseRPL.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            CategoriesDAL catDal = new CategoriesDAL();
            var models = catDal.GetAll();

            return View(models);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                CategoriesDAL catDal = new CategoriesDAL();
                catDal.Create(category);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }


        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            CategoriesDAL categoriesDAL = new CategoriesDAL();
            var model = categoriesDAL.GetById(id);

            return View(model);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CategoriesDAL categoriesDAL = new CategoriesDAL();
                    categoriesDAL.Update(category);

                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            CategoriesDAL categoriesDAL = new CategoriesDAL();
            var model = categoriesDAL.GetById(id);
            return View(model);
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            try
            {
                CategoriesDAL categoriesDAL = new CategoriesDAL();
                categoriesDAL.Delete(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Search(string txtSearch)
        {
            using (CategoriesDAL cat = new CategoriesDAL())
            {
                var results = cat.SearchCat(txtSearch).ToList();
                return View("Index", results);
            }
        }

    }
}
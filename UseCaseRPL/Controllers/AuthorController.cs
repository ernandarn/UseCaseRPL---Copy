﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UseCaseRPL.DAL;
using UseCaseRPL.Models;
using System.Net;

namespace UseCaseRPL.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            AuthorsDAL autDAL = new AuthorsDAL();
            var model = autDAL.getAll();
            return View(model);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        [HttpPost]
        public ActionResult Create(Author author)
        {
            using (AuthorsDAL service = new AuthorsDAL())
            {
                try
                {
                    service.Create(author);
                   // TempData["Pesan"] = Helpers.Pesan.getPesan("Sukses !", "Sukses", "Data Author " + author.FirstName + " berhasil ditambah");
                    TempData["Pesan"] = Helpers.Pesan.getPesan("Success!", "success", "Data author " + author.FirstName + " berhasil di tambah");
                }
                catch (Exception ex)
                {
                    TempData["Pesan"] = Helpers.Pesan.getPesan("Error!", "danger", ex.Message);
                   // throw new Exception();
                }

            }
            return RedirectToAction("Index");
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            using (AuthorsDAL service = new AuthorsDAL())
            {
                var author = service.GetByID(id);
                return View(author);
            }
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            using (AuthorsDAL service = new AuthorsDAL())
            {
                //    try
                //    {
                //        service.Edit(id);
                //        TempData["Pesan"] = Helpers.KotakPesan.getPesan("Success!", "success", "Data " + author.FirstName + " successfully changed");
                //    }
                //    catch (Exception ex)
                //    {

                //        TempData["Pesan"] = Helpers.KotakPesan.getPesan("Error!", "danger", ex.Message);
                //    }

                //}
                //return RedirectToAction("Index");
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
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
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
        }
    }
}

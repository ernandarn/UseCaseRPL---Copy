﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UseCaseRPL.Controllers
{
    public class PelangganController : Controller
    {
        // GET: Pelanggan
        public ActionResult Index()
        {
            ViewBag.nama_pel = "Ernanda Rully";
            return View();
        }

        // GET: Pelanggan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pelanggan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pelanggan/Create
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

        // GET: Pelanggan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pelanggan/Edit/5
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

        // GET: Pelanggan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pelanggan/Delete/5
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

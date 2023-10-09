﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto1.Models;

namespace Proyecto1.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: EmpleadoControllet
        public ActionResult Index()
        {
            List<Empleado> empleados = Cache.GetAllEmpleados();
            return View(empleados);
        }

        // GET: EmpleadoControllet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmpleadoControllet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoControllet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoControllet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmpleadoControllet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoControllet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmpleadoControllet/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
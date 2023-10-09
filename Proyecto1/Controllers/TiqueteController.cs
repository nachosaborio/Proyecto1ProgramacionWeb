using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto1.Controllers
{
    public class TiqueteController : Controller
    {
        // GET: TiqueteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TiqueteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TiqueteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiqueteController/Create
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

        // GET: TiqueteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TiqueteController/Edit/5
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

        // GET: TiqueteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TiqueteController/Delete/5
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

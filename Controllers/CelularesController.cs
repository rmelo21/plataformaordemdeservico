using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class CelularesController : Controller
    {
        // GET: CelularesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CelularesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CelularesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CelularesController/Create
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

        // GET: CelularesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CelularesController/Edit/5
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

        // GET: CelularesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CelularesController/Delete/5
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

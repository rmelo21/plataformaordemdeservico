using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class MonitoresController : Controller
    {
        // GET: MonitoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MonitoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonitoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonitoresController/Create
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

        // GET: MonitoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonitoresController/Edit/5
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

        // GET: MonitoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonitoresController/Delete/5
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

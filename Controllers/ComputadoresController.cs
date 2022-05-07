using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class ComputadoresController : Controller
    {
        // GET: ComputadoresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ComputadoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ComputadoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComputadoresController/Create
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

        // GET: ComputadoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ComputadoresController/Edit/5
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

        // GET: ComputadoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ComputadoresController/Delete/5
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

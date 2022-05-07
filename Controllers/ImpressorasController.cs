using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class ImpressorasController : Controller
    {
        // GET: ImpressorasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImpressorasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImpressorasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImpressorasController/Create
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

        // GET: ImpressorasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ImpressorasController/Edit/5
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

        // GET: ImpressorasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ImpressorasController/Delete/5
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

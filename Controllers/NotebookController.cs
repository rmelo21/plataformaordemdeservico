using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class NotebookController : Controller
    {
        // GET: NotebookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotebookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotebookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotebookController/Create
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

        // GET: NotebookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotebookController/Edit/5
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

        // GET: NotebookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotebookController/Delete/5
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

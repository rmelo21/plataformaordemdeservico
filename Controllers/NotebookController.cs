using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using plataformaordemdeservico.Entidades;

namespace plataformaordemdeservico.Controllers
{
    public class NotebookController : Controller
    {
        private readonly Contexto db;

        public NotebookController(Contexto contexto)
        {
            db = contexto;
        }

        //public static List<Notebook> lsnotebook = new List<Notebook>();

        // GET: NotebookController
        public ActionResult IndexNotebook()
        {
            return View();
        }

        // GET: NotebookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotebookController/Create
        public ActionResult CreateNotebook()
        {
            return View();
        }

        // POST: NotebookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNotebook(NotebookDb notebook)
        {
            db.DSNotebook.Add(notebook);
            return RedirectToAction("Ver pra onde vai voltar");
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

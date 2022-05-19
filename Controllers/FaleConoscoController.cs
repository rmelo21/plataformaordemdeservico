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
    public class FaleConoscoController : Controller
    {

        private readonly Contexto db;

        public FaleConoscoController(Contexto contexto)
        {
            db = contexto;
        }

        //public static List<FaleConosco> lsfaleconosco = new List<FaleConosco>();

        // GET: FaleConoscoController
        public ActionResult IndexFaleConosco()
        {
            return View();
        }

        // GET: FaleConoscoController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: FaleConoscoController/Create
        public ActionResult CreateFaleConosco()
        {
            return View();
        }

        // POST: FaleConoscoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFaleConosco(FaleConoscoDb faleConosco)
        {
            db.DSFaleConosco.Add(faleConosco);
            return RedirectToAction("Ver pra onde vai voltar");

        }

        // GET: FaleConoscoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FaleConoscoController/Edit/5
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

        // GET: FaleConoscoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FaleConoscoController/Delete/5
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

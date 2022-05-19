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
    public class ImpressorasController : Controller
    {
        private readonly Contexto db;

        public ImpressorasController(Contexto contexto)
        {
            db = contexto;
        }

        //public static List<Impressoras> lsimpressoras = new List<Impressoras>();

        // GET: ImpressorasController
        public ActionResult IndexImpressoras()
        {
            return View();
        }

        // GET: ImpressorasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImpressorasController/Create
        public ActionResult CreateImpressoras()
        {
            return View();
        }

        // POST: ImpressorasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateImpressoras(ImpressorasDb impressoras)
        {
            db.DSImpressoras.Add(impressoras);
            return RedirectToAction("ver pra onde vai voltar");
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

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
    public class MonitoresController : Controller
    {
        private readonly Contexto db;

        public MonitoresController(Contexto contexto)
        {
            db = contexto;
        }

        //public static List<Monitores> lsmonitores = new List<Monitores>();

        // GET: MonitoresController
        public ActionResult IndexMonitores()
        {
            return View();
        }

        // GET: MonitoresController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: MonitoresController/Create
        public ActionResult CreateMonitores()
        {
            return View();
        }

        // POST: MonitoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMonitores(MonitoresDb monitores)
        {
            db.DSMonitores.Add(monitores);
            return RedirectToAction("ver pra onde vai voltar");
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

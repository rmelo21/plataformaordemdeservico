using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class ComputadoresController : Controller
    {

        public static List<Computadores> lscomputadores = new List<Computadores>();

        // GET: ComputadoresController
        public ActionResult IndexComputadores()
        {
            return View(lscomputadores);
        }

        // GET: ComputadoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ComputadoresController/Create
        public ActionResult CreateComputadores()
        {
            return View();
        }

        // POST: ComputadoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateComputadores(Computadores computadores)
        {
            lscomputadores.Add(computadores);
            return RedirectToAction("Ver pra onde vai voltar");

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

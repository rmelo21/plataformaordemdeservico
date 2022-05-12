﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class CelularesController : Controller
    {

        public static List<Celulares> lscelulares = new List<Celulares>();

        // GET: CelularesController
        public IActionResult IndexCelulares()
        {
            return View(lscelulares);
        }

        // GET: CelularesController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: CelularesController/Create
        public IActionResult CreateCelulares()
        {
            return View();
        }

        // POST: CelularesController/Create
        [HttpPost]
        
        public IActionResult CreateCelulares(Celulares celulures)
        {
            lscelulares.Add(celulures);
            return RedirectToAction("Ver pra onde vai voltar");
        }

        // GET: CelularesController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: CelularesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: CelularesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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

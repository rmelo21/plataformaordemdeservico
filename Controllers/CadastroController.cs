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
    public class CadastroController : Controller
    {

        private readonly Contexto db;

        public CadastroController(Contexto contexto)
        {
            db = contexto; 
        }


        // GET: CadastroController
        public IActionResult IndexCadastro()
        {
            //return View(lscadastro);
            return View();
        }

        // GET: CadastroController/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: CadastroController/Create
        public IActionResult CreateCadastro()
        {

            return View();
        }

        // POST: CadastroController/Create
        [HttpPost]
       
        public IActionResult CreateCadastro(CadastroDb cadastro)
        {
            //lscadastro.Add(cadastro);
            // return RedirectToAction("Ver pra onde vai voltar");
            db.DSCadastroCliente.Add(cadastro);
            db.SaveChanges();
            return RedirectToAction("Ver pra onde vai voltar");

        }


        // GET: CadastroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CadastroController/Edit/5
        [HttpPost]
        
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

        // GET: CadastroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CadastroController/Delete/5
        [HttpPost]
       
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

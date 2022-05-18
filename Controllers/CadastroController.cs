using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class CadastroController : Controller
    {

        private readonly Contexto db;

        public CadastroController(Contexto contexto)
        {
            db = contexto; 
        }


        //public static List<Cadastro> lscadastro = new List<Cadastro>();



        // GET: CadastroController
        public IActionResult IndexCadastro()
        {
            //return View(lscadastro);
            return View(db.DSCadastroCliente.ToList());
        }

        // GET: CadastroController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.DSCadastroCliente.ToList());
        }

        // GET: CadastroController/Create
        public IActionResult CreateCadastro()
        {

            return View();
        }

        // POST: CadastroController/Create
        [HttpPost]
       
        public IActionResult CreateCadastro(DSCadastroCliente cadastro)
        {
            //lscadastro.Add(cadastro);
            // return RedirectToAction("Ver pra onde vai voltar");
            db.DSCadastroCliente.Add(cadastro);
            db.SaveChanges();
           
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

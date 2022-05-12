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


        public static List<Cadastro> lscadastro = new List<Cadastro>();



        // GET: CadastroController
        public IActionResult IndexCadastro()
        {
            return View(lscadastro);
        }

        // GET: CadastroController/Details/5
        public ActionResult Details(int id)
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
       
        public IActionResult CreateCadastro(Cadastro cadastro)
        {
            lscadastro.Add(cadastro);
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

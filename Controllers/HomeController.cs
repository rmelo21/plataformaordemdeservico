using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Notebook()
        {
            return View();
        }

        public IActionResult Computadores()
        {
            return View();
        }

        public IActionResult Monitores()
        {
            return View();
        }

        public IActionResult Impressoras()
        {
            return View();
        }

        public IActionResult Celulares()
        {
            return View();
        }

        public IActionResult MinhasSolicitacoes()
        {
            return View();
        }

        public IActionResult MinhaConta()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult SobreNos()
        {
            return View();
        }

        public IActionResult FaleConosco()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

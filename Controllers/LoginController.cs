using Microsoft.AspNetCore.Mvc;
using plataformaordemdeservico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace plataformaordemdeservico.Controllers
{
    public class LoginController : Controller
    {
        public static List<Login> lslogin = new List<Login>();

        public IActionResult Index()
        {
            return View();
        }
    }
}

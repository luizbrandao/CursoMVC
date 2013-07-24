using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoMVC.Models;
namespace CursoMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(){
            return View();
        }

        public ActionResult Sobre() {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa){
            return View(pessoa);
        }
    }
}

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
            var pessoa = new CursoMVC.Models.Pessoa{
                PessoaId = 1,
                Nome = "Luiz Brandão",
                Twitter = "@luizbrandaoj"
            };
            
            return View(pessoa);
        }

        public ActionResult Sobre() {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa){
            //int PessoaId, string Nome, string Twitter Parametros
            /*var pessoa = new Pessoa {};
            pessoa.PessoaId = PessoaId;
            pessoa.Nome = Nome;
            pessoa.Twitter = Twitter;*/
            return View(pessoa);
        }
    }
}

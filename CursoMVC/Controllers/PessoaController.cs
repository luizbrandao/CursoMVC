using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoMVC.Models;

namespace CursoMVC.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }
        
        [HttpPost]
        public ActionResult Index(Pessoa pessoa) {
            if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome", "O Campo nome é obrigatorio");
            }
            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senhas não conferem!");
            }
            if(ModelState.IsValid){
                return View("Resultado", pessoa);
            }
            
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa) {
            return View(pessoa);
        }

    }
}

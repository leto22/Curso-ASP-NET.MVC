using Curso.ASPNETMVC.TreinaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Curso.ASPNETMVC.TreinaWeb.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Nome,Idade,Endereco,Email")]Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                pessoa.Ativo = true;
                return View("Saudacao", pessoa);
            }
            else
            {
                return View(pessoa);
            }
        }
    }
}
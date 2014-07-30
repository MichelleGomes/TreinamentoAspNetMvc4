using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPrimeiroExemplo.Models;

namespace MvcPrimeiroExemplo.Controllers
{
    public class HelloController : Controller
    {

        public ActionResult Index()
        {
            var aluno = new Aluno
                            {
                                Cidade = "Fortaleza",
                                Idade = 30,
                                Nome = "João"
                            };

            return View(aluno);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
                return View("Resultado", aluno);
            return View(aluno);
        }
    }
}

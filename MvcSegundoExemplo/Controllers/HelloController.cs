using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSegundoExemplo.Models;

namespace MvcSegundoExemplo.Controllers
{
    public class HelloController : Controller
    {

        public ActionResult Index()
        {
          
            return View(RetornaAlunos());
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
        public ActionResult InserirAjax()
        {
            return View();
        }

        public ActionResult RetornaDados()
        {
            ViewData.Add("curso", new Curso
                                          {
                                              NomeCurso = " Sistema de Informação",
                                              TotalSemestre = 8
                                          });
            ViewBag.Curso = new Curso
                                           {
                                               NomeCurso = " Portugues",
                                               TotalSemestre = 6
                                           };
            TempData["Curso"] = new Curso
            {
                NomeCurso = "Geografia",
                TotalSemestre = 8
            };

            return View();
        }

        public ActionResult RelacaoAlunos()
         {
             return View();
         }

        public ActionResult RelacaoAlunosAjax()
        {
            return View(RetornaAlunos().ToList());  
        }

        public PartialViewResult inserirAlunoAjax(Aluno aluno)
        {
            System.Threading.Thread.Sleep(2000);
            return PartialView("_ResultadoInsercaoAluno",aluno); 
        }

        public PartialViewResult ListaAlunosAjax()
        {
            System.Threading.Thread.Sleep(2000);
            return PartialView ("_ResultadoAlunos", RetornaAlunos().ToList());
        }

        public ActionResult ListaAlunos()
        {
            return View(RetornaAlunos().ToList());
        }

        public IQueryable<Aluno> RetornaAlunos()
        {
            var alunoList = new List<Aluno>
                            {
                                new Aluno 
                                {
                                    Cidade = "Ribeirão Preto",
                                    Idade = 20,
                                    Nome = "Michelle"                                    
                                },

                                new Aluno 
                                {
                                    Cidade = "Fortaleza",
                                    Idade = 30,
                                    Nome = "João"
                                },
                            };
            
                return alunoList.AsQueryable();
        }



    }
}

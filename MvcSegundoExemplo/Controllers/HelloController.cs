﻿using System;
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

        public PartialViewResult InserirAjax()
        {
            return PartialView("_ResultadoInsercaoAluno", RetornaAlunos());
        }

        [HttpPost]
        public ActionResult Inserir(Aluno aluno)
        {
            if (ModelState.IsValid)
                return View("Resultado", aluno);
            return View(aluno);
        }

        public ActionResult RelacaoAlunos()
         {
             return View();
         }

        public ActionResult RelacaoAlunosAjax()
        {
            return View(RetornaAlunos().ToList());  
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
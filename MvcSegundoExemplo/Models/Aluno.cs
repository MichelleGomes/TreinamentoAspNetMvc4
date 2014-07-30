using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcSegundoExemplo.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Informe o nome do Aluno")]
        [Display(Name = "Nome do Aluno")]
        public string Nome { get; set; }

        [Range(8, 18, ErrorMessage = "A idade do aluno deve ser entre 8 e 18 anos")]
        [Required(ErrorMessage = "Informe a idade do Aluno")]
        public int Idade { get; set; }

        public string Cidade { get; set; }
    }
}
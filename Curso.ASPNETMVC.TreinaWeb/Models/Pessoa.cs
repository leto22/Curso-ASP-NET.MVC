using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso.ASPNETMVC.TreinaWeb.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [DisplayName("Nome da pessoa: ")]
        public String Nome { get; set; }

        [DisplayName("Idade da pessoa: ")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Endereço obritgatório")]
        [DisplayName("Endereço da pessoa: ")]
        public String Endereco { get; set; }

        [Required(ErrorMessage = "E-mail obrigatório")]
        [DisplayName("E-mail da pessoa:")]
        public String Email { get; set; }

        public bool Ativo { get; set; }
    }
}
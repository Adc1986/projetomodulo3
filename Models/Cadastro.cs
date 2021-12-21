using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Cadastro
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }

        public string CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public int Telefone { get; set; }
    }
}

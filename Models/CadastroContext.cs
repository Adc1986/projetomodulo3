using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class CadastroContext :DbContext
    {
        public CadastroContext()
        {

        }

        public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
        {

        }

        public DbSet<Cadastro> Cadastros { get; set; }

    }
}
    


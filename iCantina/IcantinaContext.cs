using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using iCantina.Models;

namespace iCantina
{
    internal class IcantinaContext : DbContext
    {
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Estudante> Estudantes { get; set; }

        public DbSet<Professor> Professores { get; set; }
        
        public IcantinaContext() : base("iCantina")
        {
            //Outras configurações se necessário
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace iCantina
{
    internal class Utilizador : DbContext
    {
        // Properties da class Utilizador: Id, nome , nif.
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Nif { get; set; }
        

        // Construtor da class Utilizador a mandar parametros para a base de dados.
        public Utilizador(int id, string nome, string nif)
        {
            Id = id;
            Nome = nome;
            Nif = nif;
        }

    }
}

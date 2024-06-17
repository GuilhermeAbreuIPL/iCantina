using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Menu
    {
        public int Id { get; set; }

        public DateTime DataHora { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoEstudante {  get; set; }
        public decimal PrecoProfessor { get; set; }

        public virtual ICollection<Meal> Pratos { get; set; } = new List<Meal>();
        public virtual ICollection<Extra> Extras { get; set; } = new List<Extra>();



    }
}

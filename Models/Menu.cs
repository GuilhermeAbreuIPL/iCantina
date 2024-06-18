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

       public override string ToString()
       {
            //Split date from time and if time is 12:00:00 show Almoço, if 19:00:00 show Jantar
            string[] date = DataHora.ToString().Split(' ');
            string[] time = date[1].Split(':');
            string meal = time[0] == "12" ? "Almoço" : "Jantar";
            return $"{date[0]} - {meal}";
       } 

    }
}

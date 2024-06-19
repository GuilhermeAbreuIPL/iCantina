using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Reservation
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Fee Fee { get; set; }
        public Meal Meal { get; set; }
        public List<Extra> Extra { get; set; }
        public Menu Menu { get; set; }
        public bool Consumido { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Fee
    {
        public int Id { get; set; }
        public decimal valor { get; set; }
        public decimal numHoras { get; set; }

        public override string ToString()
        {
            return $"Valor: {valor} - Número de Horas: {numHoras}";
        }
    }
}

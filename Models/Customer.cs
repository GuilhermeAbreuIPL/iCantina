using iCantina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Models
{
    internal class Customer : User
    {
        public decimal Saldo { get; set; }
        public List<Reservation> Reservations { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Nif} - {GetType().Name}";
        }
    }

    
}

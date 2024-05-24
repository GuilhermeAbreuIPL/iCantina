using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public decimal Saldo { get; set; }
        public User User { get; set; }
    }
}

using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class CustomerController : UserController
    {
        public static List<Customer> ShowAll()
        {
            return db.Customers.ToList(); 
        }

        public static Customer GetCustomerByNif(int nif) 
        {
            Customer querry = db.Customers.FirstOrDefault(c => c.Nif == nif);
            if (querry != null)
            {
                return querry;
            }
            
            return null;
            
        }

        public static bool AddSaldo(int nif, decimal saldo)
        {
            if(GetCustomerByNif(nif) != null)
            {
                Customer customer = GetCustomerByNif(nif);
                customer.Saldo += saldo;
                db.SaveChanges();
                
                return true;
            }

            return false;
            
        }

        public static decimal GetSaldo(int nif)
        {
            Customer querry = db.Customers.FirstOrDefault(c => c.Nif == nif);
            if (querry != null)
            {
                return querry.Saldo;
            }

            return -1;
        }
    }
}

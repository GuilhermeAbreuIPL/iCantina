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
        public static List<Customer> ShowAllClients()
        {
            return db.Customers.ToList(); 
        }
    }
}

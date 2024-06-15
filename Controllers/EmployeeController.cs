using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class EmployeeController : UserController
    {
        

        public static void AddEmployee(Employee employee)
        {

            if (IsValid(employee))
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            
        }



        private static bool isUsernameTaken(Employee employee)
        {
            var querry = db.Employees.FirstOrDefault(e => e.Username == employee.Username);
            if (querry != null)
            {
                return true;
            }
            return false;
        }

        private static bool IsValid(Employee employee)
        {
            bool valid = true;
            if (IsNifTaken(employee.Nif))
            {
                MessageBox.Show("O nif já existe");
                valid = false;
            }

            if(isUsernameTaken(employee)) 
            {
                MessageBox.Show("O username do funcionário já existe!");
                valid = false;
            }

            return valid;
        }
    }
}

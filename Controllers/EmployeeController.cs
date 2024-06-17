using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace iCantina.Controllers
{
    internal class EmployeeController : UserController
    {
        public static List<Employee> ShowAll()
        {
            return db.Employees.ToList();
        }
        
        public static void AddEmployee(Employee employee)
        {

            if (IsValid(employee))
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            
        }

        public static void UpdateEmployee(int id, string nome, int nif, string username)
        {
            Employee querry = db.Employees.FirstOrDefault(e => e.Id == id);
            if (querry != null)
            {
                try
                {
                    querry.Nome = nome;
                    querry.Nif = nif;
                    querry.Username = username;
                    db.SaveChanges();
                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar funcionário");
                    db.Dispose();
                    db = new CantinaContext();
                }
            }
        }

        public static void DeleteEmployee(int id)
        {
            Employee querry = db.Employees.FirstOrDefault(e => e.Id == id);
            if (querry != null)
            {
                db.Employees.Remove(querry);
                db.SaveChanges();
                MessageBox.Show("Funcionário removido com sucesso!");
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

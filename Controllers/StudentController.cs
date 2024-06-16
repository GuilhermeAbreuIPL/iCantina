using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class StudentController : CustomerController
    {
       
        //Publics
        public static void AddStudent(Student student)
        {
            if (IsValid(student))
            {
                db.Students.Add(student);
                db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            
            
        }

        public static Student GetStudentByNif(int nif) 
        {
            Student querry = db.Students.FirstOrDefault(s => s.Nif == nif);
            if (querry != null)
            {
                return querry;
            }
            return null;
        }


        public static List<Student> ShowAll()
        {
            return db.Students.ToList();
        }

        //Privates
        private static bool IsStudentNumberTaken(int numero)
        {
            var querry = db.Students.FirstOrDefault(s => s.NumEstudante == numero);
            if (querry!= null){
                return true;
            }
            return false;
        }

        private static bool IsValid(Student student)
        {
            bool valid = true;

            if(IsStudentNumberTaken(Convert.ToInt32(student.NumEstudante)))
            {
                MessageBox.Show("Número de estudante já existe.");
                valid = false;
            }

            if (IsNifTaken(student.Nif))
            {
                MessageBox.Show("Nif já existe.");
                valid = false;
            }

            return valid;
        }
    }
}

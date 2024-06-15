using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class StudentController
    {
        private static CantinaContext db = Program.DbContext;

        public static void AddStudent(Student student)
        {

            db.Students.Add(student);
            db.SaveChanges();
        }
    }
}

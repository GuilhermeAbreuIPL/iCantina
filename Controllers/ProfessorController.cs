using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class ProfessorController
    {
        private static CantinaContext db = Program.DbContext;

        public static void AddProfessor(Professor professor)
        {
            
            db.Professors.Add(professor);
            db.SaveChanges();
        }
    }
}

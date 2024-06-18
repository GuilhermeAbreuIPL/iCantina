using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class UserController
    {
        
        protected static bool IsNifTaken(int nif)
         {
            var querry = Program.db.Users.FirstOrDefault(s => s.Nif == nif);
            if (querry != null)
            {
                return true;
            }
            return false;


        }
    }
}

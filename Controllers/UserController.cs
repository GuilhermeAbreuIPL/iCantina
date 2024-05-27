using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.EntitySql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class UserController
    {
        //TODO: Funções relacionadas ao utilizador
        public static bool addUser(CantinaContext db, string nome, string nif)
        {
            if (String.IsNullOrEmpty(nome) || String.IsNullOrEmpty(nif))
            {
                return false;
            }
            else
            {
                db.Users.Add(new User { Nome = nome, Nif = nif });
                if (db.SaveChanges() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
    }
}

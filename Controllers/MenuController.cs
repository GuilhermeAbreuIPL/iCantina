using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class MenuController
    {
        protected static CantinaContext db = Program.DbContext;

        public static bool AddMenu(Menu menu)
        {
            if (menu != null)
            {
                db.Menus.Add(menu);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class MenuController
    {
        protected static CantinaContext db = Program.DbContext;

        public static bool AddMenu(Models.Menu menu)
        {
            if (menu != null)
            {
                db.Menus.Add(menu);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Models.Menu> GetMenus()
        {
            return db.Menus.ToList();
        }

        public static bool UpdateMenu(int id, int quantidade, decimal precoProf, decimal precoAluno, DateTime data, List<Meal> meal, List<Extra> extra)
        {
            try
            {
                Models.Menu menu = db.Menus.FirstOrDefault(m => m.Id == id);
                menu.Quantidade = quantidade;
                menu.PrecoProfessor = precoProf;
                menu.PrecoEstudante = precoAluno;
                menu.DataHora = data;
                menu.Pratos = meal;
                menu.Extras = extra;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                db.Dispose();
                db = new CantinaContext();
                return false;
            }

            return false;
        }
    }
}

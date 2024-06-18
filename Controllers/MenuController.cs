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
        

        public static bool AddMenu(Models.Menu menu)
        {
            if (menu != null)
            {
                Program.db.Menus.Add(menu);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Models.Menu> GetMenus()
        {
            return Program.db.Menus.ToList();
        }

        public static bool DeleteMenu(int id)
        {
            Models.Menu querry = Program.db.Menus.FirstOrDefault(m => m.Id == id);
            if (querry != null)
            {
                Program.db.Menus.Remove(querry);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateMenu(int id, int quantidade, decimal precoProf, decimal precoAluno, DateTime data, List<Meal> meal, List<Extra> extra)
        {
            try
            {
                Models.Menu menu = Program.db.Menus.FirstOrDefault(m => m.Id == id);
                menu.Quantidade = quantidade;
                menu.PrecoProfessor = precoProf;
                menu.PrecoEstudante = precoAluno;
                menu.DataHora = data;
                menu.Pratos = meal;
                menu.Extras = extra;
                Program.db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                return false;
            }

            return false;
        }
    }
}

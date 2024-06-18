using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;
using System.Data.Entity;

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

        public static List<Models.Menu> GetAvailableMenus(DateTime date)
        {
            //Função utilizada para mostar os menus aquando de uma reserva.

            List <Models.Menu> querry = Program.db.Menus.Where(m => m.DataHora.Year == date.Year && m.DataHora.Month == date.Month && m.DataHora.Day == date.Day).ToList();
            List <Models.Menu> menusDisponiveis = new List<Models.Menu>();
            if(querry != null)
            {
                foreach (Models.Menu menuTemp in querry)
                {
                    if (menuTemp.DataHora.Date == DateTime.Now.Date)
                    {
                        if (date.Hour < 12 && menuTemp.DataHora.Hour == 12)
                        {
                            //Adiciona só para o almoço
                            menusDisponiveis.Add(menuTemp);
                        }

                        if (date.Hour < 19 && menuTemp.DataHora.Hour == 19)
                        {
                            menusDisponiveis.Add(menuTemp);
                        }
                    }else
                    {
                        return querry;
                    }
                    
                    
                    
                }

                return menusDisponiveis;
            }
            return null;
            
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

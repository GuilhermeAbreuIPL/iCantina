using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Controllers
{
    internal class MealController
    {
        

        public static bool AddMeal(Meal meal)
        {
            if (meal != null)
            {
                Program.db.Meals.Add(meal);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateMeal(int id, string descricao, Tipo tipo, bool state)
        {
            try
            {
                Meal meal = GetMealById(id);
                meal.Descricao = descricao;
                meal.Tipo = tipo;
                meal.Descricao = descricao;
                meal.Ativo = state;
                Program.db.SaveChanges();
                return true;
                
            }catch(Exception)
            {
                Program.db.Dispose();
                Program.db = new CantinaContext();
                MessageBox.Show("Erro ao atualizar prato");
                return false;
            }
        }

        public static bool DeleteMeal(int id)
        {
            Meal meal = GetMealById(id);
            if (meal != null)
            {
                Program.db.Meals.Remove(meal);
                Program.db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<Meal> ShowAll()
        {
            return Program.db.Meals.ToList(); 
        }

        public static Meal GetMealById(int id)
        {
            Meal querry = Program.db.Meals.FirstOrDefault(m => m.Id == id);
            if (querry != null)
            {
                return querry;
            }
            
            return null;
            
        }

        public static List<Meal> GetMealByState(bool state)
        {
            return Program.db.Meals.Where(m => m.Ativo == state).ToList();
        }





    }
}

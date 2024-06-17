using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class MealController
    {
        protected static CantinaContext db = Program.DbContext;

        public static List<Meal> ShowAll()
        {
            return db.Meals.ToList(); 
        }

        public static Meal GetMealById(int id)
        {
            Meal querry = db.Meals.FirstOrDefault(m => m.Id == id);
            if (querry != null)
            {
                return querry;
            }
            
            return null;
            
        }

        public static bool AddMeal(Meal meal)
        {
            if(meal != null)
            {
                db.Meals.Add(meal);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        


        
    }
}

﻿using iCantina.Models;
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
        protected static CantinaContext db = Program.DbContext;

        public static bool AddMeal(Meal meal)
        {
            if (meal != null)
            {
                db.Meals.Add(meal);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateMeal(int id, string descricao, Tipo tipo)
        {
            try
            {
                Meal meal = GetMealById(id);
                meal.Descricao = descricao;
                meal.Tipo = tipo;
                meal.Descricao = descricao;
                db.SaveChanges();
                return true;
                
            }catch(Exception)
            {
                db.Dispose();
                db = new CantinaContext();
                MessageBox.Show("Erro ao atualizar prato");
                return false;
            }
        }

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

      

        


        
    }
}

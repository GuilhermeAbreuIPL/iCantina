using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace iCantina.Controllers
{
    internal class ProfessorController : CustomerController
    {
        

        public static void AddProfessor(Professor professor)
        {
            try 
            {
                SetEmail(professor);
                db.Professors.Add(professor);
                db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            catch (Exception) 
            {
                MessageBox.Show("Erro ao adicionar!");
                db.Dispose();
                db = new CantinaContext();
            }     
        }

        public static bool UpdateProfessor(int id, string nome, int nif)
        {
            Professor querry = db.Professors.FirstOrDefault(p => p.Id == id);
            if (querry != null)
            {
                try
                {
                    querry.Nome = nome;
                    querry.Nif = nif;
                    SetEmail(querry);
                    db.SaveChanges();
                    MessageBox.Show("Professor atualizado com sucesso!");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar professor");
                    db.Dispose();
                    db = new CantinaContext();
                    return false;
                }
            }
            return false;
        }

        public static bool DeleteProfessor(int id)
        {
            Professor querry = db.Professors.FirstOrDefault(p => p.Id == id);
            if (querry != null)
            {
                try
                {
                    db.Professors.Remove(querry);
                    db.SaveChanges();
                    MessageBox.Show("Professor removido com sucesso!");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao remover professor");
                    db.Dispose();
                    db = new CantinaContext();
                    return false;
                }
            }
            return false;
        }

        public static Professor GetProfessorByNif(int nif)
        {
            Professor querry = db.Professors.FirstOrDefault(p => p.Nif == nif);
            if (querry != null)
            {
                return querry;
            }
            return null;
        }

        public static List<Professor> ShowAll()
        {
            return db.Professors.ToList();
        }

       

        private static void SetEmail(Professor professor)
        {
            string prefixoMail = Regex.Replace(professor.Nome, @"\s+", "").ToLower();
            
            professor.Email = prefixoMail + "@ipl.pt";

            int count = 1;
            while (IsMailTaken(professor))
            {
                professor.Email = $"{ prefixoMail }{ count }@ipl.pt";
                count++;
            }
            
            
        }

        private static bool IsMailTaken(Professor professor)
        {
            var querry = db.Professors.FirstOrDefault(p => p.Email == professor.Email);
            if (querry != null)
            {
                return true;
            }
            return false;
        }
    }
}

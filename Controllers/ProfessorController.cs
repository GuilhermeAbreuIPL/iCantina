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
                Program.db.Professors.Add(professor);
                Program.db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            catch (Exception) 
            {
                MessageBox.Show("Erro ao adicionar!");
                Program.db.Dispose();
                Program.db = new CantinaContext();
            }     
        }

        public static bool UpdateProfessor(int id, string nome, int nif)
        {
            Professor querry = Program.db.Professors.FirstOrDefault(p => p.Id == id);
            if (querry != null)
            {
                try
                {
                    querry.Nome = nome;
                    querry.Nif = nif;
                    SetEmail(querry);
                    Program.db.SaveChanges();
                    MessageBox.Show("Professor atualizado com sucesso!");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao atualizar professor");
                    Program.db.Dispose();
                    Program.db = new CantinaContext();
                    return false;
                }
            }
            return false;
        }

        public static bool DeleteProfessor(int id)
        {
            Professor querry = Program.db.Professors.FirstOrDefault(p => p.Id == id);
            if (querry != null)
            {
                try
                {
                    Program.db.Professors.Remove(querry);
                    Program.db.SaveChanges();
                    MessageBox.Show("Professor removido com sucesso!");
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao remover professor");
                    Program.db.Dispose();
                    Program.db = new CantinaContext();
                    return false;
                }
            }
            return false;
        }

        public static Professor GetProfessorByNif(int nif)
        {
            Professor querry = Program.db.Professors.FirstOrDefault(p => p.Nif == nif);
            if (querry != null)
            {
                return querry;
            }
            return null;
        }

        public static List<Professor> ShowAll()
        {
            return Program.db.Professors.ToList();
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
            var querry = Program.db.Professors.FirstOrDefault(p => p.Email == professor.Email);
            if (querry != null)
            {
                return true;
            }
            return false;
        }
    }
}

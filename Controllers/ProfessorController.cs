﻿using iCantina.Models;
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
            if (IsValid(professor))
            {
                SetEmail(professor);
                db.Professors.Add(professor);
                db.SaveChanges();
                MessageBox.Show("Adicionado com sucesso!");
            }
            
        }

        private static bool IsValid(Professor professor)
        {
            bool valid = true;

            if (IsNifTaken(professor.Nif))
            {
                MessageBox.Show("Nif já existe.");
                valid = false;
            }

            return valid;
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
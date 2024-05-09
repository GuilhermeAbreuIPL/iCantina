using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new IcantinaContext())
            {
                var utilizador = new Utilizador { Nome = "Macaco", Nif = "999888111" };
                db.Utilizadores.Add(utilizador);
                var funcionario = new Funcionario { Username = "Paulinha", Utilizador = utilizador };
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

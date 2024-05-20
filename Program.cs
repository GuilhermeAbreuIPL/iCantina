using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Inicialização da base dados
            using (var dbContext = new CantinaContext()) {
                bool isCreated = dbContext.Database.Exists();

                if (!isCreated)
                {
                    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CantinaContext>());
                    dbContext.Database.Initialize(true); 
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}

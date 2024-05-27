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
            InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
        
        //Propriedade static, com o DbContext.
        public static CantinaContext DbContext { get; private set; }

        private static void InitializeDatabase()
        {
            DbContext = new CantinaContext();
            bool isCreated = DbContext.Database.Exists();

            if (!isCreated)
            {
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CantinaContext>());
                DbContext.Database.Initialize(true);
            }
        }
    }
}

using iCantina.Controllers;
using iCantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
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

            //TODO: Apaga me.
            //EmployeeController.AddEmployee(DbContext, new Employee { Nif = "123123", Nome = "Pedro", Username = "Funcionario fixe" });
            //ProfessorController.AddProfessor(DbContext, new Professor { Nif = "123", Email = "mail@mail", Nome = "Macaco", Saldo = 123 });
            //StudentController.AddStudent(DbContext, new Student { Nif = "321" , Nome = "Macaco" , NumEstudante = 2221264, Saldo = 125});


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

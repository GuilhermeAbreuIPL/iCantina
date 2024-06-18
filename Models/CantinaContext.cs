using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class CantinaContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }


        //Meals and Extras

        public DbSet<Extra> Extras { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Menu> Menus { get; set; }


        //set the name of the database to iCantina
        public CantinaContext() : base("iCantina_new") 
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Menus.Include(m => m.Pratos).Include(m => m.Extras).Load(); //Load á relação virtual do menu.

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .Property(s => s.NumEstudante)
                .IsOptional();


            // Configure Username field to be unique if not null
            modelBuilder.Entity<Employee>()
                .Property(e => e.Username)
                .IsOptional()
                .HasMaxLength(450);

            // Create unique index for Username
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Username)
                .IsUnique()
                .HasName("IX_Username");
        }
    }
}
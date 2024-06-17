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



        //set the name of the database to iCantina
        public CantinaContext() : base("iCantina_new") { }

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
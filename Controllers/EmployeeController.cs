﻿using iCantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class EmployeeController
    {
        private static CantinaContext db = Program.DbContext;

        public static void AddEmployee(Employee employee)
        { 
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Employee : User
    {
        //Funcionário


        public string Username { get; set; }
        
        override public string ToString()
        {
            return $"{Nome} - {Nif}";
        }

    }
}

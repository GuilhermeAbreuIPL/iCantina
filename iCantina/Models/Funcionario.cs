﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Utilizador Utilizador { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace iCantina.Models
{
    public enum Tipo
    {
        Carne,
        Peixe,
        Vegetariano
    }

    internal class Meal
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Tipo Tipo { get; set; }
        public bool Ativo { get; set; }


        public override string ToString()
        {
            string estado;
            if(Ativo == true)
            {
                estado = "Ativo";
            }
            else
            {
                estado = "Inativo";
            }

            return $"{Descricao} - {Tipo} - {estado}";
        }

    }
}

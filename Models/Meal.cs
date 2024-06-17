using System;
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

        public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>(); //Talvez seja irrelevante.


        public override string ToString()
        {
            return $"{Descricao} - {Tipo}";
        }

    }
}

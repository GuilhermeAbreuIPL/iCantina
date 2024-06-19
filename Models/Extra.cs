using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class Extra
    {
        //O id é criado automaticamente
        
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco {  get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

        public override string ToString()
        {
            return $"{Descricao} - {Preco}";
        }

    }

}

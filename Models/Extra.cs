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

        public override string ToString()
        {
            string estado;
            if (Ativo == true)
            {
                estado = "Ativo";
            }
            else
            {
                estado = "Inativo";
            }

            return $"{Descricao} - {Preco} - {estado}";
        }
    }

}

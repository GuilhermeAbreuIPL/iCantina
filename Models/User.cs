using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Index(IsUnique = true)]
        public int Nif {  get; set; }
    }
}

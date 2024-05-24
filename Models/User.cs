using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string Nome { get; set; }
        public string Nif {  get; set; }
    }
}

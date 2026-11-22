using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzarendeles.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Nev { get; set; } = string.Empty;
        public int Ar { get; set; } = 0;


    
    public override string ToString()
        {
            return $"{Nev} - {Ar} ";
        }



    }
}

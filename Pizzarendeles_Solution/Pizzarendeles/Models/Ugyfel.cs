using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzarendeles.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }
        public string Nev { get; set; } = string.Empty;
        public string Telefonszam { get; set; } = string.Empty;
        [StringLength(100)]
        public string Cim { get; set; } = string.Empty;
        //Ez most nekem eddig ismeretlen cucc
        public ICollection<Rendeles> Rendelesek { get; set; } = new List<Rendeles>();

    
    public override string ToString()
        {
            return $"{Nev} - {Telefonszam}";
        }
    }
}

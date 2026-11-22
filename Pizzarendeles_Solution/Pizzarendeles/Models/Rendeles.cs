using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pizzarendeles.Models
{
    public class Rendeles
    {
        public int Id { get; set; }
        public int UgyfelId { get; set; }
        public Ugyfel Ugyfel { get; set; } = null;
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; } = null;
        public int Darab { get; set; }
        
        public DateTime Datum { get; set; }
    }
}

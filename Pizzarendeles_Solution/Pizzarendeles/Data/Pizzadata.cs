using Pizzarendeles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzarendeles.Data
{
    public static class Pizzadata
    {
        public static List<Pizza> OsszesPizza { get; } = new()
        {
            new Pizza { Id = 1, Nev = "Margherita", Ar = 2490 },
            new Pizza { Id = 2, Nev = "Sonkás", Ar = 2890 },
            new Pizza { Id = 3, Nev = "Hawaii", Ar = 3090 },
            new Pizza { Id = 4, Nev = "Magyaros", Ar = 3290 },
            new Pizza { Id = 5, Nev = "Négysajtos", Ar = 3390 },
            new Pizza { Id = 6, Nev = "Szalámis", Ar = 2990},
            new Pizza { Id = 7, Nev = "Tonhalas", Ar = 3190 },
            new Pizza { Id = 8, Nev = "Csípős csirkés", Ar = 3490 },
        };




    }
}

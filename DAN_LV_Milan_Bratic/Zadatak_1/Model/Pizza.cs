using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1.Model
{
    public class Pizza
    {
        public List<PizzaIngredient> PizzaIngredients { get; set; }
        public Dictionary<string, int> Size { get; set; }
        public int TotalPrice { get; set; }


    }
}

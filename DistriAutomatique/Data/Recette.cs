using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistriAutomatique.Data
{
    public class Recette
    {
        public string? Name { get; set; }
        public Dictionary<Ingredient, int>? Ingredients { get; set; }
    }
}

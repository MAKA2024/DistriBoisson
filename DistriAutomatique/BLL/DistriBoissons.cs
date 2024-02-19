using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DistriAutomatique.Data;

namespace DistriAutomatique.BLL
{
    public class DistriBoissons
    {
        private Dictionary<string, Recette> recettes;
        private Dictionary<string, Ingredient> ingredients;

        public DistriBoissons()
        {
            recettes = new Dictionary<string, Recette>();
            ingredients = new Dictionary<string, Ingredient>();

            ingredients["Café"] = new Ingredient { Name = "Café", PrixDose = 1.0 };
            ingredients["Sucre"] = new Ingredient { Name = "Sucre", PrixDose = 0.1 };
            ingredients["Crème"] = new Ingredient { Name = "Crème", PrixDose = 0.5 };
            ingredients["Thé"] = new Ingredient { Name = "Thé", PrixDose = 2.0 };
            ingredients["Eau"] = new Ingredient { Name = "Eau", PrixDose = 0.2 };
            ingredients["Chocolat"] = new Ingredient { Name = "Chocolat", PrixDose = 1.0 };
            ingredients["Lait"] = new Ingredient { Name = "Lait", PrixDose = 0.4 };

            recettes["Expresso"] = new Recette
            {
                Name = "Expresso",
                Ingredients = new Dictionary<Ingredient, int>
            {
                { ingredients["Café"], 1 },
                { ingredients["Eau"], 1 }
            }
            };

            recettes["Allongé"] = new Recette
            {
                Name = "Allongé",
                Ingredients = new Dictionary<Ingredient, int>
            {
                { ingredients["Café"], 1 },
                { ingredients["Eau"], 2 }
            }
            };

            recettes["Capuccino"] = new Recette
            {
                Name = "Capuccino",
                Ingredients = new Dictionary<Ingredient, int>
            {
                { ingredients["Café"], 1 },
                { ingredients["Chocolat"], 1 },
                { ingredients["Eau"], 1 },
                { ingredients["Crème"], 1 }
            }
            };

            recettes["Chocolat"] = new Recette
            {
                Name = "Chocolat",
                Ingredients = new Dictionary<Ingredient, int>
            {
                { ingredients["Chocolat"], 3 },
                { ingredients["Lait"], 2 },
                { ingredients["Eau"], 1 },
                { ingredients["Sucre"], 1 }
            }
            };
            recettes["The"] = new Recette
            {
                Name = "The",
                Ingredients = new Dictionary<Ingredient, int>
            {
                { ingredients["Thé"], 1 },
                { ingredients["Eau"], 2 }
            }
            };

        }

        public double GetRecettePrix(string recetteName)
        {
            if (!recettes.ContainsKey(recetteName))
            {
                Console.WriteLine("Recette n'existe pas !");
                return 0.0;
            }

            Recette rec = recettes[recetteName];
            double prix = 0.0;

            foreach (var kvp in rec.Ingredients)
            {
                prix += kvp.Key.PrixDose * kvp.Value;
            }
            return prix * 1.3;
        }
    }
}
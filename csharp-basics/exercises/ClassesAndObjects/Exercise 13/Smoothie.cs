using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    internal class Smoothie
    {
        private Dictionary<string, decimal> ingredientPrices = new Dictionary<string, decimal>
    {
        { "Strawberries", 1.50m },
        { "Banana", 0.50m },
        { "Mango", 2.50m },
        { "Blueberries", 1.00m },
        { "Raspberries", 1.00m },
        { "Apple", 1.75m },
        { "Pineapple", 3.50m }
    };

        public List<string> Ingredients { get; }

        public Smoothie(string[] ingredients)
        {
            Ingredients = new List<string>(ingredients);
        }

        public decimal GetCost()
        {
            return Ingredients.Sum(ingredient => ingredientPrices.GetValueOrDefault(ingredient, 0m));
        }

        public decimal GetPrice()
        {
            return Math.Round(GetCost() * 2.5m, 2, MidpointRounding.AwayFromZero);
        }

        public string GetName()
        {
            string[] sortedIngredients = Ingredients.Select(ingredient => ingredient.EndsWith("ies") ? ingredient.TrimEnd('s') + "y" : ingredient)
                                                    .OrderBy(ingredient => ingredient)
                                                    .ToArray();

            string name = string.Join(" ", sortedIngredients);
            return Ingredients.Count > 1 ? $"{name} Fusion" : $"{name} Smoothie";
        }
    }
}
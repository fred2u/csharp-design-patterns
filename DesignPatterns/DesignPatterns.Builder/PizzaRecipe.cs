using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    internal class PizzaRecipe : IRecipe
    {
        private readonly List<string> _ingredients = new List<string>();
        private string _cooked;

        public void GatherIngredients(Fridge fridge)
        {
            if (fridge == null) throw new ArgumentNullException(nameof(fridge));

            _ingredients.Add(fridge.Get(6, "tomate"));
            _ingredients.Add(fridge.Get(1, "mozarella"));
            _ingredients.Add(fridge.Get(3, "champignon"));
            _ingredients.Add(fridge.Get(6, "morceau de poivron"));
        }

        public void Cook()
        {
            _cooked = String.Join(", ", _ingredients);
        }

        public Dish Serve()
        {
            return new Dish($"une pizza ({_cooked}).");
        }
    }
}
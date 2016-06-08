using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    internal class SandwichRecipe : IRecipe
    {
        private readonly List<string> _ingredients = new List<string>();
        private string _cooked;

        public void GatherIngredients(Fridge fridge)
        {
            if (fridge == null) throw new ArgumentNullException(nameof(fridge));

            _ingredients.Add(fridge.Get(2, "tranche de pain"));
            _ingredients.Add(fridge.Get(1, "tranche de jambon"));
            _ingredients.Add(fridge.Get(1, "tranche de fromage"));
        }

        public void Cook()
        {
            _cooked = String.Join(", ", _ingredients);
        }

        public Dish Serve()
        {
            return new Dish($"un sandwich ({_cooked}).");
        }
    }
}
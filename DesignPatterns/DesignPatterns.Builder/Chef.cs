using System;

namespace DesignPatterns.Builder
{
    internal class Chef
    {
        private readonly Fridge _fridge = new Fridge();

        public void Make(IRecipe recipe)
        {
            if (recipe == null) throw new ArgumentNullException(nameof(recipe));

            recipe.GatherIngredients(_fridge);
            recipe.Cook();
            recipe.Serve();
        }
    }
}
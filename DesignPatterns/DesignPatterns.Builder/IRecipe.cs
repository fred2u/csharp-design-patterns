namespace DesignPatterns.Builder
{
    internal interface IRecipe
    {
        void GatherIngredients(Fridge fridge);
        void Cook();
        Dish Serve();
    }
}
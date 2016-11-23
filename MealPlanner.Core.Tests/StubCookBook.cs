using System.Collections.Generic;

namespace MealPlanner.Core.Tests
{
    public class StubCookBook : ICookBook
    {
        public StubCookBook()
        {
            _recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    Name = "Carbonara",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient()
                        {
                            Name = "Quark"
                        },
                        new Ingredient()
                        {
                            Name = "Bacon"
                        },
                        new Ingredient()
                        {
                            Name = "Eggs"
                        }
                    }
                }
            };
        }
        private readonly List<Recipe> _recipes;
        public List<Recipe> GetAllRecipes()
        {
            return _recipes;
        }
    }
}
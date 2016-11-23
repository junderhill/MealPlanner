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
                },
                new Recipe()
                {
                    Name = "Bolognese",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient()
                        {
                            Name = "Beef"
                        },
                        new Ingredient()
                        {
                            Name = "Tinned Tomato"
                        },
                        new Ingredient()
                        {
                            Name = "Stock"
                        }
                    }
                },
                new Recipe()
                {
                    Name = "Diet Coke Chicken",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient()
                        {
                            Name = "Chicken"
                        },
                        new Ingredient()
                        {
                            Name = "Tinned Tomato"
                        },
                        new Ingredient()
                        {
                            Name = "Peppers"
                        },
                        new Ingredient()
                        {
                            Name = "Diet Coke"
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
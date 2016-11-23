using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlanner.Core
{
	public class MealPlan
	{
	    public int NumberOfMealsToPlan { get; private set; }
	    private List<Meal> _meals;
	    private readonly List<Recipe> _availableRecipes;

	    private readonly Random _random;

	    private MealPlan(ICookBook cookBook, int numberOfMealsToPlan)
		{
		    _random = new Random(DateTime.Now.Second);
		    NumberOfMealsToPlan = numberOfMealsToPlan;

		    _availableRecipes = cookBook.GetAllRecipes();

		    PlanMeals();
		}

	    private void PlanMeals()
	    {
	        for (int i = 0; i < NumberOfMealsToPlan; i++)
	        {
	            Recipe recipe;
                do
                {
                    var randomRecipeNumber = _random.Next(_availableRecipes.Count);
                    recipe = _availableRecipes[randomRecipeNumber];
                } while ( _availableRecipes.Count >= NumberOfMealsToPlan && Meals.Any(m => m.Recipe.Name == recipe.Name));

                Meals.Add(new Meal() {Recipe = recipe});
	        }
	    }

	    public static MealPlan Create(ICookBook cookbook, int mealsToPlan = 5)
		{
			return new MealPlan(cookbook,mealsToPlan);
		}

		public List<Meal> Meals
		{
			get { return _meals ?? (_meals = new List<Meal>()); }
			set { _meals = value; }
		}
	}

	public class Meal
	{
	    public Recipe Recipe { get; set; }
	}
}
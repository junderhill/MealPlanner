using System;
using System.Collections.Generic;

namespace MealPlanner.Core
{
	public class MealPlan
	{
	    public int NumberOfMealsToPlan { get; private set; }
	    private readonly ICookBook _cookBook;
	    private List<Meal> _meals;
	    private List<Recipe> _availableRecipes;

	    private Random _random;

	    private MealPlan(ICookBook cookBook, int numberOfMealsToPlan)
		{
            _random = new Random(DateTime.Now.Second);
		    NumberOfMealsToPlan = numberOfMealsToPlan;
		    _cookBook = cookBook;

		    _availableRecipes = _cookBook.GetAllRecipes();

		    PlanMeals();
		}

	    private void PlanMeals()
	    {
	        for (int i = 0; i < NumberOfMealsToPlan; i++)
	        {
	            int randomRecipeNumber = _random.Next(_availableRecipes.Count);
	            var recipe = _availableRecipes[randomRecipeNumber];
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
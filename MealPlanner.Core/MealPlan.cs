using System.Collections.Generic;

namespace MealPlanner.Core
{
	public class MealPlan
	{
		private List<Meal> _meals;

		private MealPlan(int mealsToPlan)
		{
			for (var i = 0; i < mealsToPlan; i++)
			{
				this.Meals.Add(new Meal());
			}
		}

		public static MealPlan Create(int mealsToPlan = 5)
		{
			return new MealPlan(mealsToPlan);
		}

		public List<Meal> Meals
		{
			get { return _meals ?? (_meals = new List<Meal>()); }
			set { _meals = value; }
		}
	}

	public class Meal
	{
	}
}
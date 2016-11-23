using System.Collections.Generic;

namespace MealPlanner.Core
{
	public class Recipe
	{
		public string Name { get; set; }
		public List<Ingredient> Ingredients { get; set; }
	}
}
using System.Collections.Generic;
using MealPlanner.Core;
using Xunit;
using Should;
using MealPlanner.Core;

namespace MealPlanner.Core.Tests
{
	public class RecipeTests
	{
		[Fact]
		public void RecipeHasAListOfIngredients()
		{
			var recipe = new Recipe()
			{
				Name = "Carbonara",
				Ingredients = new List<Ingredient>
				{
					new Ingredient()
					{
						Name = "Quark"
					}
				}
			};

			recipe.Ingredients.ShouldNotBeEmpty();
		}
	}
}
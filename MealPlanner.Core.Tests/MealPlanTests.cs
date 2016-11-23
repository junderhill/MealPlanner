using System.Linq;
using Should;
using Xunit;

namespace MealPlanner.Core.Tests
{
	public class MealPlanTests
	{
		[Fact]
		public void CreateMealPlan_ReturnsANewMealPlan()
		{
			var result = MealPlan.Create(new StubCookBook());
			result.GetType().ShouldEqual(typeof(MealPlan));
		}

		[Fact]
		public void CreateMealPlan_ReturnsMealPlanWithListOfMeals()
		{
			var result = MealPlan.Create(new StubCookBook());
			result.Meals.ShouldNotBeEmpty();
		}

		[Fact]
		public void CreateMealPlan_ReturnsMealPlanWithNumberOfMealsSpecified()
		{
			var result = MealPlan.Create(new StubCookBook(), 10);
			result.Meals.Count.ShouldEqual(10);
		}

		[Fact]
		public void CreateMealPlan_FirstMeal_IsRandomRecipeFromCookBook()
		{
			var cookbook = new StubCookBook();

		    var plan = MealPlan.Create(cookbook);
            
            cookbook.GetAllRecipes().ShouldContain(plan.Meals.First().Recipe);
		}

	}
}
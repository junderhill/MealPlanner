using System.Linq;
using MoreLinq;
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

			var plan = MealPlan.Create(new StubCookBook());

		    cookbook.GetAllRecipes().Any(x => x.Name == plan.Meals.First().Recipe.Name).ShouldBeTrue();
		}

		[Fact]
		public void CreateMealPlan_WherePossible_MealsArentDuplicatedInAPlan()
		{
			const int mealsToPlan = 3;

			var cookbook = new StubCookBook();
			var plan = MealPlan.Create(cookbook, mealsToPlan);

			//First assertion is to check that we have enough stub data to allow the test to succeed.
			cookbook.GetAllRecipes().Count.ShouldBeGreaterThanOrEqualTo(mealsToPlan);

			plan.Meals.DistinctBy(x => x.Recipe.Name).Count().ShouldEqual(plan.Meals.Count);
		}

	}
}
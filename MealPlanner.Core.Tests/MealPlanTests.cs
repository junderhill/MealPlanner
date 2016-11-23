using Should;
using Xunit;

namespace MealPlanner.Core.Tests
{
	public class MealPlanTests
	{
		[Fact]
		public void CreateMealPlan_ReturnsANewMealPlan()
		{
			var result = MealPlan.Create();
			result.GetType().ShouldEqual(typeof(MealPlan));
		}

		[Fact]
		public void CreateMealPlan_ReturnsMealPlanWithListOfMeals()
		{
			var result = MealPlan.Create();
			result.Meals.ShouldNotBeEmpty();
		}

		[Fact]
		public void CreateMealPlan_ReturnsMealPlanWithNumberOfMealsSpecified()
		{
			var result = MealPlan.Create(10);
			result.Meals.Count.ShouldEqual(10);
		}
	}
}
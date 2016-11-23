using System.Collections.Generic;

namespace MealPlanner.Core
{
    public interface ICookBook
    {
        List<Recipe> GetAllRecipes();
    }
}
using System;

// Interface for meal plans
interface IMealPlan 
{
    string GetMealType();
}

class VegetarianMeal : IMealPlan 
{
    public string GetMealType() => "Vegetarian Meal";
}

class VeganMeal : IMealPlan 
{
    public string GetMealType() => "Vegan Meal";
}

// Generic Meal class
class Meal<T> where T : IMealPlan, new()
{
    public string Name { get; set; }
    public T MealType { get; set; } = new T();
}

// Meal planner with a generic method
static class MealPlanner
{
    public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine($"Meal Plan Generated: {meal.GetMealType()}");
    }
}

// Main execution
class Program
{
    static void Main()
    {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal> { Name = "Salad & Rice" };
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal> { Name = "Tofu Stir Fry" };

        MealPlanner.GenerateMealPlan(vegMeal.MealType);
        MealPlanner.GenerateMealPlan(veganMeal.MealType);
    }
}

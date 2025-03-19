using System.Text.Json;

class Ingredient
{
    public string Title { get; set; }
    public int Grams { get; set; }
}

class Recipe
{
    public string Title { get; set; }
    public string Kitchen { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public int CookingTime { get; set; }
    public List<string> Steps { get; set; } = new List<string>();
}

class CookingBook
{
    public List<Recipe> Recipes { get; set; } = new List<Recipe>();

    public void AddRecipe(Recipe recipe) => Recipes.Add(recipe);
    public void RemoveRecipe(string title) => Recipes.RemoveAll(r => r.Title == title);
    public Recipe FindRecipe(string title) => Recipes.FirstOrDefault(r => r.Title == title);

    public void SaveToFile(string fileName)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        File.WriteAllText(fileName, JsonSerializer.Serialize(this, options));
    }

    public static CookingBook LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName)) return new CookingBook();

        return JsonSerializer.Deserialize<CookingBook>(File.ReadAllText(fileName)) ?? new CookingBook();
    }
}

class Program
{
    static void Main()
    {
        CookingBook book = new CookingBook();
        book.AddRecipe(new Recipe
        {
            Title = "Pizza Margherita",
            Kitchen = "Italian",
            CookingTime = 30,
            Ingredients = new List<Ingredient> { new Ingredient { Title = "Dough", Grams = 500 }, new Ingredient { Title = "Tomato", Grams = 200 } },
            Steps = new List<string> { "Prepare dough", "Spread tomato", "Bake" }
        });

        book.SaveToFile("recipes.json");
        CookingBook loadedBook = CookingBook.LoadFromFile("recipes.json");
        Console.WriteLine("Loaded recipes: " + loadedBook.Recipes.Count);
    }
}

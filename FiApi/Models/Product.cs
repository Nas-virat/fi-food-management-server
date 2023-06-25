namespace FiApi.Models;

public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public Ingredient[]? Ingredients { get; set; }
    public long Price { get; set; }
    public bool IsComplete { get; set; }
}
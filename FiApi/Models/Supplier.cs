namespace FiApi.Models;

public class Supplier
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public Ingredient[]? Ingredients { get; set; }
    public string? Address { get; set; }
    public string? Gmail { get; set; }
    public string? Phone { get; set; }
    public bool IsComplete { get; set; }
}
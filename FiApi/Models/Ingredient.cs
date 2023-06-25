namespace FiApi.Models;


public class Ingredient
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public Supplier? Suppliers { get; set; }
    public bool IsComplete { get; set; }
}
namespace FiApi.Models;

public class Transaction
{
    public int Id { get; set; }
    public string Ingredient { get; set; } = null!;
    public decimal Quanity { get; set; }
    public string Unit { get; set; } = null!;
    public decimal CostPerUnit { get; set; }

    public DateTime Date { get; set; }
    
    public Supplier Supplier { get; set; } = null!;
}
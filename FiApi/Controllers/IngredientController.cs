
using Microsoft.AspNetCore.Mvc;
using FiApi.Models;

namespace FiApi.Controllers;


[ApiController]
[Route("[controller]")]
public class IngredientController : Controller 
{
    private readonly ILogger<IngredientController> _logger;

    public IngredientController(ILogger<IngredientController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetIngredient")]
    public IEnumerable<Ingredient> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Ingredient
        {
            Id = index,
            Name = $"Ingredient {index}",
            Unit = $"Unit {index}",
            CostPerUnit = index * 1000,
            Category = $"Category {index}",
            Description = $"Description {index}",
            Image = $"Image {index}",
            IsComplete = false
        })
        .ToArray();
    }
    [HttpGet("{id}", Name = "GetIngredientById")]
    public Ingredient GetById(long id)
    {
        return new Ingredient
        {
            Id = (int)id,
            Name = $"Ingredient {id}",
            Unit = $"Unit {id}",
            CostPerUnit = (int)(id * 1000),
            Category = $"Category {id}",
            Description = $"Description {id}",
            Image = $"Image {id}",
            IsComplete = false
        };
    }

    [HttpPost]
    public IActionResult Create(Ingredient ingredient)
    {
        ingredient.Id = 1;
        return CreatedAtRoute("GetIngredientById", new { id = ingredient.Id }, ingredient);
    }

    [HttpPut("{id}")]
    public IActionResult Update(long id, Ingredient ingredient)
    {
        return NoContent();
    }
}
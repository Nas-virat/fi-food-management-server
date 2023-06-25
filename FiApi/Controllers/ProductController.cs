using Microsoft.AspNetCore.Mvc;
using FiApi.Models;

namespace FiApi.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProduct")]
    public IEnumerable<Product> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Product
        {
            Id = index,
            Name = $"Product {index}",
            Category = $"Category {index}",
            Description = $"Description {index}",
            Image = $"Image {index}",
            Price = index * 1000,
            IsComplete = false
        })
        .ToArray();
    }

    [HttpGet("{id}", Name = "GetProductById")]
    public Product GetById(long id)
    {
        return new Product
        {
            Id = id,
            Name = $"Product {id}",
            IsComplete = false
        };
    }

    [HttpPost(Name = "CreateProduct")]
    public Product Create(Product product)
    {
        return product;
    }

    [HttpPut("{id}", Name = "UpdateProduct")]
    public Product Update(long id, Product product)
    {
        return product;
    }

    [HttpDelete("{id}", Name = "DeleteProduct")]
    public Product Delete(long id)
    {
        return new Product
        {
            Id = id,
            Name = $"Product {id}",
            IsComplete = false
        };
    }
}

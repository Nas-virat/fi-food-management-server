using Microsoft.AspNetCore.Mvc;
using FiApi.Models;

namespace FiApi.Controllers;


[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ILogger<TransactionController> _logger;

    public TransactionController(ILogger<TransactionController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTransaction")]
    public IEnumerable<Transaction> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Transaction
        {
            Id = index,
            Ingredient = $"Ingredient {index}",
            Quanity = index * 1000,
            Unit = $"Unit {index}",
            CostPerUnit = index * 1000,
            Date = DateTime.Now,
            Supplier = new Supplier
            {
                Id = index,
                Name = $"Supplier {index}",
                Address = $"Address {index}",
                Phone = $"Phone {index}",
                Email = $"Email {index}",
                IsComplete = false
            }
        })
        .ToArray();
    }
 
    [HttpGet("{id}", Name = "GetTransactionById")]
    public Transaction GetById(long id)
    {
        return new Transaction
        {
            Id = (int)id,
            Ingredient = $"Ingredient {id}",
            Quanity = id * 1000,
            Unit = $"Unit {id}",
            CostPerUnit = id * 1000,
            Date = DateTime.Now,
            Supplier = new Supplier
            {
                Id = id,
                Name = $"Supplier {id}",
                Address = $"Address {id}",
                Phone = $"Phone {id}",
                Email = $"Email {id}",
                IsComplete = false
            }
        };
    }


    [HttpPost(Name = "CreateTransaction")]
    public Transaction Create(Transaction transaction)
    {
        return transaction;
    }

    [HttpPut("{id}", Name = "UpdateTransaction")]
    public Transaction Update(long id, Transaction transaction)
    {
        return transaction;
    }

    [HttpDelete("{id}", Name = "DeleteTransaction")]
    public Transaction Delete(long id)
    {
        return new Transaction
        {
            Id = (int)id,
            Ingredient = $"Ingredient {id}",
            Quanity = id * 1000,
            Unit = $"Unit {id}",
            CostPerUnit = id * 1000,
            Date = DateTime.Now,
            Supplier = new Supplier
            {
                Id = id,
                Name = $"Supplier {id}",
                Address = $"Address {id}",
                Phone = $"Phone {id}",
                Email = $"Email {id}",
                IsComplete = false
            }
        };
    }

}
using Microsoft.AspNetCore.Mvc;
using FiApi.Models;

namespace FiApi.Controllers;


[ApiController]
[Route("[controller]")]
public class SupplierController : ControllerBase
{
    private readonly ILogger<SupplierController> _logger;

    public SupplierController(ILogger<SupplierController> logger)
    {
        _logger = logger;
    }
}
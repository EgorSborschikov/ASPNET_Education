using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApiTestSolution.Data;
using WebApiTestSolution.Models;
using System.Linq;

namespace WebApiTestSolution.Endpoints;

[ApiController]
[Route("/api/products")]
public class ProductsController
{
    private readonly AppDatabaseContext _context;

    public ProductsController(AppDatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        var products = _context.Products.ToList();
        Console.WriteLine($"Products found: {products.Count}");
        return products;
    }

}
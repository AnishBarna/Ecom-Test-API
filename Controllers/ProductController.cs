using Ecom.Models;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;


namespace Ecom.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    public ProductController()
    {

    }


    [HttpGet]
    public ActionResult<List<Product>> GetAll() => ProductService.GetAll() ;

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = ProductService.Get(id);

        if(product is null)
        {
            return NotFound();
        }

        return product;
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        ProductService.Add(product);
        return CreatedAtAction( nameof(Create), new { id = product.ProductId} , product);

    }

    [HttpPut("id")]
    public IActionResult Update(int id, Product product)
    {
        if(id != product.ProductId)
            return BadRequest();

        var existingProduct = ProductService.Get(id);

        if(existingProduct is null)
            return NotFound();

            ProductService.Update(product);

            return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = ProductService.Get(id);

        if(product is null)
            return NotFound();

            ProductService.Delete(id);

            return NoContent();
    }
}


using Ecom.Models;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;


namespace Ecom.Controllers;


[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    ProductService product_service;
  
    public ProductController(ProductService p_service)
    {
        product_service = p_service;
        
    }


    [HttpGet]
    public IEnumerable<Product> GetAll() => product_service.GetAll() ;

    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        var product = product_service.Get(id);

        if(product is null)
        {
            return NotFound();
        }

        return product;
    }


    [HttpGet("byCustomer/{id}")]
    public IEnumerable<Product> GetByCustomer(int id)
    {
        return product_service.ProductsbyCustomer(id);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product_service.Add(product);
        return CreatedAtAction( nameof(Create), new { id = product.ProductId} , product);

    }

    [HttpPut("id")]
    public IActionResult Update(int id, Product product)
    {
        if(id != product.ProductId)
            return BadRequest();

        var existingProduct = product_service.Get(id);

        if(existingProduct is null)
            return NotFound();

            product_service.Update(id, product);

            return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var product = product_service.Get(id);

        if(product is null)
            return NotFound();

            product_service.Delete(id);

            return NoContent();
    }
}

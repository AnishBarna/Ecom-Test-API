using Ecom.Models;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;


namespace Ecom.Controllers;


[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    public CustomerController()
    {

    }


    [HttpGet]
    public ActionResult<List<Customer>> GetAll() => CustomerService.GetAll() ;

    [HttpGet("{id}")]
    public ActionResult<Customer> Get(int id)
    {
        var customer = CustomerService.Get(id);

        if(customer is null)
        {
            return NotFound();
        }

        return customer;
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        CustomerService.Add(customer);
        return CreatedAtAction( nameof(Create), new { id = customer.CustomerId} , customer);

    }

    [HttpPut("id")]
    public IActionResult Update(int id, Customer customer)
    {
        if(id != customer.CustomerId)
            return BadRequest();

        var existingCustomer = CustomerService.Get(id);

        if(existingCustomer is null)
            return NotFound();

            CustomerService.Update(customer);

            return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var customer = CustomerService.Get(id);

        if(customer is null)
            return NotFound();

            CustomerService.Delete(id);

            return NoContent();
    }
}


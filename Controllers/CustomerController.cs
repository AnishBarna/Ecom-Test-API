using Ecom.Models;
using Ecom.Data;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;


namespace Ecom.Controllers;


[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{

    CustomerService customer_service;

    public CustomerController(CustomerService service)
    {
        customer_service = service;
    }


    [HttpGet]
    public IEnumerable<Customer> GetAll()
    { 
        return customer_service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> Get(int id)
    {
        var customer = customer_service.Get(id);

        if(customer is null)
        {
            return NotFound();
        }

        return customer;
    }

    [HttpGet("bydate/{date}")]
    public IEnumerable<Customer> GetByDate(DateTime date)
    {
        return customer_service.GetbyDate(date);
    }

    [HttpPost]
    public IActionResult Create(Customer customer)
    {
        customer_service.Add(customer);

        return CreatedAtAction( nameof(Create), new { id = customer.CustomerId} , customer);

    }

    [HttpPut("id")]
    public IActionResult Update(int id, Customer customer)
    {
        if(id != customer.CustomerId)
            return BadRequest();

        var existingCustomer = customer_service.Get(id);

        if(existingCustomer is null)
            return NotFound();

            customer_service.Update(id, customer);

            return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var customer = customer_service.Get(id);

        if(customer is null)
            return NotFound();

            customer_service.Delete(id);

            return NoContent();
    }
}


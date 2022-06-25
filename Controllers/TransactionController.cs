using Ecom.Models;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    
    TransactionService transaction_service;

    public TransactionController(TransactionService service)
    {
        transaction_service = service;
    }

    [HttpGet]
    public IEnumerable<Transaction> GetAll() => transaction_service.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Transaction> Get(int id)
    {
        var transaction = transaction_service.Get(id);

        if(transaction is null)
        return NotFound();

        return transaction;
    }


    [HttpGet("bycustomer/{id}")]
    public IEnumerable<Transaction>? GetByCustomer(int id)
    {
       return transaction_service.GetByCustomer(id);
    } 


    [HttpPost]
    public IActionResult Create(Transaction transaction)
    {
        transaction_service.Add(transaction);

        return CreatedAtAction( nameof(Create), new { id = transaction.TransactionId}, transaction);
        
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var transaction = transaction_service.Get(id);

        if(transaction is null)
            return NotFound();

            transaction_service.Delete(id);

            return NoContent();
    }
}

using Ecom.Models;
using Ecom.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    public TransactionController()
    {
        
    }

    [HttpGet]
    public ActionResult<List<Transaction>> GetAll() => TransactionService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Transaction> Get(int id)
    {
        var transaction = TransactionService.Get(id);

        if(transaction is null)
        return NotFound();

        return transaction;
    }


    [HttpGet("bycustomer/{id}")]
    public ActionResult<List<Transaction>> GetByCustomer(int id) => TransactionService.GetByCustomer(id);

    [HttpGet("byproduct/{id}")]
    public ActionResult<List<Transaction>> GetByProduct(int id) => TransactionService.GetByProduct(id);

    [HttpPost]
    public IActionResult Create(Transaction transaction)
    {
        TransactionService.Add(transaction);
        return CreatedAtAction( nameof(Create), new { id = transaction.TransactionId}, transaction);
        
    }

    [HttpPut("id")]
    public IActionResult Update(int id, Transaction transaction)
    {
        if(id != transaction.TransactionId)
            return BadRequest();

        var existingTransaction = TransactionService.Get(id);
        if(existingTransaction is null)
            return NotFound();

            TransactionService.Update(transaction);

            return NoContent();

    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var transaction = TransactionService.Get(id);

        if(transaction is null)
            return NotFound();

            TransactionService.Delete(id);

            return NoContent();
    }
}

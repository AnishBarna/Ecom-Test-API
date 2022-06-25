using Ecom.Models;
using Microsoft.EntityFrameworkCore;
using Ecom.Data;

namespace Ecom.Services;
public class TransactionService
{
    
    private readonly EcomContext _context;

    public TransactionService(EcomContext context)
    {
        _context = context;
    }

    public IEnumerable<Transaction> GetAll()
    {
        return _context.Transactions.AsNoTracking().ToList();
    }

    public Transaction? Get(int id)
    {
        return _context.Transactions.AsNoTracking().SingleOrDefault(t => t.TransactionId == id);
    }

    public Transaction Add(Transaction transaction)
    {
        _context.Add(transaction);
        _context.SaveChanges();

        return transaction;
    }

    public IEnumerable<Transaction>? GetByCustomer(int id)
    {
        return _context.Transactions.Where(t => t.CustomerId == id).ToList();
    }
    
    public void Delete(int id)
    {
        var TBDTransaction = _context.Transactions.Find(id);

        if(TBDTransaction is not null)
        {
            _context.Transactions.Remove(TBDTransaction);
            _context.SaveChanges();
        }
    }

}
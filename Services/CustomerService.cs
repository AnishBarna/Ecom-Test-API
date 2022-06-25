using Ecom.Models;
using Ecom.Data;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Services;
public class CustomerService
{

    private readonly EcomContext _context ;

    public CustomerService(EcomContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Customer> GetAll()
    {
        return _context.Customers.AsNoTracking().Include(p => p.Transactions).ToList();
    }

        
    public Customer? Get(int id)
    {
        return _context.Customers.AsNoTracking().SingleOrDefault(p => p.CustomerId == id);
    }

    
    
    
    public IEnumerable<Customer> GetbyDate(DateTime date)
    {
        var RequiredTransactions = _context.Transactions.Where(t => t.TransactionDate == date).AsNoTracking().ToList();

        var AllCustomers = _context.Customers.AsNoTracking().ToList();
        
        var RequiredCustomers = new List<Customer>();

        foreach (Transaction t in RequiredTransactions)
        {
            foreach(Customer c in AllCustomers)
            {
                if(c.CustomerId == t.CustomerId)
                {
                    RequiredCustomers.Add(c);
                }
            }
        }
    
        return RequiredCustomers;
    }
// Need to find an efficient implementation for the same


      
    public Customer Add(Customer customer)
    {
        _context.Add(customer);
        _context.SaveChanges();

        return customer;
    }

    public void Delete(int id)
    {
        var TBDCustomer = _context.Customers.Find(id);

        if(TBDCustomer is not null)
        {
            _context.Customers.Remove(TBDCustomer);
            _context.SaveChanges();
        }

    }


public void Update(int id, Customer customer)
{
    var TBUCustomer = _context.Customers.Find(id);

    if(TBUCustomer is null)
    {
        throw new InvalidOperationException();
    }


    TBUCustomer = customer;
    _context.SaveChanges();

}



}
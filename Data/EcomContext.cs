using Microsoft.EntityFrameworkCore;
using Ecom.Models;

namespace Ecom.Data;

public class EcomContext : DbContext
{

    public EcomContext(DbContextOptions<EcomContext> options) : base(options)
    {
        
    }
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Products => Set<Product>(); 
    public DbSet<Transaction> Transactions => Set<Transaction>();
    

}
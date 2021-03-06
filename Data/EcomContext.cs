using Microsoft.EntityFrameworkCore;
using Ecom.Models;

namespace Ecom.Data;

public class EcomContext : DbContext
{


    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    => modelBuilder.Entity<Customer>().Property(b => b.CustomerId).UseIdentityAlwaysColumn();
    
    
    public EcomContext(DbContextOptions<EcomContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
    }
    
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Product> Products => Set<Product>(); 
    public DbSet<Transaction> Transactions => Set<Transaction>();
    

}
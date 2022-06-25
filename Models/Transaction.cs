using System.ComponentModel.DataAnnotations;

namespace Ecom.Models;


public class Transaction
{
  
    
    public int TransactionId { get; set; }

    [Required]
    public int CustomerId { get; set; }
    public DateTime TransactionDate { get; set; }
    public DateTime TransactionTime { get; set; }
    public ICollection<Product> Products { get; set; }
        
}
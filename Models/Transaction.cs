using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecom.Models;


public class Transaction
{
  
    
    public int TransactionId { get; set; }

    [Required]
    public int CustomerId { get; set; }

    [NotMapped]
    public DateTime TransactionDate { get; set; }

    [NotMapped]
    public DateTime TransactionTime { get; set; }
    public ICollection<Product> Products { get; set; }

        
}
using System.ComponentModel.DataAnnotations;
namespace Ecom.Models;


public class Customer
{
    public int CustomerId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? CustomerName { get; set; }
    public int CustomerAge { get; set; }
    public ICollection<Transaction>? Transactions { get; set;}

}
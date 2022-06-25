using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Ecom.Models;


public class Product
{
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? ProductName { get; set; }
    public int ProductPrice { get; set; }

    [JsonIgnore]
    public ICollection<Transaction>? Transactions { get; set; }
        
}
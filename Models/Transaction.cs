namespace Ecom.Models;

public class Transaction
{
    public int TransactionId { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
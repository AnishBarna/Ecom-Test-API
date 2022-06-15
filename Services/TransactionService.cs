using Ecom.Models;

namespace Ecom.Services;
public static class TransactionService
{
    static List<Transaction> Transactions {get;}

    static int nextTransactionId = 3;

    static TransactionService()
    {
        
        Transactions = new List<Transaction>
        {
            new Transaction{TransactionId = 1 , CustomerId = 1, ProductId = 2, Quantity = 5},
            new Transaction{TransactionId = 2 , CustomerId = 2, ProductId = 20, Quantity = 2}
        };


    }

    public static List<Transaction> GetAll() => Transactions ;
    public static Transaction? Get(int id) => Transactions.FirstOrDefault(transaction => transaction.TransactionId == id); 
    public static List<Transaction> GetByCustomer(int id) => Transactions.FindAll(transaction => transaction.CustomerId == id);

    public static List<Transaction> GetByProduct(int id) => Transactions.FindAll(transaction => transaction.ProductId == id);

    public static void Add(Transaction transaction)
    {
        transaction.TransactionId = nextTransactionId++ ;
        Transactions.Add(transaction);
    }

    public static void Delete(int id)
    {
        var transaction = Get(id);

        if(transaction is null)
        return;

        Transactions.Remove(transaction);
    }
    public static void Update(Transaction transaction)
    {
        var index = Transactions.FindIndex(t => t.TransactionId == transaction.TransactionId);
        if(index ==-1)
        return;

        Transactions[index] = transaction;
    }
}
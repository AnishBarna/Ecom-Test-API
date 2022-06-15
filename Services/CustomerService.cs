using Ecom.Models;

namespace Ecom.Services;
public static class CustomerService
{

    static List<Customer> Customers {get;}

    static int  nextCustomerId = 3;

     static CustomerService()
    {
        Customers = new List<Customer> 
        {
            new Customer{CustomerId = 1 , CustomerAge = 30, CustomerName = "Joey"},
            new Customer{CustomerId = 2 , CustomerAge = 35, CustomerName = "Ross"}
        };
    }



    public static List<Customer> GetAll() => Customers ;
    public static Customer? Get(int id) => Customers.FirstOrDefault(customer => customer.CustomerId == id);


    public static void Add(Customer customer)
    {
        customer.CustomerId = nextCustomerId++;
        Customers.Add(customer);
    }

    public static void Delete(int id)
    {
        var customer = Get(id);

        if(customer is null)
        return;

        Customers.Remove(customer);

    }


    public static void Update(Customer customer)
{
    var index = Customers.FindIndex(c => c.CustomerId == customer.CustomerId);
    if(index ==-1)
        return;

    Customers[index] = customer;

}



}
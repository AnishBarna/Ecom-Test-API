using Ecom.Models;

namespace Ecom.Services;
public static class ProductService
{

static List<Product> Products {get;}

static int nextProductId = 3;

static ProductService()
{  
    Products = new List<Product>
    { 
        new Product{ProductId = 1 , ProductName = "Toothpaste" , ProductPrice = 40},
        new Product{ProductId = 2 , ProductName = "Detergent" , ProductPrice = 400 }
    };

}



public static List<Product> GetAll() => Products ;
public static Product? Get(int id) => Products.FirstOrDefault(product => product.ProductId == id);

public static void Add(Product product)
    {
        product.ProductId = nextProductId++;
        Products.Add(product);
    }


public static void Delete(int id)
    {
        var product = Get(id);

        if(product is null)
        return;

        Products.Remove(product);

    }


    public static void Update(Product product)
{
    var index = Products.FindIndex(p => p.ProductId == product.ProductId);
    if(index ==-1)
        return;

    Products[index] = product;

}

}
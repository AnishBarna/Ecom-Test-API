using Ecom.Models;

namespace Ecom.Data;

public static class DBInitializer
{
    public static void Initialize(EcomContext context)
    {
        if(context.Customers.Any() && context.Products.Any() && context.Transactions.Any())
        {
            return;
        }
    
        var customers = new Customer[]
        {
                
                new Customer{ CustomerName = "Customer1" , CustomerAge = 26 },
                new Customer{ CustomerName = "Customer2" , CustomerAge = 27 },
                new Customer{ CustomerName = "Customer3" , CustomerAge = 28 },
                new Customer{ CustomerName = "Customer4" , CustomerAge = 29 },
                new Customer{ CustomerName = "Customer5" , CustomerAge = 30 },
                new Customer{ CustomerName = "Customer6" , CustomerAge = 31 },
                new Customer{ CustomerName = "Customer7" , CustomerAge = 32 },
                new Customer{ CustomerName = "Customer8" , CustomerAge = 33 },
                new Customer{ CustomerName = "Customer9" , CustomerAge = 34 },
                new Customer{ CustomerName = "Customer10" , CustomerAge = 35 }
        
        };
        
        context.Customers.AddRange(customers);
        context.SaveChanges();
        

        var product1 = new Product{ ProductName = "Product1" , ProductPrice = 26 };
        var product2 = new Product{ ProductName = "Product2" , ProductPrice = 27 };
        var product3 = new Product{ ProductName = "Product3" , ProductPrice = 28 };
        var product4 = new Product{ ProductName = "Product4" , ProductPrice = 29 };
        var product5 = new Product{ ProductName = "Product5" , ProductPrice = 30 };
        var product6 = new Product{ ProductName = "Product6" , ProductPrice = 31 };
        var product7 = new Product{ ProductName = "Product7" , ProductPrice = 32 };
        var product8 = new Product{ ProductName = "Product8" , ProductPrice = 33 };
        var product9 = new Product{ ProductName = "Product9" , ProductPrice = 34 };
        var product10 = new Product{ ProductName = "Product10" , ProductPrice = 35 };
        var product11 = new Product{ ProductName = "Product11" , ProductPrice = 36 };
        var product12 = new Product{ ProductName = "Product12" , ProductPrice = 37 };
        var product13 = new Product{ ProductName = "Product13" , ProductPrice = 38 };
        var product14 = new Product{ ProductName = "Product14" , ProductPrice = 39 };
        var product15 = new Product{ ProductName = "Product15" , ProductPrice = 40 };
        var product16 = new Product{ ProductName = "Product16" , ProductPrice = 41 };
        var product17 = new Product{ ProductName = "Product17" , ProductPrice = 42 };
        var product18 = new Product{ ProductName = "Product18" , ProductPrice = 43 };
        var product19 = new Product{ ProductName = "Product19" , ProductPrice = 44 };
        var product20 = new Product{ ProductName = "Product20" , ProductPrice = 45 };


    
        var transactions = new Transaction[] 
        { 
            
        new Transaction{ CustomerId =8 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product3,
                product3,
                product1,
                product6,
                product2,
                product5,
                }
        }, 
        new Transaction{ CustomerId =8 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product5,
                product2,
                product5,
                product6,
                product11,
                product13,
                product1,
                product13,
                product9,
                product3,
                product2,
                product9,
                product7,
                product9,
                product11,
                }
        },
        new Transaction{ CustomerId =6 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product6,
                product8,
                product9,
                product12,
                product3,
                product7,
                product15,
                product13,
                product16,
                product5,
                product5,
                product15,
                product3,
                product1,
                product5,
                product14,
                product13,
                product8,
                }
        },
        new Transaction{ CustomerId =2 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product11,
                product2,
                product7,
                product6,
                product11,
                product3,
                product2,
                product1,
                product2,
                product3,
                product9,
                }
        },
        new Transaction{ CustomerId =7 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product16,
                product5,
                product16,
                product9,
                product13,
                product10,
                product8,
                product1,
                product9,
                product9,
                product8,
                product3,
                product16,
                product5,
                product7,
                product7,
                product3,
                }
        },
        new Transaction{ CustomerId =6 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product6,
                product10,
                product14,
                product3,
                product2,
                product2,
                product1,
                product4,
                product13,
                product9,
                product2,
                product10,
                product3,
                product4,
                product11,
                product10,
                product6,
                product3,
                product10,
                }
        },
        new Transaction{ CustomerId =6 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product5,
                product1,
                product6,
                product7,
                product7,
                product9,
                product8,
                product3,
                product4,
                }
        },
        new Transaction{ CustomerId =5 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product7,
                product10,
                product1,
                product7,
                product1,
                product11,
                product5,
                product10,
                product5,
                product6,
                product2,
                }
        },
        new Transaction{ CustomerId =1 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product5,
                product3,
                product7,
                product2,
                product7,
                product4,
                product8,
                product3,
                product9,
                product10,
                }
        },
        new Transaction{ CustomerId =8 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product1,
                product2,
                product9,
                product9,
                product8,
                product6,
                product4,
                product1,
                product6,
                }
        },
        new Transaction{ CustomerId =5 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product6,
                product7,
                product3,
                product8,
                product6,
                product8,
                product3,
                product2,
                }
        },
        new Transaction{ CustomerId =3 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product1,
                product2,
                product3,
                }
        },
        new Transaction{ CustomerId =7 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product14,
                product9,
                product9,
                product14,
                product11,
                product16,
                product7,
                product16,
                product7,
                product17,
                product9,
                product14,
                product14,
                product14,
                product17,
                product3,
                product17,
                }
        },
        new Transaction{ CustomerId =6 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product6,
                product2,
                product5,
                product5,
                product7,
                product11,
                product1,
                product2,
                product3,
                product3,
                product9,
                }
        },
        new Transaction{ CustomerId =5 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product11,
                product6,
                product11,
                product10,
                product11,
                product10,
                product3,
                product12,
                product1,
                product10,
                product6,
                product5,
                }
        },
        new Transaction{ CustomerId =2 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product15,
                product18,
                product14,
                product5,
                product3,
                product4,
                product15,
                product1,
                product4,
                product12,
                product2,
                product11,
                product8,
                product15,
                product15,
                product15,
                product11,
                product3,
                }
        },
        new Transaction{ CustomerId =2 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product8,
                product7,
                product8,
                product7,
                product7,
                product2,
                product6,
                product7,
                }
        },
        new Transaction{ CustomerId =1 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product4,
                product7,
                product4,
                product1,
                product7,
                product8,
                product8,
                product5,
                }
        },
        new Transaction{ CustomerId =6 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product13,
                product1,
                product4,
                product9,
                product10,
                product8,
                product11,
                product2,
                product11,
                product12,
                product2,
                product10,
                product7,
                }
        },
        new Transaction{ CustomerId =7 , TransactionDate = DateTime.Today , TransactionTime = DateTime.Now ,  Products = new List<Product>
                {	
                product15,
                product9,
                product12,
                product5,
                product14,
                product1,
                product15,
                product9,
                product12,
                product6,
                product12,
                product6,
                product9,
                product10,
                product13,
                }
        },

        };

        context.Transactions.AddRange(transactions);
        context.SaveChanges();

    }


}
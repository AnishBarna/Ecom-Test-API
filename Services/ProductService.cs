    using Ecom.Models;
    using Ecom.Data;
    using Microsoft.EntityFrameworkCore;

    namespace Ecom.Services;
    public class ProductService
    {
        
        private readonly EcomContext _context;

        public ProductService(EcomContext context)
        {
            _context = context;
        }

        public List<Product> GetAll()
        {
            return _context.Products.AsNoTracking().ToList();
        }
        public Product? Get(int id) => _context.Products.FirstOrDefault(product => product.ProductId == id);

        public Product? Add(Product product)
        {
                _context.Add(product);
                _context.SaveChanges();

                return product;
        }

                
        
        public void Delete(int id)
        {
            var TBDProduct = _context.Products.Find(id);

            if(TBDProduct is not null)
            {
                _context.Products.Remove(TBDProduct);
                _context.SaveChanges();
            }        

        }

        public IEnumerable<Product> ProductsbyCustomer(int id)
        {

        IEnumerable<Transaction> AllTransactions = _context.Transactions.AsNoTracking().ToList();

        var RequiredTransactions = _context.Transactions.Where(t => t.CustomerId == id);

       
       var RequiredProducts = new List<Product>();

       foreach(Transaction t in RequiredTransactions)
       {
            foreach(Product p in t.Products)
            {
                RequiredProducts.Add(p);
            }
       }
          return RequiredProducts;
        }




        public void Update(int id, Product product)
        {
            var TBUProduct = _context.Products.Find(id);

            if(TBUProduct is null)
            {
                throw new InvalidOperationException();
            }

            TBUProduct = product;

        }

    }
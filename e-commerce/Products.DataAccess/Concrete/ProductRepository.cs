using Products.DataAccess.Abstract;
using Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.DataAccess.Concrete
{
    public class ProductRepository : IProductRepository
    {
        public Product CreateProduct(Product product)
        {
            using (var productDbContext = new ProductsDbContext())
            {
                productDbContext.Products.Add(product);
                productDbContext.SaveChanges();
                return product;
            }
        }

        public void DeleteProduct(int id)
        {
            using (var productDbContext = new ProductsDbContext())
            {
                var deleteproduct = GetProductById(id);
                productDbContext.Products.Remove(deleteproduct);
                productDbContext.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            using (var productDbContext = new ProductsDbContext())
            {
                return productDbContext.Products.ToList();                 
            }
        }

        public Product GetProductById(int id)
        {
            using (var productDbContext = new ProductsDbContext())
            {
                return productDbContext.Products.Find(id);
            }
        }

        public Product UpdateProduct(Product product)
        {
            using (var productDbContext = new ProductsDbContext())
            {
                productDbContext.Products.Update(product);
                productDbContext.SaveChanges();
                return product;
            }
        }
    }
}

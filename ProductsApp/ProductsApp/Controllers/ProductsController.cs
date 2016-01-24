using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Zupa", Category = "Groceries", Price = 0.36M },
            new Product { Id = 2, Name = "Bułka", Category = "Groceries", Price = 0.15M },
            new Product { Id = 3, Name = "Kiełbasa", Category = "Groceries", Price = 3.77M },
            new Product { Id = 4, Name = "Audi", Category = "cars", Price = 29014.44M },
            new Product { Id = 5, Name = "BMW", Category = "cars", Price = 24178.7M },
            new Product { Id = 6, Name = "Volkswagen", Category = "cars", Price = 19342.96M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

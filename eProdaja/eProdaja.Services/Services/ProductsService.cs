using eProdaja.Model;
using eProdaja.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services.Services
{
    public class ProductsService : IProductsService
    {
        List<Products> products = new List<Products>()
        {
            new Products{ProductId = 1, ProductName ="Laptop"}
        };
        public IList<Products> Get()
        {
            return products;
        }
    }
}

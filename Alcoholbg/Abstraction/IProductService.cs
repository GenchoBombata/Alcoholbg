using Alcoholbg.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alcoholbg.Abstraction
{
   public interface IProductService
    {
        bool Create(string ProductName, int BrandId, int CategoryId, string Picture, int Quantity, decimal Price, decimal Dicount);
        bool Update(int ProductId, string ProductName, int BrandId, int CategoryId, string Picture, int Quantity, decimal Price, decimal Dicount);
        List<Product> GetProducts();
        Product GetProductById(int productId);
        bool RemoveById(int productId);
        List<Product> GetProducts(string searchStringCategoryName, string searchBrandName);
    }
}

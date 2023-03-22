using Alcoholbg.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alcoholbg.Abstraction
{
  public interface ICategoryService
    {
        List<Category> GetCategories();

        Category GetCategoryById(int categoryId);

        List<Product> GetProductsBycategory(int categoryId);
    }
}

using Alcoholbg.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alcoholbg.Abstraction
{
  public interface IBrandService
    {
        List<Brand> GetBrands();

        Brand GetBrandById(int brandId);

        List<Product> GetAlcoholbgByBrand(int brandId);
    }
}

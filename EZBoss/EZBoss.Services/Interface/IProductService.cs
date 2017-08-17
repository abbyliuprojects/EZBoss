using EZBoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZBoss.Services.Interface
{
    public interface IProductService : IBaseService
    {
        IEnumerable<ProductInfo> GetProductData(string storeId);
    }
}

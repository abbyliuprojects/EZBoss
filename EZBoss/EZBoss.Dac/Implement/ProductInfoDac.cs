using EZBoss.Dac.Interface;
using EZBoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZBoss.Dac.Implement
{
    public class ProductInfoDac : BaseDac, IProductInfoDac
    {
        public IEnumerable<ProductInfo> GetProductDataByStoreId(string storeId)
        {
            return Context.ProductInfo.Where(x => x.StoreId.Equals(storeId)); 
        }
    }
}

using EZBoss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZBoss.Dac.Interface
{
    public interface IProductInfoDac : IBaseDac
    {
        IEnumerable<ProductInfo> GetProductDataByStoreId(string storeId);
    }
}

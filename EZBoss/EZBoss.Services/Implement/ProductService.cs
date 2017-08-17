using EZBoss.Dac.Implement;
using EZBoss.Dac.Interface;
using EZBoss.Models;
using EZBoss.Services.Interface;
using System.Collections.Generic;

namespace EZBoss.Services.Implement
{
    public class ProductService : BaseService, IProductService
    {
        private IProductInfoDac _productInfoDac = new ProductInfoDac();

        public IEnumerable<ProductInfo> GetProductData(string storeId)
        {
            return  _productInfoDac.GetProductDataByStoreId(storeId);
        }
    }
}

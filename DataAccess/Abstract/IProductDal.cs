using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void add(Product product);
        void delete(string productCode);
        void update(Product product);
        List<ProductDetailDto> getOutOfStock(int limit);
        Product getProductByCode(string code);
        Product getProductById(int productId);
        List<ProductDetailDto> getProductDetails(string productName, string productCode, int supplierId);
    }
}

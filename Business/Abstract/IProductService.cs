using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult add(Product product);
        IResult delete(string productCode);
        IResult update(Product product);
        IDataResult<List<ProductDetailDto>> getOutOfStock(int limit);
        IDataResult<Product> getProductByCode(string code);
        IDataResult<Product> getProductById(int productId);
        IDataResult<List<ProductDetailDto>> getProductDetails(string productName, string productCode, int supplierId);
    }
}

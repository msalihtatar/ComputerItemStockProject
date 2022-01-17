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
        IDataResult<List<ProductDetailDto>> getOutOfStock(int limit);
        IDataResult<Product> getProductByCode(string code);
        IDataResult<Product> getProductById(int productId);
        IDataResult<List<ProductDetailDto>> getProductDetails(string productName, string productCode, int supplierId);
        IResult addProductToStock(Product product, int StockAmount);
        IResult deleteProductToStock(int ProductID, string ProductCode);
        IResult updateProductInStock(Product product, Stock stock);
    }
}

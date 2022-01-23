using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IStockService _stockService;
        ISupplierService _supplierService;
        public ProductManager(IProductDal productDal, IStockService stockService, ISupplierService supplierService)
        {
            _productDal = productDal;
            _stockService = stockService;
            _supplierService = supplierService;
        }

        public IResult add(Product product)
        {
            try
            {
                _productDal.add(product);
                return new SuccessResult("Ürün Eklendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Ürün eklenirken bir hata oluştu.");
            }
        }

        public IResult addProductToStock(Product product, int StockAmount)
        {
            try
            {
                var result = add(product);

                if (result.Success)
                {
                    var hasProduct = getProductByCode(product.ProductCode);

                    if (hasProduct.Success)
                    {
                        Stock stock = new Stock
                        {
                            ProductID = hasProduct.Data.ProductID,
                            StockAmount = StockAmount
                        };

                        var hasStock = _stockService.add(stock);

                        if (hasStock.Success)
                        {
                            return new SuccessResult(hasStock.Message); 
                        }
                        return new ErrorResult(hasStock.Message);
                    }
                    return new ErrorResult(hasProduct.Message);
                }
                return new ErrorResult(result.Message);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata mesajı: " + ex.Message);
            }
        }

        public IResult deleteProductToStock(int ProductID, string ProductCode)
        {
            try
            {
                var result = _stockService.delete(ProductID);

                if (result.Success)
                {
                    var result2 = delete(ProductCode);

                    if (result2.Success)
                    {
                        return new SuccessResult(result2.Message);
                    }
                    return new ErrorResult(result2.Message);
                }
                return new ErrorResult(result.Message);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata mesajı: " + ex.Message);
            }
        }

        public IResult updateProductInStock(Product product, Stock stock)
        {
            try
            {
                var result = _stockService.update(stock);
                if (result.Success)
                {
                    var result1 = update(product);

                    if (result1.Success)
                    {
                        return new SuccessResult(result1.Message);
                    }
                    return new ErrorResult(result1.Message);
                }
                return new ErrorResult(result.Message);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata mesajı: " + ex.Message);
            }
        }

        public IResult delete(string productCode)
        {
            try
            {
                _productDal.delete(productCode);
                return new SuccessResult("Ürün Silindi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult("Hata Mesajı: " + ex.Message);
            }
        }

        public IDataResult<List<ProductDetailDto>> getOutOfStock(int limit)
        {
            try
            {
                var result = _productDal.getOutOfStock(limit);

                if (result != null && result.Count > 0)
                {
                    return new SuccessDataResult<List<ProductDetailDto>>(result, "Stoğu azalan ürünler listelendi.");
                }
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Ürün bulunamadı.");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Hata Mesajı: " + e.Message);
            }
        }

        public IDataResult<Product> getProductByCode(string productCode)
        {
            try
            {
                var result = _productDal.getProductByCode(productCode);

                if (result != null)
                {
                    return new SuccessDataResult<Product>(result, "Ürünler listelendi.");
                }
                return new ErrorDataResult<Product>(null, "Ürün bulunamadı.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Product>(null, "Hata mesajı: " + ex.Message);
            }
        }

        public IDataResult<List<ProductDetailDto>> getProductDetails(string productName, string productCode, int supplierId)
        {
            try
            {
                var result = _productDal.getProductDetails(productName,productCode,supplierId);

                if (result != null && result.Count > 0)
                {
                    return new SuccessDataResult<List<ProductDetailDto>>(result, "Ürünler listelendi.");
                }
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Ürün bulunamadı.");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Hata mesajı: " + e.Message);
            }
        }

        public IDataResult<Product> getProductById(int productId)
        {
            var result = _productDal.getProductById(productId);

            if (result != null)
            {
                return new SuccessDataResult<Product>(result, "Ürün getirildi.");
            }
            return new ErrorDataResult<Product>(null, "Ürün bulunamadı.");
        }

        public IResult update(Product product)
        {
            try
            {
                _productDal.update(product);
                return new SuccessResult("Ürün güncellendi.");
            }
            catch (Exception e)
            {
                return new ErrorResult("Hata mesajı: " + e.Message);
            }
        }
    }
}

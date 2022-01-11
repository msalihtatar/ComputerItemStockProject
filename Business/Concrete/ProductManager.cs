using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
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

        public IResult delete(string productCode)
        {
            try
            {
                _productDal.delete(productCode);
                return new SuccessResult("Ürün Silindi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Ürün silinirken bir hata oluştu.");
            }
        }

        public IDataResult<List<ProductDetailDto>> getOutOfStock(int limit)
        {
            try
            {
                var result = _productDal.getOutOfStock(limit);

                if (result != null)
                {
                    return new SuccessDataResult<List<ProductDetailDto>>(result, "Stoğu azalan ürünler listelendi.");
                }
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Ürünler getirilirken bir hata oluştu.");
            }
            catch (Exception e)
            {
                throw e;
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
                return new ErrorDataResult<Product>(null, "Ürünler getirilirken bir hata oluştu.");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<List<ProductDetailDto>> getProductDetails(string productName, string productCode, int supplierId)
        {
            try
            {
                var result = _productDal.getProductDetails(productName,productCode,supplierId);

                if (result != null)
                {
                    return new SuccessDataResult<List<ProductDetailDto>>(result, "Ürünler listelendi.");
                }
                return new ErrorDataResult<List<ProductDetailDto>>(null, "Ürünler getirilirken bir hata oluştu.");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IDataResult<Product> getProductById(int productId)
        {
            var result = _productDal.getProductById(productId);

            if (result != null)
            {
                return new SuccessDataResult<Product>(result, "Ürün getirildi.");
            }
            return new ErrorDataResult<Product>(null, "Ürün getirilirken bir hata oluştu.");
        }

        public IResult update(Product product)
        {
            try
            {
                _productDal.update(product);
                return new SuccessResult("Ürün güncellendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Ürün güncellenirken bir hata oluştu.");
            }
        }
    }
}

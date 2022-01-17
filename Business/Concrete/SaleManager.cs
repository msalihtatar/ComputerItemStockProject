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
    public class SaleManager : ISaleService
    {
        ISaleDal _saleDal;
        IProductService _productService;
        ICustomerService _customerService;
        IStockService _stockService;
        public SaleManager(ISaleDal saleDal,IProductService productService, ICustomerService customerService,IStockService stockService)
        {
            _saleDal = saleDal;
            _productService = productService;
            _customerService = customerService;
            _stockService = stockService;
        }

        public IDataResult<int> add(Sale sale)
        {
            try
            {
                var saleId = _saleDal.add(sale);
                return new SuccessDataResult<int>(saleId,"Satış Tamamlandı.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<int>("Hata mesajı: "+ ex.Message);
            }
        }

        public IDataResult<SoldProductDetailDto> GetSoldProduct(int SaleID)
        {
            try
            {
                var sale = getSaleById(SaleID);

                if (sale.Success)
                {
                    var product = _productService.getProductById(sale.Data.ProductID);
                    if (!product.Success)
                    {
                        return new ErrorDataResult<SoldProductDetailDto>(null, product.Message);
                    }

                    var customer = _customerService.getCustomerById(sale.Data.CustomerID);
                    if (!customer.Success)
                    {
                        return new ErrorDataResult<SoldProductDetailDto>(null, customer.Message);
                    }

                    SoldProductDetailDto soldProduct = new SoldProductDetailDto
                    {
                        PhoneNumber = customer.Data.PhoneNumber,
                        ProductCode = product.Data.ProductCode,
                        SaleDate = sale.Data.SaleDate
                    };

                    return new SuccessDataResult<SoldProductDetailDto>(soldProduct, "Satış bilgisi getirilmiştir.");
                }
                return new ErrorDataResult<SoldProductDetailDto>(null, sale.Message);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<SoldProductDetailDto>(null, ex.Message);
            }
        }

        public IDataResult<Sale> getSaleById(int saleId)
        {
            try
            {
                var result = _saleDal.getSaleById(saleId);

                if (result != null)
                {
                    return new SuccessDataResult<Sale>(result, "Satış bilgisi listelendi.");
                }
                return new ErrorDataResult<Sale>(null, "Satış bilgisi getirilirken bir hata oluştu.");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<Sale>(null, e.Message);
            }
        }

        public IDataResult<List<SaleDetailDto>> getSaleDetails(DateTime startDate, DateTime endDate)
        {
            try
            {
                var result = _saleDal.getSaleDetails(startDate,endDate);

                if (result != null)
                {
                    return new SuccessDataResult<List<SaleDetailDto>>(result, "Satışı yapılan ürünler listelendi.");
                }
                return new ErrorDataResult<List<SaleDetailDto>>(null, "Ürünler getirilirken bir hata oluştu.");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<SaleDetailDto>>(null, "Hata Mesajı: " + e.Message);
            }
        }

        public IDataResult<int> MakeSale(string ProductCode, string PhoneNo)
        {
            try
            {
                var product = _productService.getProductByCode(ProductCode);

                if (product.Success)
                {
                    var customer = _customerService.GetCustomerByPhoneNumber(PhoneNo);

                    if (customer.Success)
                    {
                        var stock = _stockService.getStockByProductID(product.Data.ProductID);

                        if (stock.Success)
                        {
                            Stock updatedStock = new Stock
                            {
                                ProductID = stock.Data.ProductID,
                                StockAmount = stock.Data.StockAmount - 1,
                                SaleAmount = stock.Data.SaleAmount + 1,
                                ReturnAmount = stock.Data.ReturnAmount
                            };
                            var update = _stockService.update(updatedStock);

                            if (update.Success)
                            {
                                Sale sale = new Sale
                                {
                                    ProductID = product.Data.ProductID,
                                    SaleDate = DateTime.Now,
                                    CustomerID = customer.Data.CustomerID
                                };
                                var satis = add(sale);

                                if (satis.Success)
                                {
                                    return new SuccessDataResult<int>(satis.Data, satis.Message);
                                }
                                return new ErrorDataResult<int>(satis.Message);
                            }
                            return new ErrorDataResult<int>(update.Message);
                        }
                        return new ErrorDataResult<int>(stock.Message);
                    }
                    return new ErrorDataResult<int>(customer.Message);
                }
                return new ErrorDataResult<int>(product.Message);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<int>("Hata mesajı: " + ex.Message);
            }
        }
    }
}

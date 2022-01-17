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
    public class ReturnManager : IReturnService
    {
        IReturnDal _returnDal;
        ISaleService _saleService;
        ICustomerService _customerService;
        IProductService _productService;
        IStockService _stockService;
        public ReturnManager(IReturnDal returnDal, ISaleService saleService,ICustomerService customerService,IProductService productService,IStockService stockService)
        {
            _returnDal = returnDal;
            _saleService = saleService;
            _customerService = customerService;
            _productService = productService;
            _stockService = stockService;
        }

        public IResult add(Return return1)
        {
            try
            {
                _returnDal.add(return1);
                return new SuccessResult("İade Alındı.");
            }
            catch (Exception)
            {
                return new ErrorResult("İade alınırken bir hata oluştu.");
            }
        }

        public IResult returnProduct(int SaleID)
        {
            try
            {
                var sale = _saleService.getSaleById(SaleID);

                if (sale.Success)
                {
                    var stock = _stockService.getStockByProductID(sale.Data.ProductID);

                    if (stock.Success)
                    {
                        Stock updatedStock = new Stock
                        {
                            ProductID = stock.Data.ProductID,
                            StockAmount = stock.Data.StockAmount + 1,
                            ReturnAmount = stock.Data.ReturnAmount + 1,
                            SaleAmount = stock.Data.SaleAmount
                        };

                        var update = _stockService.update(updatedStock);

                        if (update.Success)
                        {
                            Return iade = new Return
                            {
                                SaleID = SaleID,
                                ReturnDate = DateTime.Now
                            };
                            var hasReturned = add(iade);

                            if (hasReturned.Success)
                            {
                                return new SuccessResult(hasReturned.Message);
                            }
                            return new ErrorResult(hasReturned.Message);
                        }
                        return new ErrorResult(update.Message);
                    }
                    return new ErrorResult(stock.Message);
                }
                return new ErrorResult(sale.Message);
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<SaleReturnDetailDto> getSaleReturnDetails(int SaleID)
        {
            var result = _returnDal.getSaleReturnDetails(SaleID);
            if (result != null)
            {
                return new SuccessDataResult<SaleReturnDetailDto>(result, "Satışlar listelendi.");
            }
            return new ErrorDataResult<SaleReturnDetailDto>(null, "Satış bilgileri getirilirken bir hata oluştu.");
        }
    }
}

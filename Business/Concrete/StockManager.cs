using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        IStockDal _stockDal;
        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }
        public IResult add(Stock stock)
        {
            try
            {
                _stockDal.add(stock);
                return new SuccessResult("Yeni Ürün Stoğa Eklendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Yeni ürün stoğa eklenirken bir hata oluştu.");
            }
        }

        public IResult delete(int productId)
        {
            try
            {
                _stockDal.delete(productId);
                return new SuccessResult("Ürün Stoktan Silindi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Ürün stoktak silinirken bir hata oluştu.");
            }
        }

        public IDataResult<Stock> getStockByProductID(int productID)
        {
            var result = _stockDal.getStockByProductID(productID);

            if (result != null)
            {
                return new SuccessDataResult<Stock>(result, "Stok getirildi.");
            }
            return new ErrorDataResult<Stock>(null, "Stok bilgisi bulunamadı.");
        }

        public IResult update(Stock stock)
        {
            try
            {
                _stockDal.update(stock);
                return new SuccessResult("Stoktaki ürün güncellendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Stoktaki ürün güncellenirken bir hata oluştu.");
            }
        }
    }
}

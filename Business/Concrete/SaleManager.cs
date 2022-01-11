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
        public SaleManager(ISaleDal saleDal)
        {
            _saleDal = saleDal;
        }

        public IResult add(Sale sale)
        {
            try
            {
                _saleDal.add(sale);
                return new SuccessResult("Satış Eklendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Satış eklenirken bir hata oluştu.");
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
                throw e;
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
                throw e;
            }
        }
    }
}

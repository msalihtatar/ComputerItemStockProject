using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleService
    {
        IResult add(Sale sale);
        IDataResult<Sale> getSaleById(int saleId);
        IDataResult<List<SaleDetailDto>> getSaleDetails(DateTime startDate, DateTime endDate);
    }
}

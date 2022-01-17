using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ISaleDal
    {
        int add(Sale sale);
        List<SaleDetailDto> getSaleDetails(DateTime startDate, DateTime endDate);
        Sale getSaleById(int saleId);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IReturnService
    {
        IDataResult<SaleReturnDetailDto> getSaleReturnDetails(int SaleID);
        IResult returnProduct(int SaleID);
    }
}

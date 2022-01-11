using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStockService
    {
        IResult add(Stock stock);
        IResult delete(int stockId);
        IResult update(Stock stock);
        IDataResult<Stock> getStockByProductID(int productID);
    }
}

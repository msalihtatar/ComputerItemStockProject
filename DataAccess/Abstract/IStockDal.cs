using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IStockDal
    {
        void add(Stock stock);
        void delete(int productId);
        void update(Stock stock);
        Stock getStockByProductID(int productID);
    }
}

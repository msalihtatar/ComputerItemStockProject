using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IReturnDal
    {
        void add(Return return1);

        SaleReturnDetailDto getSaleReturnDetails(int SaleID);
    }
}

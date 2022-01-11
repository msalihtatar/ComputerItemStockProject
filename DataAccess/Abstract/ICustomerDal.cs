using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICustomerDal
    {
        void add(Customer customer);
        List<SaleReturnDetailDto> getSaleReturnDetails();
        Customer getCustomerById(int customerId);
        Customer GetCustomerByPhoneNumber(string phoneNo);
    }
}

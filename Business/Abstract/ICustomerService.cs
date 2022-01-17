using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult add(Customer customer);
        IDataResult<Customer> GetCustomerByPhoneNumber(string phoneNo);
        IDataResult<Customer>getCustomerById(int customerId);
    }
}

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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult add(Customer customer)
        {
            try
            {
                _customerDal.add(customer);
                return new SuccessResult("Müşteri Eklendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("Müşteri eklenirken bir hata oluştu.");
            }
        }

        public IDataResult<Customer> getCustomerById(int customerId)
        {
            var result = _customerDal.getCustomerById(customerId);
            if (result != null)
            {
                return new SuccessDataResult<Customer>(result, "Müşteri getirildi.");
            }
            return new ErrorDataResult<Customer>(null, "Müşteri getirilirken bir hata oluştu.");
        }

        public IDataResult<Customer> GetCustomerByPhoneNumber(string phoneNo)
        {
            var result = _customerDal.GetCustomerByPhoneNumber(phoneNo);
            if (result != null)
            {
                return new SuccessDataResult<Customer>(result, "Müşteri getirildi.");
            }
            return new ErrorDataResult<Customer>(null, "Müşteri getirilirken bir hata oluştu.");
        }
    }
}

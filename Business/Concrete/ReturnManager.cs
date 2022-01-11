using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ReturnManager : IReturnService
    {
        IReturnDal _returnDal;
        public ReturnManager(IReturnDal returnDal)
        {
            _returnDal = returnDal;
        }

        public IResult add(Return return1)
        {
            try
            {
                _returnDal.add(return1);
                return new SuccessResult("İade Eklendi.");
            }
            catch (Exception)
            {
                return new ErrorResult("İade eklenirken bir hata oluştu.");
            }
        }
    }
}

using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDal _supplierDal;
        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }
        public IDataResult<List<Supplier>> getAll()
        {
            var result = _supplierDal.getAll();

            if (result != null)
            {
                return new SuccessDataResult<List<Supplier>>(result, "Tedarikçiler listelendi.");
            }
            return new ErrorDataResult<List<Supplier>>(null, "Tedarikçi bulunamadı.");
        }
    }
}

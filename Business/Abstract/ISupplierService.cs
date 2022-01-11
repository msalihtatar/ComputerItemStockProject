using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISupplierService
    {
        IDataResult<List<Supplier>> getAll();
    }
}

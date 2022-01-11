using Dapper;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class DpSupplierDal : ISupplierDal
    {
        IDbConnection _dbConnection;
        public DpSupplierDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public List<Supplier> getAll()
        {
            try
            {
                string sql = @"select * from Suppliers";

                var suppliers = _dbConnection.Query<Supplier>(sql).ToList();

                return suppliers;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

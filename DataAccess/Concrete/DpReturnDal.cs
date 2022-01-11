using Dapper;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Concrete
{
    public class DpReturnDal : IReturnDal
    {
        IDbConnection _dbConnection;
        public DpReturnDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void add(Return return1)
        {
            try
            {
                string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                                        @"INSERT INTO Returns (SaleID, ReturnDate)
                                            VALUES ({0},'{1}')", return1.SaleID, return1.ReturnDate);

                _dbConnection.ExecuteScalar(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

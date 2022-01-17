using Dapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public SaleReturnDetailDto getSaleReturnDetails(int SaleID)
        {
            try
            {
                string sql = @"Select s.SaleID,
		                              c.FirstName,
		                              c.LastName,
		                              c.PhoneNumber,
		                              p.ProductCode,
                                      p.Description,
		                              p.Price,
		                              s.SaleDate,
		                              r.ReturnDate
                              From Sales s 
                              Left Join Returns r on r.SaleID = s.SaleID
                              Inner Join Customers c on c.CustomerID = s.CustomerID 
                              Inner Join Products p on p.ProductID = s.ProductID
                              Where s.SaleID = " + SaleID;

                var result = _dbConnection.Query<SaleReturnDetailDto>(sql).FirstOrDefault();

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

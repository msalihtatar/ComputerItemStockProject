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
    public class DpCustomerDal:ICustomerDal
    {
        IDbConnection _dbConnection;
        public DpCustomerDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void add(Customer customer)
        {
            try
            {
                string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                                        @"INSERT INTO Customers (FirstName,LastName,PhoneNumber)
                                            VALUES ('{0}','{1}','{2}')", customer.FirstName,customer.LastName,
                                                                                            customer.PhoneNumber);

                _dbConnection.ExecuteScalar(sql);
            }
            catch (Exception e)
            {
                throw e; 
            }
        }

        public Customer getCustomerById(int customerId)
        {
            try
            {
                string sql = @"select * from Customers Where CustomerID = " + customerId;

                var result = _dbConnection.Query<Customer>(sql).FirstOrDefault();

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Customer GetCustomerByPhoneNumber(string phoneNo)
        {
            try
            {
                string sql = @"Select * From Customers Where PhoneNumber = '" + phoneNo + "'";

                var result = _dbConnection.Query<Customer>(sql).FirstOrDefault();

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SaleReturnDetailDto> getSaleReturnDetails()
        {
            try
            {
                string sql = @"Select s.SaleID,
		                              c.FirstName,
		                              c.LastName,
		                              c.PhoneNumber,
		                              p.ProductCode,
		                              p.Price,
		                              s.SaleDate,
		                              r.ReturnDate
                              From Customers c 
                              Inner Join Sales s on s.CustomerID = c.CustomerID
                              Left Join Returns r on r.SaleID = s.SaleID
                              Inner Join Products p on p.ProductID = s.ProductID";

                var result = _dbConnection.Query<SaleReturnDetailDto>(sql).ToList();

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

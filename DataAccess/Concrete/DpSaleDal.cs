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
    public class DpSaleDal : ISaleDal
    {
        IDbConnection _dbConnection;
        public DpSaleDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public int add(Sale sale)
        {
            try
            {
                string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                                        @"INSERT INTO Sales (ProductID, CustomerID, SaleDate)
                                            VALUES ({0},{1},'{2}') SELECT CAST(scope_identity() AS int)", sale.ProductID,sale.CustomerID,sale.SaleDate);

                var saleID = _dbConnection.ExecuteScalar<int>(sql);

                return saleID;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Sale getSaleById(int saleId)
        {
            try
            {
                string sql = string.Format(@"Select * From Sales where SaleID = {0}", saleId);

                var product = _dbConnection.Query<Sale>(sql).FirstOrDefault();

                return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<SaleDetailDto> getSaleDetails(DateTime startDate, DateTime endDate)
        {
            try
            {
                endDate = endDate.AddYears(1);
                
                string sql = string.Format(@"Select  p.ProductCode,
                                                     p.ProductName,
                                                     Count(sa.SaleID) SaleAmount,
                                                     Count(r.ReturnID) ReturnAmount, 
                                                     s.StockAmount StockAmount,
                                                     p.Price,
                                                     p.PurchasePrice,
                                                     sp.SupplierName
                                              From Sales sa 
                                              Left Join Returns r on r.SaleID = sa.SaleID
                                              Inner Join Products p on sa.ProductID = p.ProductID
                                              Inner Join Stocks s on s.ProductID = p.ProductID
                                              Inner Join Suppliers sp on sp.SupplierID = p.SupplierID
                                              Where sa.SaleDate <= '{0}' and sa.SaleDate >= '{1}'
                                              Group By p.ProductCode, p.ProductName,p.Price,p.PurchasePrice,
                                                       s.StockAmount,sp.SupplierName", endDate,startDate);

                var product = _dbConnection.Query<SaleDetailDto>(sql).ToList();

                return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

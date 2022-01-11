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
    public class DpStockDal : IStockDal
    {
        IDbConnection _dbConnection;
        public DpStockDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void add(Stock stock)
        {
            try
            {
                string sql = string.Format(@"INSERT INTO Stocks (StockAmount,ProductID)
                                            VALUES ({0},{1})", stock.StockAmount,stock.ProductID);

                _dbConnection.ExecuteScalar(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void delete(int productId)
        {
            try
            {
                string sql = string.Format(@"Delete From Stocks Where ProductID = {0}", productId);

                _dbConnection.Execute(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Stock getStockByProductID(int productID)
        {
            try
            {
                string sql = @"Select * from Stocks Where ProductID = " + productID;

                var stocks = _dbConnection.Query<Stock>(sql).FirstOrDefault();

                return stocks;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update(Stock stock)
        {
            try
            {
                string where = string.Empty;
                if (!string.IsNullOrEmpty(stock.ProductID.ToString()))
                {
                    where += " ProductID = " + stock.ProductID;
                }
                if (!string.IsNullOrEmpty(stock.StockAmount.ToString()))
                {
                    where += ", StockAmount = " + stock.StockAmount;
                }
                if (!string.IsNullOrEmpty(stock.ReturnAmount.ToString()))
                {
                    where += ", ReturnAmount = " + stock.ReturnAmount;
                }
                if (!string.IsNullOrEmpty(stock.SaleAmount.ToString()))
                {
                    where += ", SaleAmount = " + stock.SaleAmount;
                }
                string sql = string.Format(@"Update Stocks Set  {0}  Where ProductID = {1}", where, stock.ProductID);

                _dbConnection.Execute(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

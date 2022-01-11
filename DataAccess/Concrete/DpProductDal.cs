using Dapper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class DpProductDal : IProductDal
    {
        IDbConnection _dbConnection;
        public DpProductDal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void add(Product product)
        {
            try
            {
                string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                                        @"INSERT INTO Products (ProductName,ProductCode,Brand,Origin,Description,SupplierID,Price,PurchasePrice)
                                            VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6},{7})", product.ProductName,
                                            product.ProductCode, product.Brand, product.Origin, product.Description,
                                            product.SupplierID,product.Price,product.PurchasePrice);

                _dbConnection.ExecuteScalar(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void delete(string productCode)
        {
            try
            {
                string sql = string.Format(@"DELETE From Products Where ProductCode = '{0}'", productCode);

                _dbConnection.Execute(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ProductDetailDto> getOutOfStock(int limit)
        {
            try
            {
                string sql = string.Format(@"Select * 
                                             From Products p
                                             Left Join Stocks s on s.ProductID = p.ProductID
                                             Inner Join Suppliers sp on sp.SupplierID = p.SupplierID
                                             Where s.StockAmount <= " + limit);

                var product = _dbConnection.Query<ProductDetailDto>(sql).ToList();

                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product getProductByCode(string productCode)
        {
            try
            {
                string sql = string.Format(@"Select * From Products where ProductCode = '{0}'",productCode);

                var product = _dbConnection.Query<Product>(sql).FirstOrDefault();

                return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<ProductDetailDto> getProductDetails(string productName, string productCode, int supplierId)
        {
            try
            {
                string where = string.Empty;
                if (!string.IsNullOrEmpty(productName))
                {
                    where += " and p.ProductName = '" + productName + "' ";
                }
                if (!string.IsNullOrEmpty(productCode))
                {
                    where += " and p.ProductCode = '" + productCode + "' ";
                }
                if (!string.IsNullOrEmpty(supplierId.ToString()) && supplierId != -1)
                {
                    where += " and sp.SupplierID = " + supplierId;
                }

                string sql = string.Format(@"Select * from Products p
                               Left join Stocks s on s.ProductID = p.ProductID
                               Inner join Suppliers sp on sp.SupplierID = p.SupplierID
                               Where 1=1 {0}
                               Order By p.ProductID ",where);

                var result = _dbConnection.Query<ProductDetailDto>(sql).ToList();
                
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Product getProductById(int productId)
        {
            try
            {
                string sql = @"Select * from Products where ProductID = " + productId;

                var product = _dbConnection.Query<Product>(sql).FirstOrDefault();

                return product;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void update(Product product)
        {
            try
            {
                string where = string.Empty;
                if (!string.IsNullOrEmpty(product.ProductName))
                {
                    where += " ProductName = '" + product.ProductName + "',";
                }
                if (!string.IsNullOrEmpty(product.ProductCode))
                {
                    where += " ProductCode = '" + product.ProductCode + "',";
                }
                if (!string.IsNullOrEmpty(product.Origin))
                {
                    where += " Origin = '" + product.Origin + "',";
                }
                if (!string.IsNullOrEmpty(product.Brand))
                {
                    where += " Brand = '" + product.Brand + "',";
                }
                if (!string.IsNullOrEmpty(product.Description))
                {
                    where += " Description = '" + product.Description + "',";
                }
                if (!string.IsNullOrEmpty(product.SupplierID.ToString()))
                {
                    where += " SupplierID = " + product.SupplierID;
                }

                string sql = string.Format(System.Globalization.CultureInfo.InvariantCulture,
                                            @"Update Products Set  {0}, Price = {1}, PurchasePrice = {2} Where ProductID = {3}", 
                                            where, product.Price, product.PurchasePrice, product.ProductID);

                _dbConnection.Execute(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}

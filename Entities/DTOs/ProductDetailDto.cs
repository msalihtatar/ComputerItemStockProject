using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public int StockID { get; set; }
        public string SupplierName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
        public float PurchasePrice { get; set; }
        public string Origin { get; set; }
        public int StockAmount { get; set; }
        public int ReturnAmount { get; set; }
        public int SaleAmount { get; set; }

    }
}

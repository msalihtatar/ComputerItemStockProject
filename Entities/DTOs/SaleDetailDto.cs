using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SaleDetailDto:IDto
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string SupplierName { get; set; }
        public float Price { get; set; }
        public float PurchasePrice { get; set; }
        public int StockAmount { get; set; }
        public int SaleAmount { get; set; }
        public int ReturnAmount { get; set; }
    }
}

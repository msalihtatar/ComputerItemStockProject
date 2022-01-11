using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Stock:IEntity
    {
        public int StockID { get; set; }
        public int ProductID { get; set; }
        public int StockAmount { get; set; }
        public int SaleAmount { get; set; }
        public int ReturnAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}

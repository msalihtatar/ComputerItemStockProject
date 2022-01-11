using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Origin { get; set; }
        public float Price { get; set; }
        public float PurchasePrice { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
    }
}

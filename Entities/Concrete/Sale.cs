using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sale:IEntity
    {
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public DateTime SaleDate { get; set; }
    }
}

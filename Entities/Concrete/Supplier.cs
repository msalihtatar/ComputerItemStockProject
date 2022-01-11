using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Supplier:IEntity
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Mail { get; set; }
    }
}

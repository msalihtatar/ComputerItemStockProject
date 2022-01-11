using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Return:IEntity
    {
        public int ReturnID { get; set; }
        public int SaleID { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

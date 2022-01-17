using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SaleReturnDetailDto:IDto
    {
        public int SaleID { get; set; }
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}

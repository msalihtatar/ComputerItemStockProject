using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class SoldProductDetailDto:IDto
    {
        public string ProductCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SaleDate { get; set; }
    }
}

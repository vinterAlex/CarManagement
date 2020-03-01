using System;
using System.Collections.Generic;

namespace CarManagement.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductDescription { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

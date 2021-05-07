using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    public class ProductInventoryModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Suffix { get; set; }
        public string ManufacturerName { get; set; }
        public string ModelNumber { get; set; }
        public string ManufactureDate { get; set; }
        public string ProductCategories { get; set; }
        public string ModelName { get; set; }
        public string CostPerUnit { get; set; }
        public int Quantity { get; set; }
        public string ProductDescription { get; set; }
    }
}

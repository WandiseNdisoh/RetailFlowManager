using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailFlowManager.Models
{
    public class Product
    {
        public int Id { get; set; } // The unique ID for the database
        public string Name { get; set; }
        public string SKU { get; set; } // Stock Keeping Unit (Unique code)
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.Now;
    }
}

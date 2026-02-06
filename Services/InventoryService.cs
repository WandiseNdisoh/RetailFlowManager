using RetailFlowManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailFlowManager.Services
{
    public class InventoryService
    {
        public bool IsStockAvailable(Product product, int requestedAmount)
        {
            if (requestedAmount <= 0) return false;
            return product.StockQuantity >= requestedAmount;
        }
    }
}

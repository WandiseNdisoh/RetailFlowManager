using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailFlowManager.Services
{
    public class InventoryService
    {
        public bool IsStockAvailable(int currentStock, int requestedAmount)
        {
            if (requestedAmount <= 0) return false;
            return currentStock >= requestedAmount;
        }
    }
}

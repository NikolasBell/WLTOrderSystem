using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLTDataObjects;
using WLTDataAccess;

namespace WLTControlLogic
{
    public class SalesManager
    {
        SaleDataAccess _saleDataAccess = new SaleDataAccess();

        public DailySale Startup() //Make it check for sale instead of creating new one.
        {
            // DailySale dailySale = _saleDataAccess.RetrieveDailySale(DateTime.Now);
            DailySale dailySale = newDaily();
            return dailySale;
        }

        public DailySale newDaily()
        {
            DailySale dailySale = new DailySale();
            dailySale.Date = DateTime.Now;
            dailySale.Orders = new List<Order>();
            return dailySale;
        }//End newDaily

        public decimal getExitPrice(Item item)
        {
            return item.Price * item.Quantity;
        }

        public decimal getTaxPrice(Item item)
        {
            decimal taxPrice = 0;
            if (item.isTaxed)
            {
                taxPrice = getExitPrice(item) * Item.TaxRate;
            }
            return taxPrice;
        }

        public decimal getTotalPrice(Item item) {
            return getExitPrice(item) + getTaxPrice(item);
        }
    }
}

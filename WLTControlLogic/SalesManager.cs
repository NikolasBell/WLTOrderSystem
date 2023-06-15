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

        public DailySale getDailySheet(DateTime date) //Just a passthrough function for presentation layer to data layer
        {
            DailySale dailySale = _saleDataAccess.retrieveDailySale(date);
            return dailySale;
        }

        public void saveDailySheet(DailySale dailySale) //Just a passthrough function for presentation layer to data layer
        {
            _saleDataAccess.saveDailySale(dailySale);
        }

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

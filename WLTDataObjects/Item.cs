using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class Item
    {
        public Vendor VendorCode { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public static decimal _taxRate { get; } = 0.07m; //Tax is a constant 7%
        public decimal Discount { get; private set; }
        public Boolean isTaxed { get; private set; }
        public string ItemNotes { get; private set; }
    }
}

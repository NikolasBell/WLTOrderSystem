using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class Item
    {
        public string VendorCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public static decimal TaxRate { get; } = 0.07m; //Tax is a constant 7%
        public decimal Discount { get; set; }
        public Boolean isTaxed { get; set; }
        public string ItemNotes { get; set; }
    }
}

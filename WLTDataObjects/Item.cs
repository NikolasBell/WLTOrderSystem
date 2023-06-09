﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class Item
    {
        public VendorCode VendorCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public static decimal TaxRate { get; } = 0.07m; //Tax is a constant 7%
        public Boolean isTaxed { get; set; }
        public string ItemNotes { get; set; }
    }
}

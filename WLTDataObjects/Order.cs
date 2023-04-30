using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class Order
    {
        public PaymentMethod PayType { get; set; }
        public string OrderNotes { get; set; }
        public List<Item> Items { get; set; }
    }
}

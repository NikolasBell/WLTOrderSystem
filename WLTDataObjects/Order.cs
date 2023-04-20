using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    internal class Order
    {
        public PaymentMethod PayType { get; private set; }
        public string OrderNotes { get; private set; }
        public List<Item> Items { get; private set; }
    }
}

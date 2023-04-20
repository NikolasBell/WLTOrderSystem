using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    internal class DailySale
    {
        public DateTime Date { get; set; }
        public List<Order> Orders { get; set; }
    }
}

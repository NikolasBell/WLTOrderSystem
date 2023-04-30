using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class DailySale
    {
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public List<Order> Orders { get; set; }
    }
}

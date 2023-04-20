using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public class Vendor
    {
        public string Name { get; private set; }
        public string Code { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public decimal CommissionRate { get; private set; }
    }
}

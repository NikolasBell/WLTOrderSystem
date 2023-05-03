using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WLTDataObjects
{
    public enum PaymentMethod
    {
        Unpaid,
        Cash,
        Card,
        Check,
        Other
    }

    public enum VendorCode
    {
        UNK,
        WLT,
        KM1,
        AB1,
        AB2,
        AC1,
        AH1,
        AS1,
        AZ1,
        BAE
    }

    public enum VendorName
    {
        Unknown_Vendor,
        White_Lion_Teasures,
        Keith_Miller,
        Angie_Beer,
        Annette_Brightwell,
        Alice_Covington,
        Adam_Heath,
        Anita_Skelton,
        Allen_Zindrick,
        Betty_Anderson_Estate
    }
}

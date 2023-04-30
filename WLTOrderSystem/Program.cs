using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLTDataObjects;

namespace WLTOrderSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Declare needed data paths
            AppData.SalesDataPath = Application.StartupPath + @"\" + "SalesData";
            AppData.VendorDataPath = Application.StartupPath + @"\" + "VendorData";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

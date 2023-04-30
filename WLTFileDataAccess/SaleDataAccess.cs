using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLTDataObjects;

namespace WLTFileDataAccess
{
    public class SaleDataAccess
    {
        public static DailySale RetrieveDailySale() //Read and validate a DailySale from tvs files.
        {
            DailySale _dailySale = new DailySale();

            char[] separator = { '\t' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.SalesDataPath + @"\" + AppData.FruitListFileName);
                while (fileReader.EndOfStream == false)
                {
                    

                }
                fileReader.Close();     // if open files are not closed, this app will crash with IO access exceptions.
            }
            catch (Exception)
            {
                throw;
            }
            return _dailySale;
        } // end of RetrieveFruitList()
    }
}

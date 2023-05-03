using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WLTDataObjects;

namespace WLTDataAccess
{
    public class SaleDataAccess
    {
        /*public DailySale RetrieveDailySale(DateTime date) //Read and validate a DailySale from tvs files.
        {
            DailySale dailySale = new DailySale();
            string fileName = date.ToString(("MM-dd-yyyy")) + ".tsv";

            char[] separator = { '\t' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.SalesDataPath + @"\" + fileName);
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;
                    if (line.Length > 16) // minimum theoretically possible line length
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 5)
                        {
                            Fruit newFruit = new Fruit();
                            newFruit.Name = parts[0];
                            newFruit.PlantType = parts[1];
                            newFruit.Origin = parts[2];
                            newFruit.ArticleFileName = parts[3];
                            newFruit.ImageFileName = parts[4];

                            fruitList.Add(newFruit);
                        }
                    }

                }
                fileReader.Close();     // if open files are not closed, this app will crash with IO access exceptions.
            }
            catch (Exception)
            {
                throw;
            }
            return dailySale;
        } */
        // end of RetrieveFruitList()
    }
}

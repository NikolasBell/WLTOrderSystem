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
        public DailySale retrieveDailySale(DateTime date) //Read and validate a DailySale from tvs files.
        {
            //Create a sales sheet and an empty array of orders
            DailySale dailySale = new DailySale();
            dailySale.Orders = new List<Order>();

            string fileName = date.ToString(("MM-dd-yyyy")) + ".tsv";

            char[] separator = { '\t' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.SalesDataPath + @"\" + fileName);
                int orderIndex = 0;
                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;

                    parts = line.Split(separator);
                    if (parts.Count() == 9)
                    {
                        //write the item data
                        Item item = new Item();
                        item.VendorCode = (VendorCode)Enum.Parse(typeof(VendorCode), parts[0]);
                        item.Description = parts[1];
                        item.Quantity = int.Parse(parts[2]);
                        item.Price = decimal.Parse(parts[3]);
                        item.isTaxed = bool.Parse(parts[4]);
                        item.ItemNotes = parts[5];

                        //If the order index does not exist in the sales yet
                        if (dailySale.Orders.Count < int.Parse(parts[6]) + 1)
                        {
                            //Create an empty order and add to sales
                            Order order = new Order();
                            order.Items = new List<Item>();

                            dailySale.Orders.Add(order);
                        }

                        (dailySale.Orders[int.Parse(parts[6])]).Items.Add(item);
                        (dailySale.Orders[int.Parse(parts[6])]).PayType = (PaymentMethod)Enum.Parse(typeof(PaymentMethod), parts[7]);
                        (dailySale.Orders[int.Parse(parts[6])]).OrderNotes = parts[8];
                    }
                    else
                    {
                        //This means it's reading the first line, that only has the name.
                        dailySale.Employee = parts[0];
                    }

                }
                fileReader.Close();     // if open files are not closed, this app will crash with IO access exceptions.
            }
            catch (Exception) //If a file can't be read or found, create an empty sheet
            {
                dailySale.Date = date;
            }
            return dailySale;
        }

        public void saveDailySale(DailySale dailySale)
        {
            //Writes sales data to a tsv file
            try
            {
                //Get the finle name and path
                string fileName = dailySale.Date.ToString(("MM-dd-yyyy")) + ".tsv";
                StreamWriter fileWriter = new StreamWriter(AppData.SalesDataPath + @"\" + fileName);

                fileWriter.WriteLine(dailySale.Employee);
                int orderCount = 0;
                foreach (Order order in dailySale.Orders)
                {
                    foreach (Item item in order.Items)
                    {
                        fileWriter.WriteLine(item.VendorCode + "\t" +
                            item.Description + "\t" +
                            item.Quantity + "\t" +
                            item.Price + "\t" +
                            item.isTaxed + "\t" +
                            item.ItemNotes + "\t" +
                            orderCount + "\t" +
                            order.PayType + "\t" +
                            order.OrderNotes);
                    }//End item loop
                    orderCount++;
                } //End order loop

                fileWriter.Close();
            }
            catch (Exception)
            {

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLTControlLogic;
using WLTDataObjects;

namespace WLTOrderSystem
{
    public partial class frmMain : Form
    {
        SalesManager _salesManager = new SalesManager();

        DailySale _dailySale = new DailySale();
        int _orderIndex = 0;
        int _itemIndex = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //txtbCode.Enabled = false;
            txtbVendor.Enabled = false;
            //txtbDescription.Enabled = false;
            //numQuantity.Enabled = false;
            //txtbPrice.Enabled = false;
            //txtbDiscount.Enabled = false;
            txtbExitPrice.Enabled = false;
            //chkTax.Enabled = false;
            txtbTax.Enabled = false;
            txtbTotalPrice.Enabled = false;
            btnNewItem.Enabled = false;
            //btnDeleteOrder.Enabled = false;
            //btnDeleteItem.Enabled = false;
            btnPayOrder.Enabled = false;

            //Might need to remove code.
            DateTime today = DateTime.Today;
            txtbDate.Text = today.ToString("MM-dd-yyyy");

            _dailySale = _salesManager.Startup(); //Replace with method that checks for existing sale sheet
        } //end frmMain_Load

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            newItem();
        }

        private void newItem()
        {
            //Clear relevant fields
            txtbCode.Text = "???";
            txtbVendor.Text = "";
            txtbDescription.Text = "";
            txtbPrice.Text = "$0.00";
            txtbDiscount.Text = "0%";
            txtbExitPrice.Text = "$0.00";
            txtbTax.Text = "$0.00";
            txtbTotalPrice.Text = "$0.00";
            txtbItemNotes.Text = "";

            //Create empty item
            Order currentOrder = _dailySale.Orders[_orderIndex];
            Item item = new Item();
            item.Quantity = 1;
            item.VendorCode = "???";

            //Update which item is currently selected
            currentOrder.Items.Add(item);
            _itemIndex = currentOrder.Items.Count - 1; //Item index is set to the last item in current order list, which is presumably where the item is added.
            _dailySale.Orders[_orderIndex] = currentOrder; //Overwrite current order with new data

            updatelistItemDisplay();
        }

        private void btnNewOrder_Click(object sender, EventArgs e) //Create a new order item and append it to the list
        {
            //Create an empty order object
            Order order = new Order();
            order.Items = new List<Item>();

            //Append the new order to _dailySale
            _dailySale.Orders.Add(order);
            _orderIndex = _dailySale.Orders.Count - 1;
            txtbOrderNotes.Text = "";

            newItem();
            chkTax.Checked = true;
            btnNewItem.Enabled = true;
        }

        private void txtbDescription_Leave(object sender, EventArgs e)
        {
            txtbDescription.Text.Replace("|", "").Replace("\t", "");


            Item currentItem = getItem();
            currentItem.Description = txtbDescription.Text;
            saveItem(currentItem);
        }

        private void txtbPrice_Leave(object sender, EventArgs e)
        {
            string priceText = txtbPrice.Text.Replace("$", "").Replace(" ", ""); //Parse out valid but irlelevent characters.
            try
            {
                decimal price = decimal.Parse(priceText);
                txtbPrice.Text = price.ToString("C2");

                Item currentItem = getItem();
                currentItem.Price = price;
                saveItem(currentItem);
                updatePriceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid price.");
                txtbPrice.Focus();
            }
        }

        private void numQuantity_Leave(object sender, EventArgs e)
        {
            Item currentItem = getItem();
            currentItem.Quantity = (int)numQuantity.Value;
            saveItem(currentItem);
            updatePriceFields();
        }

        private void txtbDiscount_Leave(object sender, EventArgs e)
        {
            string discountText = txtbDiscount.Text.Replace("%", "").Replace(" ", "");

            try
            {
                decimal discount = decimal.Parse(discountText);
                txtbDiscount.Text = discount.ToString() + "%";

                Item currentItem = getItem();
                currentItem.Discount = discount * 0.01m;
                saveItem(currentItem);
                updatePriceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
                txtbPrice.Focus();
            }
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            updatePriceFields();
        }

        private void txtbItemNotes_Leave(object sender, EventArgs e)
        {
            txtbItemNotes.Text.Replace("|", "").Replace("\t", "");

            Item currentItem = getItem();
            currentItem.ItemNotes = txtbItemNotes.Text;
            saveItem(currentItem);
        }

        private void txtbOrderNotes_Leave(object sender, EventArgs e)
        {
            txtbOrderNotes.Text.Replace("|", "").Replace("\t", "");

            Order currentOrder = _dailySale.Orders[_orderIndex];
            currentOrder.OrderNotes = txtbOrderNotes.Text;
            _dailySale.Orders[_orderIndex] = currentOrder;
        }

        private void txtbName_Leave(object sender, EventArgs e)
        {
            txtbName.Text.Replace("|", "").Replace("\t", "");

            _dailySale.Employee = txtbName.Text;
        }


        //This is where field update commands are stored
        private void updatelistItemDisplay()
        {
            listItemDisplay.Items.Clear();
            int orderCount = 0;
            foreach (Order order in _dailySale.Orders)
            {
                orderCount++;
                int itemCount = 0;
                foreach (Item item in order.Items)
                {
                    itemCount++;
                    ListViewItem listItem = new ListViewItem(item.VendorCode);
                    listItem.SubItems.Add("Placeholder"); //Replace with vendor name retrival
                    listItem.SubItems.Add(item.Description);
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.Price.ToString("C2"));
                    listItem.SubItems.Add((item.Discount * 100).ToString() + "%");
                    listItem.SubItems.Add(_salesManager.getExitPrice(item).ToString("C2"));
                    listItem.SubItems.Add(_salesManager.getTaxPrice(item).ToString("C2"));
                    listItem.SubItems.Add(_salesManager.getTotalPrice(item).ToString("C2"));
                    listItem.SubItems.Add(orderCount.ToString());
                    listItem.SubItems.Add(itemCount.ToString());

                    listItemDisplay.Items.Add(listItem);
                }
            }
        }

        private void updatePriceFields()
        {
            Item currentItem = getItem();
            currentItem.isTaxed = chkTax.Checked; //Check for tax here every time price is needed instead of when the checkbox is updated.
            saveItem(currentItem);

            txtbExitPrice.Text = _salesManager.getExitPrice(currentItem).ToString("C2");
            txtbTax.Text = _salesManager.getTaxPrice(currentItem).ToString("C2");
            txtbTotalPrice.Text = _salesManager.getTotalPrice(currentItem).ToString("C2");

        }

        //Retrive copy of item, return current item if no parameter is fed.
        private Item getItem()
        {
            return getItem(_orderIndex, _itemIndex);
        }
        private Item getItem(int orderNumber, int itemNumber)
        {

            Order currentOrder = _dailySale.Orders[orderNumber];
            if (itemNumber < 0)
            {
                Console.WriteLine(itemNumber);
            }
            return currentOrder.Items[itemNumber];

        }

        private void saveItem(Item currentItem)
        {
            Order currentOrder = _dailySale.Orders[_orderIndex];
            currentOrder.Items[_itemIndex] = currentItem;
            _dailySale.Orders[_orderIndex] = currentOrder;
            updatelistItemDisplay();
        }



        private void listItemDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItemDisplay.SelectedItems.Count > 0)
            {
                //Set the current index values to what was retrived in the list.
                ListViewItem selected = listItemDisplay.SelectedItems[0];
                _orderIndex = int.Parse(selected.SubItems[9].Text) - 1;
                _itemIndex = int.Parse(selected.SubItems[10].Text) - 1;

                updateDataFields();
            }
            else
            {
                // handle case where no items are selected
                MessageBox.Show("There are no items to select.");
            }
        }

        private void updateDataFields()
        {
            Item currentItem = getItem();
            txtbCode.Text = currentItem.VendorCode;
            //txtbVendor.Text =
            txtbDescription.Text = currentItem.Description;
            numQuantity.Value = currentItem.Quantity;
            txtbPrice.Text = currentItem.Price.ToString("C2");
            txtbDiscount.Text = (currentItem.Discount * 100).ToString() + "%";
            txtbItemNotes.Text = currentItem.ItemNotes;

            Order currentOrder = _dailySale.Orders[_orderIndex];
            txtbOrderNotes.Text = currentOrder.OrderNotes;

            chkTax.Checked = currentItem.isTaxed; //Make sure the tax checkbox is set before price calculations
            txtbExitPrice.Text = _salesManager.getExitPrice(currentItem).ToString("C2");
            txtbTax.Text = _salesManager.getTaxPrice(currentItem).ToString("C2");
            txtbTotalPrice.Text = _salesManager.getTotalPrice(currentItem).ToString("C2");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Order currentOrder = _dailySale.Orders[_orderIndex];
            currentOrder.Items.RemoveAt(_itemIndex);
            if (currentOrder.Items.Count == _itemIndex) //Subtract from the index if it's out of range.
            {
                _itemIndex--;
            }
            _dailySale.Orders[_orderIndex] = currentOrder;
            updatelistItemDisplay();
            updateDataFields();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            _dailySale.Orders.RemoveAt(_orderIndex);
            if (_dailySale.Orders.Count == _orderIndex) //Subtract from the index if it's out of range.
            {
                _orderIndex--;
            }
            _itemIndex = 0;
            updatelistItemDisplay();
            updateDataFields();
        }
    }
}

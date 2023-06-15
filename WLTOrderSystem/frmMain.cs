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

        //Indexes for the current item and order being worked on.
        int _orderIndex = 0;
        int _itemIndex = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Disable fields used to display purposes only.
            txtbVendor.Enabled = false;
            txtbExitPrice.Enabled = false;
            txtbTax.Enabled = false;
            txtbTotalPrice.Enabled = false;
            //Intitalize combo box
            VendorCode[] vendorCode = (VendorCode[])Enum.GetValues(typeof(VendorCode));
            cboVendorCode.DataSource = vendorCode;

            //Get today's date
            dtpDate.Value = DateTime.Today;
            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "MM-dd-yyyy";

            //Creates new Dailysale, move later
            DailySale dailySale = new DailySale();
            dailySale.Date = DateTime.Now;
            dailySale.Orders = new List<Order>();

            _dailySale = _salesManager.getDailySheet(DateTime.Today);
            enableIntputFields(false);

            if (_dailySale.Orders.Count != 0)
            {
                updatelistItemDisplay();
                txtbName.Text = _dailySale.Employee;
            }
        } //end frmMain_Load

        //Gets a new sales sheet when you select a date.
        private void dtpDate_Leave(object sender, EventArgs e)
        {
            //Reset indexes
            _orderIndex = 0;
            _itemIndex = 0;

            _salesManager.saveDailySheet(_dailySale);

            _dailySale = _salesManager.getDailySheet(dtpDate.Value);
            enableIntputFields(false);

            if (_dailySale.Orders.Count != 0)
            {
                txtbName.Text = _dailySale.Employee;
            }
            updatelistItemDisplay();
        }

        //Button methods
        private void btnNewItem_Click(object sender, EventArgs e)
        {
            if (_dailySale.Orders.Count != 0)
            {
                newItem();
            }
            else
            {
                MessageBox.Show("There are no orders to add to!");
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e) //Create a new order item and append it to the list
        {
            //Create an empty order object
            Order order = new Order();
            order.Items = new List<Item>();
            order.PayType = PaymentMethod.Unpaid;

            //Append the new order to _dailySale
            _dailySale.Orders.Add(order);
            _orderIndex = _dailySale.Orders.Count - 1;
            txtbOrderNotes.Text = "";

            newItem();
            chkTax.Checked = true;
            btnNewItem.Enabled = true;
            enableIntputFields(true);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (_dailySale.Orders.Count != 0)
            {
                Order currentOrder = _dailySale.Orders[_orderIndex];
                currentOrder.Items.RemoveAt(_itemIndex);
                if (currentOrder.Items.Count == _itemIndex) //Subtract from the index if it's out of range.
                {
                    _itemIndex--;
                }

                if (_itemIndex < 0) //If you deleted the final item in the order, delete the order.
                { deleteOrder(); }
                else
                {
                    updatelistItemDisplay();
                    updateDataFields();
                }
            }
            else
            {
                MessageBox.Show("There are no items to delete!");
            }


        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (_dailySale.Orders.Count != 0)
            {
                deleteOrder();
            }
            else
            {
                MessageBox.Show("There are no orders to delete!");
            }
        }

        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            if (_dailySale.Orders.Count != 0)
            {
                Order currentOrder = _dailySale.Orders[_orderIndex];
                frmPayment paymentForm = new frmPayment(currentOrder, _orderIndex, _salesManager);
                paymentForm.Show();
            }
            else
            {
                MessageBox.Show("There are no orders to pay for!");
            }

        }

        //Input field event listeners

        private void cboVendorCode_Leave(object sender, EventArgs e)
        {
            try
            {
                //Validate code
                int enumValue = (int)(VendorCode)cboVendorCode.SelectedItem;
                string name = Enum.GetName(typeof(VendorName), enumValue);
                txtbVendor.Text = name.Replace("_", " ");
                //Save the code
                Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
                currentItem.VendorCode = (VendorCode)cboVendorCode.SelectedItem;
                updatelistItemDisplay();
            }
            catch
            {
                //Invalid code
                MessageBox.Show("Please enter a valid code.");
                cboVendorCode.Focus();
            }
        }

        private void txtbDescription_Leave(object sender, EventArgs e)
        {
            //Change the current item description
            txtbDescription.Text.Replace("|", "").Replace("\t", "");

            Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
            currentItem.Description = txtbDescription.Text;
            updatelistItemDisplay();
        }

        private void txtbPrice_Leave(object sender, EventArgs e)
        {
            //Validate that the price is a decimal that's not under 0.
            string priceText = txtbPrice.Text.Replace("$", "").Replace(" ", "");
            try
            {
                decimal price = decimal.Parse(priceText);
                if (price > 0)
                {
                    txtbPrice.Text = price.ToString("C2");
                    Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
                    currentItem.Price = price;
                    updatePriceFields();
                    updatelistItemDisplay();
                }
                else { throw new IndexOutOfRangeException(); }
            }
            catch
            {
                MessageBox.Show("Please enter a valid price.");
                txtbPrice.Focus();
            }
        }

        private void numQuantity_Leave(object sender, EventArgs e)
        {
            Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
            currentItem.Quantity = (int)numQuantity.Value;
            updatePriceFields();
            updatelistItemDisplay();
        }

        private void chkTax_Leave(object sender, EventArgs e)
        {
            updatePriceFields();
            updatelistItemDisplay();
        }

        private void txtbItemNotes_Leave(object sender, EventArgs e)
        {
            txtbItemNotes.Text.Replace("|", "").Replace("\t", "");

            Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex]; ;
            currentItem.ItemNotes = txtbItemNotes.Text;
        }

        private void txtbOrderNotes_Leave(object sender, EventArgs e)
        {
            txtbOrderNotes.Text.Replace("|", "").Replace("\t", "");

            Order currentOrder = _dailySale.Orders[_orderIndex];
            currentOrder.OrderNotes = txtbOrderNotes.Text;
        }

        private void txtbName_Leave(object sender, EventArgs e)
        {
            txtbName.Text.Replace("|", "").Replace("\t", "");

            _dailySale.Employee = txtbName.Text;
        }


        //Update UI methods
        private void updatelistItemDisplay()
        {
            //Refreshes the item display list with current information.
            listItemDisplay.Items.Clear();
            int orderCount = 0;
            foreach (Order order in _dailySale.Orders)
            {
                orderCount++;
                int itemCount = 0;
                foreach (Item item in order.Items)
                {
                    itemCount++;
                    ListViewItem listItem = new ListViewItem(item.VendorCode.ToString());

                    //Use Code to get Vendor name
                    int enumValue = (int)item.VendorCode;
                    string name = Enum.GetName(typeof(VendorName), enumValue);
                    listItem.SubItems.Add(name.Replace("_", " "));

                    listItem.SubItems.Add(item.Description);
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.Price.ToString("C2"));
                    listItem.SubItems.Add(_salesManager.getExitPrice(item).ToString("C2"));
                    listItem.SubItems.Add(_salesManager.getTaxPrice(item).ToString("C2"));
                    listItem.SubItems.Add(_salesManager.getTotalPrice(item).ToString("C2"));
                    listItem.SubItems.Add(orderCount.ToString());
                    listItem.SubItems.Add(itemCount.ToString());

                    listItemDisplay.Items.Add(listItem);
                }//End Item Loop
            }//End Order Loop
        }

        private void updatePriceFields()
        {
            //Update the price fiels on the input boxes whenever quantity, price, or tax is changed.
            Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
            currentItem.isTaxed = chkTax.Checked; //Check for tax here every time price is needed instead of when the checkbox is updated.

            txtbExitPrice.Text = _salesManager.getExitPrice(currentItem).ToString("C2");
            txtbTax.Text = _salesManager.getTaxPrice(currentItem).ToString("C2");
            txtbTotalPrice.Text = _salesManager.getTotalPrice(currentItem).ToString("C2");

        }

        private void updateDataFields()
        {
            //If a new item is selected, update the input feilds with that information
            Item currentItem = (_dailySale.Orders[_orderIndex]).Items[_itemIndex];
            cboVendorCode.SelectedItem = currentItem.VendorCode;

            //Use Code to get Vendor name
            int enumValue = (int)currentItem.VendorCode;
            string name = Enum.GetName(typeof(VendorName), enumValue);

            txtbVendor.Text = name.Replace("_", " ");
            txtbDescription.Text = currentItem.Description;
            numQuantity.Value = currentItem.Quantity;
            txtbPrice.Text = currentItem.Price.ToString("C2");
            txtbItemNotes.Text = currentItem.ItemNotes;

            Order currentOrder = _dailySale.Orders[_orderIndex];
            txtbOrderNotes.Text = currentOrder.OrderNotes;

            chkTax.Checked = currentItem.isTaxed; //Make sure the tax checkbox is set before price calculations
            txtbExitPrice.Text = _salesManager.getExitPrice(currentItem).ToString("C2");
            txtbTax.Text = _salesManager.getTaxPrice(currentItem).ToString("C2");
            txtbTotalPrice.Text = _salesManager.getTotalPrice(currentItem).ToString("C2");
        }

        private void enableIntputFields(bool enable)
        {

            cboVendorCode.Enabled = enable;
            txtbDescription.Enabled = enable;
            numQuantity.Enabled = enable;
            txtbPrice.Enabled = enable;
            chkTax.Enabled = enable;
            txtbItemNotes.Enabled = enable;
            txtbOrderNotes.Enabled = enable;
        }

        //Item and order get/save methods

        private void newItem()
        {
            //Clear relevant fields
            cboVendorCode.SelectedIndex = 0;
            txtbVendor.Text = "Unknown Vendor";
            txtbDescription.Text = "";
            txtbPrice.Text = "$0.00";
            txtbExitPrice.Text = "$0.00";
            txtbTax.Text = "$0.00";
            txtbTotalPrice.Text = "$0.00";
            txtbItemNotes.Text = "";

            //Create empty item
            Order currentOrder = _dailySale.Orders[_orderIndex];
            Item item = new Item();
            item.Quantity = 1;
            item.VendorCode = 0;

            //Update which item is currently selected
            currentOrder.Items.Add(item);
            _itemIndex = currentOrder.Items.Count - 1; //Item index is set to the last item in current order list, which is presumably where the item is added.
            _dailySale.Orders[_orderIndex] = currentOrder; //Overwrite current order with new data

            updatelistItemDisplay();
        }

        private void listItemDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listItemDisplay.SelectedItems.Count > 0)
            {
                //Set the current index values to what was retrived in the list.
                ListViewItem selected = listItemDisplay.SelectedItems[0];
                _orderIndex = int.Parse(selected.SubItems[8].Text) - 1;
                _itemIndex = int.Parse(selected.SubItems[9].Text) - 1;

                updateDataFields();
                enableIntputFields(true);
            }
            else
            {
                // handle case where no items are selected
                MessageBox.Show("There are no items to select.");
            }
        }

        private void deleteOrder()
        {
            _dailySale.Orders.RemoveAt(_orderIndex);
            if (_dailySale.Orders.Count == _orderIndex) //Subtract from the index if it's out of range.
            {
                _orderIndex--;
            }
            _itemIndex = 0;
            if (_orderIndex < 0)
            {
                updatelistItemDisplay();
                enableIntputFields(false);
            }
            else
            {
                updatelistItemDisplay();
                updateDataFields();
            }



        }

        //Save the sales data when closing
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _salesManager.saveDailySheet(_dailySale);
        }

        
    }
}

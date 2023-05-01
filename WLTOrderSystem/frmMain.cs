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
        int orderIndex = 0;
        int itemIndex = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtbVendor.Enabled = false;
            txtbExitPrice.Enabled = false;
            txtbTax.Enabled = false;
            txtbTotalPrice.Enabled = false;

            //Might need to remove code.
            DateTime today = DateTime.Today;
            txtbDate.Text = today.ToString("MM-dd-yyyy");

            _dailySale = _salesManager.Startup(); //Replace with method that checks for existing sale sheet
        } //end frmMain_Load

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            //Clear relevant fields
            txtbCode.Text = "???";
            txtbVendor.Text = "";
            txtbDescription.Text = "";
            numQuantity.Value = 1;
            txtbPrice.Text = "$0.00";
            txtbDiscount.Text = "0%";
            txtbExitPrice.Text = "$0.00";
            txtbTax.Text = "$0.00";
            txtbTotalPrice.Text = "$0.00";

            Order currentOrder = _dailySale.Orders[orderIndex];
            Item item = new Item();
            item.Quantity = 1;
            currentOrder.Items.Add(item);
            itemIndex = currentOrder.Items.Count - 1;
            _dailySale.Orders[orderIndex] = currentOrder;
        }

        private void btnNewOrder_Click(object sender, EventArgs e) //Create a new order item and append it to the list
        {
            Order order = new Order();
            order.Items = new List<Item>();

            _dailySale.Orders.Add(order);
            orderIndex = _dailySale.Orders.Count - 1;
        }

        private void txtbDescription_Leave(object sender, EventArgs e)
        {
            txtbDescription.Text.Replace("|", "").Replace("\t", "");


            Item currentItem = getCurrentItem();
            currentItem.Description = txtbDescription.Text;
            saveCurrentItem(currentItem);
        }

        private void txtbPrice_Leave(object sender, EventArgs e)
        {
            string priceText = txtbPrice.Text.Replace("$", "").Replace(" ", "");
            try
            {
                decimal price = decimal.Parse(priceText);
                txtbPrice.Text = price.ToString("C2");

                Item currentItem = getCurrentItem();
                currentItem.Price = price;
                saveCurrentItem(currentItem);
                updatePriceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid price.");
                txtbPrice.Focus();
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            Item currentItem = getCurrentItem();
            currentItem.Quantity = (int)numQuantity.Value;
            saveCurrentItem(currentItem);
            updatePriceFields();
        }

        private void txtbDiscount_Leave(object sender, EventArgs e)
        {
            string discountText = txtbDiscount.Text.Replace("%", "").Replace(" ", "");

            try
            {
                decimal discount = decimal.Parse(discountText);
                txtbDiscount.Text = discount.ToString() + "%";

                Item currentItem = getCurrentItem();
                currentItem.Discount = discount * 0.01m;
                saveCurrentItem(currentItem);
                updatePriceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
                txtbPrice.Focus();
            }
        }

        private void updatePriceFields()
        {
            txtbExitPrice.Text = _salesManager.getExitPrice(getCurrentItem()).ToString("C2");
            txtbTax.Text = _salesManager.getTaxPrice(getCurrentItem()).ToString("C2");
            txtbTotalPrice.Text = _salesManager.getTotalPrice(getCurrentItem()).ToString("C2");
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            Item currentItem = getCurrentItem();
            currentItem.isTaxed = chkTax.Checked;
            saveCurrentItem(currentItem);
            updatePriceFields();
        }



        private Item getCurrentItem()
        {
            Order currentOrder = _dailySale.Orders[orderIndex];
            return currentOrder.Items[itemIndex];
        }

        private void saveCurrentItem(Item currentItem)
        {
            Order currentOrder = _dailySale.Orders[orderIndex];
            currentOrder.Items[itemIndex] = currentItem;
            _dailySale.Orders[orderIndex] = currentOrder;
        }
    }
}

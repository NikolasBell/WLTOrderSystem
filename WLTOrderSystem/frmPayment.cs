using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WLTControlLogic;
using WLTDataObjects;

namespace WLTOrderSystem
{
    public partial class frmPayment : Form
    {
        SalesManager _salesManager;
        DailySale _dailySale;
        Order _order;

        public frmPayment(Order order, SalesManager salesManager)
        {
            //Pass the sales sheet and the current order into form when created.

            InitializeComponent();
            this._order = order;
            this._salesManager = salesManager;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            Order _order

            int qty = 0;
            decimal exitPrice = 0;
            decimal tax = 0;

            //Read the order data
            foreach (Item item in _order.Items)
            {
                qty += item.Quantity;
                exitPrice += _salesManager.getExitPrice(item);
                tax += _salesManager.getTaxPrice(item);
            }

            //Set text fields
            txtbTotal.Text = (exitPrice + tax).ToString("C2");
            txtbOrderNum.Text = (_orderIndex + 1).ToString();
            txtbQty.Text = qty.ToString();
            txtbExitPrice.Text = exitPrice.ToString("C2");
            txtbTax.Text = tax.ToString("C2");

            //intialize the combo box and set it's value
            PaymentMethod[] paymentMethods = (PaymentMethod[])Enum.GetValues(typeof(PaymentMethod));
            cboPayType.DataSource = paymentMethods;
            cboPayType.SelectedItem = _order.PayType;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Just closes the window, that's when the object is saved

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Order currentOrder = _dailySale.Orders[_orderIndex];
            currentOrder.PayType = (PaymentMethod)cboPayType.SelectedItem;
        }
    }
}

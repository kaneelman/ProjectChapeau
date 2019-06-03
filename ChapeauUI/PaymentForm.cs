using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class PaymentForm : BaseForm
    {
        public PaymentForm(Employee LoggedUser)
        {
            LoggedInEmployee = LoggedUser;

            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //ListViewItem ListOfOrders = new ListViewItem();

            ChapeauLogic.OrderService payment = new ChapeauLogic.OrderService();
            ChapeauLogic.MenuItemService menuItemDB = new ChapeauLogic.MenuItemService();

            ChapeauModel.Order order = payment.GetCompleteActiveOrderByTable(new ChapeauModel.DiningTable(1, ChapeauModel.TableStatus.Occupied));


            foreach (ChapeauModel.OrderMenuItem m in order.GetOrderMenuItems())
            {
                ListViewItem li = new ListViewItem(m.GetMenuItem().Name);

            }

            //the list view design
            lst_Payment.GridLines = true;
            lst_Payment.View = View.Details;
            lst_Payment.Columns.Add("Menu Number", 100, HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Name");
            lst_Payment.Columns.Add("Quantity");
            lst_Payment.Columns.Add("Price");
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }
        //when things are selected.
        private void listView_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

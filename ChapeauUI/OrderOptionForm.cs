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
    public partial class OrderOptionForm : BaseForm
    {
        ChapeauLogic.OrderService payment = new ChapeauLogic.OrderService();
        ChapeauLogic.MenuItemService menuItemDB = new ChapeauLogic.MenuItemService();

        Order order;

        public OrderOptionForm(Employee LoggedUser, LoginForm loginForm, Order order)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            //Passing the order along that will be payed
            this.order = order;

        }

        private void lstview_CurrentOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderOptionForm_Load(object sender, EventArgs e)
        {
            //the list view design
            lst_CurrentOrder.GridLines = true;
            lst_CurrentOrder.View = View.Details;
            lst_CurrentOrder.Columns.Add("Menu Number", 150, HorizontalAlignment.Left);
            lst_CurrentOrder.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lst_CurrentOrder.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
    
            foreach (ChapeauModel.OrderMenuItem m in order.GetOrderMenuItems())
            {
                ListViewItem li = new ListViewItem(m.GetMenuItem().Id.ToString());
                li.SubItems.Add(m.GetMenuItem().Name);
                li.SubItems.Add(m.Quantity.ToString());
                lst_CurrentOrder.Items.Add(li);
            }
            
            //to the show some information such as price and table number
            lbl_CurrentPrice.Text= order.CalculateTotalPrice().ToString("0.00");
            lbl_TableNr.Text = order.Table.Id.ToString();
        }
        //make a code thhat allows us to select an item from the list view.
        //code the buttons
        //new order buttons goes to order interface 
        //payment button goes to payment interace.
        //delete buttons delete the item selected from the list view ask japheth about this how are we going to choose what gets deleted.
    }
}

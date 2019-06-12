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
        EmployeeService EmployeeDB = new EmployeeService();


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
                li.Tag = m;
            }
            
            //to the show some information such as price and table number
            lbl_price.Text= order.CalculateTotalPrice().ToString("0.00");
            lbl_TableNr.Text = order.Table.Id.ToString();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(lst_CurrentOrder.SelectedItems.Count == 0)
            {
                return;
            }

            OrderMenuItem item = (OrderMenuItem)lst_CurrentOrder.SelectedItems[0].Tag;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();//close the form
            //do i need to call the tableview form here? or nah?
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentForm paymentForm = new PaymentForm(LoggedInEmployee,this.loginForm,order);
            paymentForm.ShowDialog();            
        }
        //make a code thhat allows us to select an item from the list view.
        //code the buttons
        //new order buttons goes to order interface 
        //payment button goes to payment interace.
        //delete buttons delete the item selected from the list view ask japheth about this how are we going to choose what gets deleted.
    }
}

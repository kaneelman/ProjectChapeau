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
        ChapeauLogic.OrderService payment = new ChapeauLogic.OrderService();
        ChapeauLogic.MenuItemService menuItemDB = new ChapeauLogic.MenuItemService();
        

        Order order;

        //values of counter
        decimal price = 0;
        decimal vat = 0;
        decimal tip = 0;

        //for the type of payment
        string paymentType;

        public PaymentForm(Employee LoggedUser, LoginForm loginForm, Order order)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            //Passing the order along that will be payed
            this.order = order;

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //the list view design
            lst_Payment.GridLines = true;
            lst_Payment.View = View.Details;
            lst_Payment.Columns.Add("Menu Number", 150, HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Name",150,HorizontalAlignment.Left);
            lst_Payment.Columns.Add("Quantity",100,HorizontalAlignment.Left); 
            lst_Payment.Columns.Add("Price", 100, HorizontalAlignment.Left);

            foreach (ChapeauModel.OrderMenuItem m in order.GetOrderMenuItems())
            {
                ListViewItem li = new ListViewItem(m.GetMenuItem().Id.ToString());//needs to fix this because stock quantity is taken rather than order quantity
                li.SubItems.Add(m.GetMenuItem().Name);
                li.SubItems.Add(m.Quantity.ToString());
                li.SubItems.Add(m.GetMenuItem().Price.ToString("0.00"));
                lst_Payment.Items.Add(li);
            }

            //the calculation being called

            //information for the textboxes
            txt_Price.Text = order.CalculateTotalPrice().ToString("0.00");
            txt_TVAT.Text = order.CalculateTotalVAT().ToString("0.00");

            //this is for the total amount witout added tip
            txt_TotalAmount.Text = order.CalculateTotalAmount().ToString("0.00");
            
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            ChapeauLogic.PaymentService AddPayment = new ChapeauLogic.PaymentService();
            AddPayment.InsertPayment(new Payment(order,decimal.Parse(txt_Price.Text),decimal.Parse(txt_Tip.Text),decimal.Parse(txt_TotalAmount.Text),paymentType));
            DialogResult dialogBox = MessageBox.Show("Payment complete");

            resetTextBox();
            
        }
        private void resetTextBox()
        {
            txt_Price.ResetText();
            txt_Tip.ResetText();
            txt_TotalAmount.ResetText();
            txt_TVAT.ResetText();
        }
        //when things are selected.
        private void listView_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            //TableViewForm tableViewForm1 = new TableViewForm(LoggedInEmployee,);// or make a new tableview.
            //tableViewForm1.Show();
        }

        private void btn_AddTip_Click(object sender, EventArgs e)
        {
            //int i;
            //if(!int.TryParse(txt_Tip.Text, out i))
            //{
            //    DialogResult errorTip = MessageBox.Show("Wrong input");
            //}
            //else
            //{
            //    //converting input tip to value to add to total amount
            //    decimal tip = int.Parse(txt_Tip.Text) + 0;

            //    txt_TotalAmount.Text = (price + vat + tip).ToString("0.00");
            //}            
        }

        private void radBtn_visa_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "CreditCard";

            //to show the txt and lbl when after clicking cash
            txt_Tip.Show();
            lbl_Tip.Show();
            btn_AddTip.Show();
        }

        private void radBtn_Cash_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Cash";

            //hide the tip info when cash is clicked
            txt_Tip.Hide();
            lbl_Tip.Hide();
            btn_AddTip.Hide();
        }

        private void radBtn_PIN_CheckedChanged(object sender, EventArgs e)
        {
            paymentType = "Pin";

            //to show the txt and lbl when after clicking cash
            txt_Tip.Show();
            lbl_Tip.Show();
            btn_AddTip.Show();
        }

        private void txt_Tip_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tip.Text == "")
            {
                //still need to fix this.
            }
            else
            {
                int i;

                if (!int.TryParse(txt_Tip.Text, out i))
                {
                    DialogResult errorTip = MessageBox.Show("Wrong input");
                }
                else
                {
                    //converting input tip to value to add to total amount
                    tip = int.Parse(txt_Tip.Text);

                    txt_TotalAmount.Text = (order.CalculateTotalAmount()+tip).ToString("0.00");
                }
            }          
        }
    }
}

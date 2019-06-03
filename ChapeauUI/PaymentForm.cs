using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class PaymentForm : BaseForm
    {
        public PaymentForm()
        {
            this.picBox_Chapeau.Hide();
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            //ListViewItem ListOfOrders = new ListViewItem();

            //the list view design
            listView_Payment.GridLines = true;
            listView_Payment.View = View.Details;
            listView_Payment.Columns.Add("Menu Number");
            listView_Payment.Columns.Add("Name");
            listView_Payment.Columns.Add("Quantity");
            listView_Payment.Columns.Add("Price");
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {

        }

        private void listView_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

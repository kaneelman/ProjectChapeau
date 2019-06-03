using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class OrderForm : BaseForm
    {
        int size = 110;

        public OrderForm()
        {
            InitializeComponent();
            DisplayMainCatagories();
       
        }

        private void lst_NewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_NewOrderBack_Click(object sender, EventArgs e)
        {
            OrderForm o1 = new OrderForm();
            o1.Close();

            TableViewForm t1 = new TableViewForm();
            t1.Show();
           
        }


        private void flpnl_MainCatagories_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayMainCatagories()
        {
            flpnl_MainCatagories.Controls.Clear();

            List<string> mainCatagories = new List<string>();

            mainCatagories.Add("Lunch");
            mainCatagories.Add("Diner");
            mainCatagories.Add("Drinks");
 
            foreach (string catagory in mainCatagories)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(1.1 * size), (int)(0.6 * size)),
                    Text = catagory,
                    BackColor = Color.FromArgb(157, 105, 163),
                    Tag = catagory
                };
                button.Click += new EventHandler(Catagory_Click);
                flpnl_MainCatagories.Controls.Add(button);
            }
        }

        private void Catagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string catagory = (string)button.Tag;

            //AddOrderItem(catagory);
        }


        private void DisplaySubCatogories()
        {

        }
    }
}

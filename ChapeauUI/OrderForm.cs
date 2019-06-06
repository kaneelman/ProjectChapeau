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
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class OrderForm : BaseForm
    {
        const int SIZE = 110;

        public OrderForm(Employee LoggedUser)
        {
            InitializeComponent();
            LoggedInEmployee = LoggedUser;

            DisplayMainCatagories();

       
        }

        private void lst_NewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_NewOrderBack_Click(object sender, EventArgs e)
        {
            OrderForm o1 = new OrderForm(LoggedInEmployee);
            o1.Close();

            TableViewForm t1 = new TableViewForm(LoggedInEmployee);
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
                    Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
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

            if (catagory == "Lunch")
            {
               

            }

            if (catagory == "Diner")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagories.Controls.Clear();

                List<string> subCatagories = new List<string>();

                subCatagories.Add("Tenderloin");
                subCatagories.Add("Lamb chops");
                subCatagories.Add("Fish stew");

                foreach (string subcatagory in subCatagories)
                {
                    BaseButton btn_LunchItems = new BaseButton
                    {
                        Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                        Text = subcatagory,
                        BackColor = Color.FromArgb(157, 105, 163),
                        Tag = subcatagory
                    };
                    btn_LunchItems.Click += new EventHandler(SubCatagory_Click);
                    flpnl_SubCatagories.Controls.Add(btn_LunchItems);
                }
            }
            if (catagory == "Drinks")
            {

            }

            //AddOrderItem(catagory);
        }

        private void SubCatagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string subcatagory = (string)button.Tag;

            if (subcatagory == "Tenderloin")
            {

            }
            if (subcatagory == "Lamb chops")
            {

            }
            if (subcatagory == "fish stew")
            {

            }
        }

        private void DisplaySubCatogories()
        {

        }

        //private void DisplaySubCatogories()
        //{

        //}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewOrderClearItems_Click(object sender, EventArgs e)
        {

        }

        private void flpnl_SubCatagories_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

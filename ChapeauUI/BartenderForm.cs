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
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class BartenderForm : BaseForm
    {
        //constants
        const int SIZE = 100;

        public BartenderForm(Employee LoggedUser)
        {
            LoggedInEmployee = LoggedUser;
            InitializeComponent();
            DisplayOrders();
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayOrders()
        {
            flpnl_Orders.Controls.Clear();

            List<string> Orders = new List<string>();

            Orders.Add("Lunch");
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

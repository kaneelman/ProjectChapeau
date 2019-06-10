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
    public partial class ChefForm : BaseForm
    {
        //constants
        const int SIZE = 100;

        //calling required services
        ChapeauLogic.OrderService Orders = new ChapeauLogic.OrderService();

        List<DateTime> OrderTimeList = new List<DateTime>();
        List<Image> TableImages;

        public ChefForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            TableImages = CreateTableImagesList();

            DisplayOrders();
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayOrders()
        {
            flpnl_Orders.Controls.Clear();
            ClearOrderTimeList();

            List<Order> orders = Orders.GetKitchenBeingPreparedOrders();
            List<string> DateAndStatus = new List<string>();
            DateAndStatus.Add("00:01:24\nRunning");
            DateAndStatus.Add("00:01:25\nRunning");
            DateAndStatus.Add("00:01:26\nRunning");
            DateAndStatus.Add("00:01:27\nRunning");
            DateAndStatus.Add("00:01:28\nFinished");
            DateAndStatus.Add("00:01:29\nFinished");
            DateAndStatus.Add("00:01:30\nFinished");
            DateAndStatus.Add("00:01:31\nFinished");
            DateAndStatus.Add("00:01:32\nFinished");
            DateAndStatus.Add("00:01:33\nFinished");
            int ListCounter = 0;

            //adding orders to the order listview with beingprepared as condition
            foreach (ChapeauModel.Order order in orders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (!OrderTimeList.Contains(item.TimeStamp))
                    {
                        OrderTimeList.Add(item.TimeStamp);
                    }
                }
            }

            //creating the buttons
            foreach (DateTime time in OrderTimeList)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[TableNumProcessor(time)], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Cyan,
                    Tag = time,
                    Padding = new Padding(0, 0, 25, 0),
                    Text = DateAndStatus[ListCounter],
                    TextAlign = ContentAlignment.MiddleRight,
                };
                button.Click += new EventHandler(Order_Click);
                flpnl_Orders.Controls.Add(button);
                ListCounter++;
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            DateTime time = (DateTime)((Button)sender).Tag;

            PicBox_TableNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_TableNumber.Image = TableImages[TableNumProcessor(time)];

            lst_Orders.Clear();

            lst_Orders.GridLines = true;
            lst_Orders.View = View.Details;
            lst_Orders.Columns.Add("Amount", 70, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Order", 190, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Comment", 300, HorizontalAlignment.Left);

            foreach (ChapeauModel.Order order in Orders.GetKitchenBeingPreparedSpecialOrders(time, OrderIDProcessor(time)))
            {
                foreach (OrderMenuItem item in order.content)
                {
                    ListViewItem li = new ListViewItem(item.Quantity.ToString());
                    li.SubItems.Add(item.GetMenuItem().Name);
                    li.SubItems.Add(item.Comment);
                    lst_Orders.Items.Add(li);
                }
            }
        }

        public List<Image> CreateTableImagesList()
        {
            List<Image> images = new List<Image>();

            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_1.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_1.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_2.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_3.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_4.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_5.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_6.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_7.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_8.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_9.PNG"));
            images.Add(Image.FromFile(".\\..\\..\\TableNumImages\\Table_10.PNG"));

            return images;
        }

        public int TableNumProcessor(DateTime time)
        {
            List<Order> orders = Orders.GetKitchenBeingPreparedOrders();
            int tablenum = 0;

            foreach (ChapeauModel.Order order in orders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (time == item.TimeStamp)
                    {
                        tablenum = order.Table.Id;
                        break;
                    }
                }
            }
            return tablenum;
        }

        public int OrderIDProcessor(DateTime time)
        {
            List<Order> orders = Orders.GetKitchenBeingPreparedOrders();
            int orderid = 0;

            foreach (ChapeauModel.Order order in orders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (time == item.TimeStamp)
                    {
                        orderid = order.Id;
                        break;
                    }
                }
            }
            return orderid;
        }

        public void ClearOrderTimeList()
        {
            OrderTimeList.Clear();
        }
    }
}

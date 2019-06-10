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

        //calling required services
        ChapeauLogic.OrderService Orders = new ChapeauLogic.OrderService();

        List<DateTime> OrdersTimeList = new List<DateTime>();
        List<DateTime> ReadyToServeOrdersTimeList = new List<DateTime>();
        List<DateTime> BeingPreparedOrdersTimeList = new List<DateTime>();
        List<DateTime> ServedOrdersTimeList = new List<DateTime>();
        List<Image> TableImages;

        public BartenderForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            TableImages = CreateTableImagesList();

            DisplayOrders();
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayOrders()
        {
            flpnl_Orders.Controls.Clear();
            ClearOrdersTimeList();
            
            List<Order> beingpreparedorders = Orders.GetBarBeingPreparedOrders();
            List<Order> readytoserveorders = Orders.GetBarReadyToServeOrders();
            List<Order> servedorders = Orders.GetBarServedOrders();
            List<string> DateAndStatus = new List<string>();
            DateAndStatus.Add("00:04:12\nRunning");
            DateAndStatus.Add("00:07:07\nRunning");
            DateAndStatus.Add("00:08:53\nRunning");
            DateAndStatus.Add("00:17:02\nReady");
            DateAndStatus.Add("00:18:22\nServed");
            DateAndStatus.Add("00:09:37\nServed");
            DateAndStatus.Add("00:20:49\nServed");
            DateAndStatus.Add("00:01:31\nFinished");
            DateAndStatus.Add("00:01:32\nFinished");
            DateAndStatus.Add("00:01:33\nFinished");
            int ListCounter = 0;

            //adding orders to the order listview with beingprepared as condition
            foreach (ChapeauModel.Order order in beingpreparedorders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (!BeingPreparedOrdersTimeList.Contains(item.TimeStamp))
                    {
                        BeingPreparedOrdersTimeList.Add(item.TimeStamp);
                        OrdersTimeList.Add(item.TimeStamp);
                    }
                }
            }

            //adding orders to the order listview with readytoserve as condition
            foreach (ChapeauModel.Order order in readytoserveorders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (!ReadyToServeOrdersTimeList.Contains(item.TimeStamp))
                    {
                        ReadyToServeOrdersTimeList.Add(item.TimeStamp);
                        OrdersTimeList.Add(item.TimeStamp);
                    }
                }
            }

            //adding orders to the order listview with served as condition
            foreach (ChapeauModel.Order order in servedorders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (!ServedOrdersTimeList.Contains(item.TimeStamp))
                    {
                        ServedOrdersTimeList.Add(item.TimeStamp);
                        OrdersTimeList.Add(item.TimeStamp);
                    }
                }
            }

            //adding buttons based on datetime ordering
            foreach (DateTime time in OrdersTimeList)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[TableNumProcessor(time)], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorProcessor(time),
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
            lst_Orders.Columns.Add("Comment", 600, HorizontalAlignment.Left);

            foreach (ChapeauModel.Order order in Orders.GetBarBeingPreparedSpecialOrders(time, OrderIDProcessor(time)))
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


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flpnl_Orders_Paint(object sender, PaintEventArgs e)
        {

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
            int tablenum = 0;
            List<Order> allorders = Orders.GetAllOrders();

            foreach (ChapeauModel.Order order in allorders)
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
            List<Order> allorders = Orders.GetAllOrders();
            int orderid = 0;

            foreach (ChapeauModel.Order order in allorders)
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

        public Color ButtonColorProcessor(DateTime time)
        {
            List<Order> allorders = Orders.GetAllOrders();
            Color color = Color.White;
            string status = null;

            foreach (ChapeauModel.Order order in allorders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (time == item.TimeStamp)
                    {
                        status = item.Status.ToString();
                        break;
                    }
                }
            }

            switch (status)
            {
                case "BeingPrepared": color = Color.LightGreen; break;
                case "ReadyToServe": color = Color.Cyan; break;
                case "Served": color = Color.LightGray; break;
                default: color = Color.Red; break;
            }

            return color;
        }

        public void ClearOrdersTimeList()
        {
            OrdersTimeList.Clear();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlp_Orders_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
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

        //creating lists
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

            //prep
            TableImages = CreateTableImagesList();
            lbl_OrderStatus.Hide();
            lbl_OrderTime.Hide();
            dtp_OrderDate.Hide();

            DisplayOrders();
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayOrders()
        {
            //removing old data for new data
            flpnl_Orders.Controls.Clear();
            ClearAllOrdersTimeList();
            
            //grabbing lists of running, ready, and served orders
            List<Order> beingpreparedorders = Orders.GetBarBeingPreparedOrders();
            List<Order> readytoserveorders = Orders.GetBarReadyToServeOrders();
            List<Order> servedorders = Orders.GetBarServedOrders();
            string status = null, ordertext = null;

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
                status = GetStatus(time);

                if (status == "Served" | status == "ReadyToServe")
                {
                    ordertext = StatusConverter(status);
                }
                else
                {
                    ordertext = OrderTextProcessor(time);
                }

                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[TableNumProcessor(time)], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorProcessor(time),
                    Tag = time,
                    Padding = new Padding(0, 0, 25, 0),
                    Text = ordertext,
                    TextAlign = ContentAlignment.MiddleRight,
                };
                button.Click += new EventHandler(Order_Click);
                flpnl_Orders.Controls.Add(button);
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            //grabbing the object tag
            DateTime time = (DateTime)((Button)sender).Tag;

            //inputting and displaying additional info
            PicBox_TableNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_TableNumber.Image = TableImages[TableNumProcessor(time)];
            lbl_OrderTime.Show();
            lbl_OrderTime.Text = "Time Ordered: " + time.ToString("HH:mm:ss");
            lbl_OrderStatus.Show();
            lbl_OrderStatus.Text = "Status: " + StatusConverter(GetStatus(time));
            dtp_OrderDate.Value = time;

            //clearing list view
            lst_Orders.Clear();

            //adding columns and items to the list view
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

        ////sorting stuff
        //sort by running
        private void Btn_SortByRunning_Click(object sender, EventArgs e)
        {
            //removing old data for new data
            flpnl_Orders.Controls.Clear();
            ClearAllOrdersTimeList();

            //grabbing lists of running, ready, and served orders
            List<Order> beingpreparedorders = Orders.GetBarBeingPreparedOrders();
            List<Order> readytoserveorders = Orders.GetBarReadyToServeOrders();
            List<Order> servedorders = Orders.GetBarServedOrders();
            string status = null, ordertext = null;

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
                status = GetStatus(time);

                if (status == "Served" | status == "ReadyToServe")
                {
                    ordertext = StatusConverter(status);
                }
                else
                {
                    ordertext = OrderTextProcessor(time);
                }

                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[TableNumProcessor(time)], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorProcessor(time),
                    Tag = time,
                    Padding = new Padding(0, 0, 25, 0),
                    Text = ordertext,
                    TextAlign = ContentAlignment.MiddleRight,
                };
                button.Click += new EventHandler(Order_Click);
                flpnl_Orders.Controls.Add(button);
            }
        }

        ////sorting stuff
        //sort by ready
        private void Btn_SortByFinished_Click(object sender, EventArgs e)
        {
            //removing old data for new data
            flpnl_Orders.Controls.Clear();
            ClearAllOrdersTimeList();

            //grabbing lists of running, ready, and served orders
            List<Order> beingpreparedorders = Orders.GetBarBeingPreparedOrders();
            List<Order> readytoserveorders = Orders.GetBarReadyToServeOrders();
            List<Order> servedorders = Orders.GetBarServedOrders();
            string status = null, ordertext = null;

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
                status = GetStatus(time);

                if (status == "Served" | status == "ReadyToServe")
                {
                    ordertext = StatusConverter(status);
                }
                else
                {
                    ordertext = OrderTextProcessor(time);
                }

                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[TableNumProcessor(time)], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorProcessor(time),
                    Tag = time,
                    Padding = new Padding(0, 0, 25, 0),
                    Text = ordertext,
                    TextAlign = ContentAlignment.MiddleRight,
                };
                button.Click += new EventHandler(Order_Click);
                flpnl_Orders.Controls.Add(button);
            }
        }

        //updating order as ready
        private void Btn_MarkFinished_Click(object sender, EventArgs e)
        {
            DateTime time = dtp_OrderDate.Value;
            Orders.UpdateBarStatus(time);
        }

        //creates a list of images
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

        //returns the table number of an order
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

        //returns the orderid number of an order
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

        //returns a color based on the status of an order
        public Color ButtonColorProcessor(DateTime time)
        {
            Color color = Color.White;
            string status = null;

            status = GetStatus(time);

            switch (status)
            {
                case "BeingPrepared": color = Color.LightGreen; break;
                case "ReadyToServe": color = Color.Cyan; break;
                case "Served": color = Color.LightGray; break;
                default: color = Color.Red; break;
            }

            return color;
        }

        //returns additional info text for the order list view
        public string OrderTextProcessor(DateTime time)
        {
            DateTime currenttime = DateTime.Now;
            string status = null, text = null;

            status = GetStatus(time);

            TimeSpan timedifference = (currenttime - time);
            text = ($"{timedifference.Hours:00}:{timedifference.Minutes:00}:{timedifference.Seconds:00}\n{StatusConverter(status)}");
            return text;
        }

        //refreshes info for receiving up to date data
        public void ClearAllOrdersTimeList()
        {
            OrdersTimeList.Clear();
            ReadyToServeOrdersTimeList.Clear();
            BeingPreparedOrdersTimeList.Clear();
            ServedOrdersTimeList.Clear();
        }

        //returns the status of an order
        public string GetStatus(DateTime time)
        {
            List<Order> allorders = Orders.GetAllOrders();
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
            return status;
        }

        //converts the status for the order list view
        public string StatusConverter(string status)
        {
            switch (status)
            {
                case "ReadyToServe": return "Ready"; break;
                case "BeingPrepared": return "Running"; break;
                case "Served": return "Finished"; break;
                default: return "Oopsie"; break;
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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlp_Orders_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

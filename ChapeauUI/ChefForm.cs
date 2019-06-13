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
        //calling required services
        ChapeauLogic.OrderService Orders = new ChapeauLogic.OrderService();

        //constants
        const int SIZE = 100;

        //fields
        bool sorting = true;
        int tablenum = 0, orderid = 0;
        string status = null, ordertext = null, waiter = null;

        //creating lists
        List<DateTime> OrdersTimeList = new List<DateTime>();
        List<Image> TableImages;

        public ChefForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            //prep
            dtp_OrderDate.Hide();
            TableImages = CreateTableImagesList();
            EmptyAdditionalData();

            //start
            DisplayOrders();
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayOrders()
        {
            //removing old data for new data
            ClearAllTempData();

            //grabbing lists of running, ready, and served orders
            List<DateTime> beingpreparedorders = Orders.GetKitchenBeingPreparedOrdersGroupedByDateTime();
            List<DateTime> readytoserveorders = Orders.GetKitchenReadyToServeOrdersGroupedByDateTime();
            List<DateTime> servedorders = Orders.GetKitchenServedOrdersGroupedByDateTime();

            if (sorting == true)
            {
                //adding orders to the order listview with beingprepared as condition
                foreach (DateTime time in beingpreparedorders)
                {
                    OrdersTimeList.Add(time);
                }

                //adding orders to the order listview with readytoserve as condition
                foreach (DateTime time in readytoserveorders)
                {
                    OrdersTimeList.Add(time);
                }

            }
            else if (sorting == false)
            {
                //adding orders to the order listview with readytoserve as condition
                foreach (DateTime time in readytoserveorders)
                {
                    OrdersTimeList.Add(time);
                }

                //adding orders to the order listview with beingprepared as condition
                foreach (DateTime time in beingpreparedorders)
                {
                    OrdersTimeList.Add(time);
                }
            }
            else
            {
                MessageBox.Show("Oopsie something went wrong\nSorting it by default which is 'running'");
                Btn_SortByRunning_Click(null, EventArgs.Empty);
            }

            //adding orders to the order listview with served as condition
            foreach (DateTime time in servedorders)
            {
                OrdersTimeList.Add(time);
            }

            //adding buttons based on datetime ordering
            foreach (DateTime time in OrdersTimeList)
            {
                //grabbing all neccesary data
                UpdateDataByReference(time, ref tablenum, ref orderid, ref ordertext, ref status, ref waiter);

                if (status == "Served" | status == "ReadyToServe")
                {
                    ordertext = StatusTextConverter(status);
                }

                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(TableImages[tablenum], new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = ButtonColorPicker(status),
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

            //grabbing all necessary data
            UpdateDataByReference(time, ref tablenum, ref orderid, ref ordertext, ref status, ref waiter);

            //hiding the mark as ready button if it's ready or served
            if (status == "Served" | status == "ReadyToServe")
            {
                btn_MarkFinished.Hide();
            }
            else
            {
                btn_MarkFinished.Show();
            }

            //inputting and displaying additional info
            PicBox_TableNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_TableNumber.Image = TableImages[tablenum];
            lbl_OrderTime.Text = "Time Ordered: " + time.ToString("HH:mm:ss");
            lbl_OrderStatus.Text = "Status: " + StatusTextConverter(status);
            lbl_OrderHandledBy.Text = "Handled by: " + waiter;
            dtp_OrderDate.Value = time;

            //clearing list view
            lst_Orders.Clear();

            //adding columns and items to the list view
            lst_Orders.GridLines = true;
            lst_Orders.View = View.Details;
            lst_Orders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lst_Orders.Columns.Add("Amount", 70, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Order", 150, HorizontalAlignment.Left);
            lst_Orders.Columns.Add("Comment", 600, HorizontalAlignment.Left);

            foreach (ChapeauModel.Order order in Orders.GetKitchenBeingPreparedSpecialOrders(time, orderid))
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
            //prepping the sorting method
            sorting = true;
            EmptyAdditionalData();

            DisplayOrders();
        }

        //sort by ready
        private void Btn_SortByFinished_Click(object sender, EventArgs e)
        {
            //setting the sorting method bool
            sorting = false;
            EmptyAdditionalData();

            DisplayOrders();
        }

        //updating order as ready
        private void Btn_MarkFinished_Click(object sender, EventArgs e)
        {
            DateTime time = dtp_OrderDate.Value;
            Orders.UpdateKitchenStatus(time);
            EmptyAdditionalData();

            DisplayOrders();
        }

        //updating field datas for current method
        private void UpdateDataByReference(DateTime time, ref int tablenum, ref int orderid, ref string ordertext, ref string status, ref string waiter)
        {
            //prep
            List<Order> allorders = Orders.GetAllKitchenOrdersByOccupation();
            DateTime currenttime = DateTime.Now;
            TimeSpan timedifference = (currenttime - time);

            foreach (ChapeauModel.Order order in allorders)
            {
                foreach (OrderMenuItem item in order.content)
                {
                    if (time == item.TimeStamp)
                    {
                        waiter = order.HandledBy.Name;
                        tablenum = order.Table.Id;
                        orderid = order.Id;
                        status = item.Status.ToString();
                        ordertext = ($"{timedifference.Hours:00}:{timedifference.Minutes:00}:{timedifference.Seconds:00}\n{StatusTextConverter(status)}");
                        return;
                    }
                }
            }
        }

        //creates a list of images
        private List<Image> CreateTableImagesList()
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

        //returns a color based on the status of an order
        private Color ButtonColorPicker(string status)
        {
            Color color = Color.White;

            switch (status)
            {
                case "BeingPrepared": color = Color.LightGreen; break;
                case "ReadyToServe": color = Color.Cyan; break;
                case "Served": color = Color.LightGray; break;
                default: color = Color.Red; break;
            }

            return color;
        }

        //refreshes info for receiving up to date data for order list view
        private void ClearAllTempData()
        {
            OrdersTimeList.Clear();
            flpnl_Orders.Controls.Clear();
            tablenum = 0;
            orderid = 0;
            status = null;
            ordertext = null;
            waiter = null;
        }

        //converts the status for the order list view
        private string StatusTextConverter(string status)
        {
            switch (status)
            {
                case "ReadyToServe": return "Ready"; break;
                case "BeingPrepared": return "Running"; break;
                case "Served": return "Finished"; break;
                default: return "Oopsie"; break;
            }
        }

        //empties additional info data from order list table
        private void EmptyAdditionalData()
        {
            PicBox_TableNumber.Image = null;
            lbl_OrderTime.Text = null;
            lbl_OrderStatus.Text = null;
            lbl_OrderHandledBy.Text = null;
            lst_Orders.Clear();
            btn_MarkFinished.Hide();
        }

        //refreshing order list view every 5 min for slow database calling duration reasons
        //disabled temporarily
        private void Timer_OrderListView_Tick(object sender, EventArgs e)
        {
            //if (sorting == true)
            //{
            //    SortByRunning_Run();
            //}
            //else if (sorting == false)
            //{
            //    SortByReady_Run();
            //}
            //else
            //{
            //    MessageBox.Show("Oopsie something went wrong\nSorting it by default which is 'running'");
            //    SortByRunning_Run();
            //}
        }
    }
}
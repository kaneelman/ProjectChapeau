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
        List<string> Categories = new List<string>() { "Breakfast", "Lunch", "Dinner" };
        List<string> OrderDetails = new List<string>() { "two number nines", "a number nine large", "a number 6 with extra dip", "two number forty fives", "one with cheese", "and a large soda" };

        public BartenderForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;

            DisplayOrders();
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayOrders()
        {
            //temporary clear
            flpnl_Orders.Controls.Clear();

            List<Image> Tables = CreateTableList();
            List<string> DateAndStatus = new List<string>();
            int ListCounter = 0;

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

            foreach (Image table in Tables)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(SIZE * 2.65), (int)(SIZE * 1)),
                    Image = new Bitmap(table, new Size(100, 100)),
                    ImageAlign = ContentAlignment.MiddleLeft,
                    BackColor = Color.Cyan,
                    Tag = table,
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
            //button stuff
            Image table = (Image)((Button)sender).Tag;

            PicBox_TableNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            PicBox_TableNumber.Image = table;

            //tlp_Orders.ColumnCount = 3;
            //tlp_Orders.RowCount = 1;

            //tlp_Orders.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            //tlp_Orders.Controls.Add(new Label() { Text = $"{Categories[0]}" }, 1, 1);

            //foreach (string order in OrderDetails)
            //{
            //    tlp_Orders.RowCount = tlp_Orders.RowCount + 1;
            //    tlp_Orders.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //    tlp_Orders.Controls.Add(new Label() { Text = order }, 1, tlp_Orders.RowCount - 1 );
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

        public List<Image> CreateTableList()
        {
            List<Image> images = new List<Image>();

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

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlp_Orders_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

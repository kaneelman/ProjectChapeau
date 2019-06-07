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
    public partial class TableViewForm : BaseForm
    {
        //"constant" colors of the table
        Color FREE_COLOR = Color.FromArgb(51, 255, 119); // Green
        Color OCCUPIED_COLOR = Color.FromArgb(0, 102, 153); // Blue
        Color RESERVED_COLOR = Color.FromArgb(255, 102, 102); // Red

        //constant tablebutton size
        const int SIZE = 150;

        DiningTableService diningTableDB = new DiningTableService();
        OrderService orderDB = new OrderService();

        public TableViewForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            // Assign the right colors to the table legend
            lbl_FreeColor.BackColor = FREE_COLOR;
            lbl_OccupiedColor.BackColor = OCCUPIED_COLOR;
            lbl_ReservedColor.BackColor = RESERVED_COLOR;

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;            

            //Run code to display tables
            DisplayTables();
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayTables()
        {
            flpnl_DiningTables.Controls.Clear();

            // Get list of all tables from the database
            List<DiningTable> diningTables = diningTableDB.GetDiningTables();

            // Used loop to fill the flow panel with buttons for all the tables
            foreach (DiningTable table in diningTables)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size(SIZE, SIZE),
                    Font = new Font("Arial", 40, FontStyle.Bold),
                    Text = table.Id.ToString(),
                    BackColor = DetermineTableColor(table),
                    Tag = table
                };
                button.Click += new EventHandler(Table_Click);
                flpnl_DiningTables.Controls.Add(button);
            }
        }

        // Method do determing the color of the table, fitting the table status
        private Color DetermineTableColor(DiningTable table)
        {
            switch (table.Status)
            {
                case TableStatus.Free:
                    return FREE_COLOR; // Green
                case TableStatus.Occupied:
                    return OCCUPIED_COLOR; // Blue
                case TableStatus.Reserved:
                    return RESERVED_COLOR; // Red                  
                default:
                    throw new Exception("Incorrect table status input");                    
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            DiningTable table = (DiningTable)button.Tag;

            switch (table.Status)
            {
                case TableStatus.Free:
                    //SOME CODE
                    break;
                case TableStatus.Occupied:
                    //Will change to current order overview eventually
                    PaymentForm paymentForm = new PaymentForm(LoggedInEmployee, loginForm, orderDB.GetCompleteActiveOrderByTable(table));
                    paymentForm.Show();
                    break;
                case TableStatus.Reserved:
                    //SOME CODE
                    break;                 
                default:
                    throw new Exception("Incorrect table status input");
            }
        }

        private void flpnl_DiningTables_Paint(object sender, PaintEventArgs e)
        {

        }

        // Reload TableView flow panel on every tick
        private void tableViewRefresher_Tick(object sender, EventArgs e)
        {
            DisplayTables();
        }
    }
}

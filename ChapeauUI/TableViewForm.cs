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
        DiningTableService diningTableDB = new DiningTableService();

        const int SIZE = 150;

        public TableViewForm(Employee LoggedUser, LoginForm loginForm)
        {
            InitializeComponent();

            //Saving the user that is logged in and passing the login form, have it's reference
            LoggedInEmployee = LoggedUser;
            this.loginForm = loginForm;            

            DisplayTables();
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayTables()
        {
            flpnl_DiningTables.Controls.Clear();

            List<DiningTable> diningTables = diningTableDB.GetDiningTables();

            foreach (DiningTable table in diningTables)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size(SIZE, SIZE),
                    Text = table.Id.ToString(),
                    BackColor = Color.FromArgb(157, 105, 163),
                    Tag = table
                };
                button.Click += new EventHandler(Table_Click);
                flpnl_DiningTables.Controls.Add(button);
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {

        }

        private void flpnl_DiningTables_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

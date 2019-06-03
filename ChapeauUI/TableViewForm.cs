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
        public TableViewForm(Employee LoggedUser)
        {
            LoggedInEmployee = LoggedUser;
            InitializeComponent();
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}

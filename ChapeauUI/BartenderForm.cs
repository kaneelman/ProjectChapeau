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
        }

        private void BartenderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

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
    public partial class BaseForm : Form
    {
        public LoginForm loginForm;
        protected Employee LoggedInEmployee;
        //public static Employee LoggedInEmployee; //just to check the payment

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            //Showing the loginForm again and hiding current form
            loginForm.Show();
            LoggedInEmployee = null;
            this.Close();
            
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Also closing Login form on close
            if(loginForm != null)
            {
                loginForm.Close();
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Maybe some info on closing?
        }
    }
}

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
    public partial class LoginForm : BaseForm
    {
        EmployeeService EmployeeDB = new EmployeeService();

        public LoginForm()
        {
            this.Btn_LogOut.Hide();
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (EmployeeDB.CheckUsername(txt_LoginUsername.Text))
            {
                if (EmployeeDB.CheckPassword(txt_LoginUsername.Text, txt_LoginPassword.Text))
                {
                    LoggedInEmployee = EmployeeDB.GetEmployee(txt_LoginUsername.Text);

                    switch (LoggedInEmployee.Position)
                    {
                        default:
                            break;
                    }
                } else
                {
                    MessageBox.Show("Incorrect Password", "", MessageBoxButtons.OK);
                }
            } else
            {
                MessageBox.Show($"User {txt_LoginUsername.Text} does not exist.", "", MessageBoxButtons.OK);
            }
        }
    }
}

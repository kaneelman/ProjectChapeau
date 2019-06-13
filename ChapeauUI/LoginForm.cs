﻿using System;
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
            //Hiding log out button on login page
            this.Btn_LogOut.Hide();
            
            InitializeComponent();
            
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

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
                        case EmployeePosition.Bartender:
                            TableViewForm tableViewForm = new TableViewForm(LoggedInEmployee, this);
                            tableViewForm.Show();
                            break;
                        case EmployeePosition.Chef:
                            BartenderForm barForm = new BartenderForm(LoggedInEmployee, this);
                            barForm.Show();
                            break;
                        case EmployeePosition.Waiter:
                            TableViewForm tableViewForm2 = new TableViewForm(LoggedInEmployee, this);
                            tableViewForm2.Show();
                            break;

                            //OrderForm orderForm = new OrderForm(LoggedInEmployee, this);
                            //orderForm.Show();
                            //break;
                        case EmployeePosition.Manager:
                            ChefForm chefForm = new ChefForm(LoggedInEmployee, this);
                            chefForm.Show();
                            //MessageBox.Show("NO MANAGER FUNCTIONS AVAILABLE", "", MessageBoxButtons.OK);
                            break;
                        default:
                            break;
                    }

                    //Hide this form
                    Hide();
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

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class OrderForm : BaseForm
    {
        const int SIZE = 110;

        public OrderForm(Employee LoggedUser)
        {
            InitializeComponent();
            LoggedInEmployee = LoggedUser;

            DisplayMainCatagories();

       
        }

        private void lst_NewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_NewOrderBack_Click(object sender, EventArgs e)
        {
            OrderForm o1 = new OrderForm(LoggedInEmployee);
            o1.Close();

            TableViewForm t1 = new TableViewForm(LoggedInEmployee);
            t1.Show();
           
        }


        private void flpnl_MainCatagories_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayMainCatagories()
        {
            flpnl_MainCatagories.Controls.Clear();

            List<string> mainCatagories = new List<string>();

            mainCatagories.Add("Lunch");
            mainCatagories.Add("Diner");
            mainCatagories.Add("Drinks");
 
            foreach (string catagory in mainCatagories)
            {
                BaseButton button = new BaseButton
                {
                    Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                    Text = catagory,
                    BackColor = Color.FromArgb(157, 105, 163),
                    Tag = catagory
                };
                button.Click += new EventHandler(Catagory_Click);
                flpnl_MainCatagories.Controls.Add(button);
            }

         
        }

        private void Catagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string catagory = (string)button.Tag;

            if (catagory == "Lunch")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagories.Controls.Clear();

                List<string> subCatagories = new List<string>();

                subCatagories.Add("Lunch Main");
                subCatagories.Add("Lunch Bite");
                subCatagories.Add("Lunch Special");

                foreach (string subcatagory in subCatagories)
                {
                    BaseButton btn_LunchItems = new BaseButton
                    {
                        Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                        Text = subcatagory,
                        BackColor = Color.FromArgb(157, 105, 163),
                        Tag = subcatagory
                    };
                    btn_LunchItems.Click += new EventHandler(SubCatagory_Click);
                    flpnl_SubCatagories.Controls.Add(btn_LunchItems);
                }
            }

            else if (catagory == "Diner")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagories.Controls.Clear();

                List<string> subCatagories = new List<string>();

                subCatagories.Add("Dinner Main");
                subCatagories.Add("Dinner Dessert");
                subCatagories.Add("Dinner Starter");

                foreach (string subcatagory in subCatagories)
                {
                    BaseButton btn_LunchItems = new BaseButton
                    {
                        Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                        Text = subcatagory,
                        BackColor = Color.FromArgb(157, 105, 163),
                        Tag = subcatagory
                    };
                    btn_LunchItems.Click += new EventHandler(SubCatagory_Click);
                    flpnl_SubCatagories.Controls.Add(btn_LunchItems);
                }
            }
            else if (catagory == "Drinks")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagories.Controls.Clear();

                List<string> subCatagories = new List<string>();

                subCatagories.Add("Beers");
                subCatagories.Add("Hot drinks");
                subCatagories.Add("Soft drinks");
                subCatagories.Add("Wines");


                foreach (string subcatagory in subCatagories)
                {
                    BaseButton btn_LunchItems = new BaseButton
                    {
                        Size = new Size((int)(1.1 * SIZE), (int)(0.6 * SIZE)),
                        Text = subcatagory,
                        BackColor = Color.FromArgb(157, 105, 163),
                        Tag = subcatagory
                    };
                    btn_LunchItems.Click += new EventHandler(SubCatagory_Click);
                    flpnl_SubCatagories.Controls.Add(btn_LunchItems);
                }
            }

            ///AddOrderItem(catagory);
        }

        private void SubCatagory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string LunchSubcatagoryItem = (string)button.Tag;

            if (LunchSubcatagoryItem == "Lunch Main")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagoryItems.Controls.Clear();

                List<string> LunchMainSubcatagoryItems = new List<string>();

                LunchMainSubcatagoryItems.Add("Lasagne");
                LunchMainSubcatagoryItems.Add("Pizza");
                LunchMainSubcatagoryItems.Add("Biryani");
                LunchMainSubcatagoryItems.Add("Macaroni");
                
                foreach (string LuchMainSubCatagoryItem in LunchMainSubcatagoryItems)
                {
                    BaseButton btn_LunchMainItems = new BaseButton
                    {
                        Size = new Size((int)(1 * SIZE), (int)(0.4 * SIZE)),
                        Text = LuchMainSubCatagoryItem,
                        BackColor = Color.FromArgb(144, 238, 144),
                        Tag = LuchMainSubCatagoryItem
                    };
                    btn_LunchMainItems.Click += new EventHandler(btn_LunchMainItems_Click);
                    flpnl_SubCatagoryItems.Controls.Add(btn_LunchMainItems);
                }


            }


            else if (LunchSubcatagoryItem == "Lunch Bite")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagoryItems.Controls.Clear();

                List<string> LuchBiteSubCatagoryItems = new List<string>();

                LuchBiteSubCatagoryItems.Add("frits");
                LuchBiteSubCatagoryItems.Add("patatoes");
                LuchBiteSubCatagoryItems.Add("Salmon");
                LuchBiteSubCatagoryItems.Add("Bread");

                foreach (string LuchBiteSubCatagoryItem in LuchBiteSubCatagoryItems)
                {
                    BaseButton btn_LunchBiteItems = new BaseButton
                    {
                        Size = new Size((int)(1 * SIZE), (int)(0.4 * SIZE)),
                        Text = LuchBiteSubCatagoryItem,
                        BackColor = Color.FromArgb(144, 238, 144),
                        Tag = LuchBiteSubCatagoryItem
                    };
                    btn_LunchBiteItems.Click += new EventHandler(btn_LunchBiteItems_Click);
                    flpnl_SubCatagoryItems.Controls.Add(btn_LunchBiteItems);
                }
            }

            else if (LunchSubcatagoryItem == "Lunch Special")
            {
                //flpnl_SubCatagories
                flpnl_SubCatagoryItems.Controls.Clear();

                List<string> LuchSpecialSubCatagoryItems = new List<string>();

                LuchSpecialSubCatagoryItems.Add("salade");
                LuchSpecialSubCatagoryItems.Add("chicken wings");
                LuchSpecialSubCatagoryItems.Add("fish");
                LuchSpecialSubCatagoryItems.Add("Turkey");

                foreach (string LuchSpecialSubCatagoryItem in LuchSpecialSubCatagoryItems)
                {
                    BaseButton btn_LunchSpecialItems = new BaseButton
                    {
                        Size = new Size((int)(1 * SIZE), (int)(0.4 * SIZE)),
                        Text = LuchSpecialSubCatagoryItem,
                        BackColor = Color.FromArgb(144, 238, 144),
                        Tag = LuchSpecialSubCatagoryItem
                    };
                    btn_LunchSpecialItems.Click += new EventHandler(btn_LunchSpecialItems_Click);
                    flpnl_SubCatagoryItems.Controls.Add(btn_LunchSpecialItems);
                }
            }

        }


        private void btn_LunchMainItems_Click(object sender, EventArgs e)
        {
        }
        private void btn_LunchBiteItems_Click(object sender, EventArgs e)
        {   
        }
        private void btn_LunchSpecialItems_Click(object sender, EventArgs e)
        {
        }
        private void DisplaySubCatogories()
        {

        }

        //private void DisplaySubCatogories()
        //{

        //}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewOrderClearItems_Click(object sender, EventArgs e)
        {

        }

        private void flpnl_SubCatagories_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

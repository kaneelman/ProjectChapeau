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
    public partial class ChefForm : BaseForm
    {
        public ChefForm(Employee LoggedUser)
        {
            LoggedInEmployee = LoggedUser;
            InitializeComponent();
        }
    }
}

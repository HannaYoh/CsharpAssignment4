﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrice.Text = " ";
            txtProductName.Text = " ";
            txtQuantity.Text = " ";
        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "admin")
            {
                Form1 home = new Form1(username, this);
                home.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Entry");
                txtUsername.Clear();
                txtPassword.Clear();
                
                
            }
            
        }
    }
}
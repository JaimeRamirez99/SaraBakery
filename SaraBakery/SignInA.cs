﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaraBakery
{
    public partial class SignIn : Form
    {
        public static string user = "";
        public static string password = "";
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            if (user == "Sara1010" && password == "1001004361")
            {
                this.Hide();
                Dashboard abrir = new Dashboard();
                abrir.Show();
                abrir.lblUser.Text = txtUser.Text;
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                txtUser.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}

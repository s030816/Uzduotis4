﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzduotis4
{
    public partial class LoginForm : Form
    {
        private bool authorizeState = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!authorizeState)
            {
                Application.Exit();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //userTxtBox.Text;
            //pwTxtBox.Text;
            if (File.Exists(userTxtBox.Text + ".txt"))
            {
                CryptoUtility crypt = new CryptoUtility();
                
                if(crypt.PwAuthorize(pwTxtBox.Text,File.ReadAllText(userTxtBox.Text + ".txt")))
                {
                    MessageBox.Show("True");
                }
                else
                {
                    MessageBox.Show("False");
                }
                //authorizeState = true;
                //Close();
            }else
            {
                MessageBox.Show("User not found");
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            CryptoUtility crypt = new CryptoUtility();
            File.WriteAllText("admin.txt", crypt.Pbkdf2Function("admin",null));
            //File.ReadAllBytes("admin.txt");
        }
    }
}

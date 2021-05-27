using System;
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
                
                CryptoUtility crypt = new();
                using (StreamReader file = new StreamReader(userTxtBox.Text + ".txt"))
                {
                    string tmp = file.ReadToEnd();
                    file.Close();
                    tmp = crypt.DecodeStr(tmp, pwTxtBox.Text);
                    tmp = tmp.Replace("\0", string.Empty);
                    //MessageBox.Show(tmp);
                    string fLine = null;
                    using (var reader = new StringReader(tmp))
                    {
                        fLine = reader.ReadLine();
                        //MessageBox.Show(fLine);
                    }
                    if (crypt.PwAuthorize(pwTxtBox.Text, fLine))
                    {
                        authorizeState = true;
                        //Close();
                        this.Hide();
                        Form1 mainWindow = new Form1(userTxtBox.Text,pwTxtBox.Text, tmp);
                        mainWindow.ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                    
            }else
            {
                MessageBox.Show("User not found");
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            if(userTxtBox.Text.Length < 3)
            {
                MessageBox.Show("Username too short");
                return;
            }
            if(pwTxtBox.Text.Length < 4)
            {
                MessageBox.Show("Password too short");
                return;
            }
            if (File.Exists(userTxtBox.Text + ".txt"))
            {
                MessageBox.Show("User already exists");
                return;
            }
            CryptoUtility crypt = new();
            File.WriteAllText(userTxtBox.Text + ".txt", crypt.Pbkdf2Function(pwTxtBox.Text, null));
            authorizeState = true;
            this.Hide();
            Form1 mainWindow = new Form1(userTxtBox.Text, pwTxtBox.Text, null);
            mainWindow.ShowDialog();
            Close();
        }
    }
}

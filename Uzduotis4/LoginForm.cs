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
                    MessageBox.Show(tmp);
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
                        Form1 mainWindow = new Form1(userTxtBox.Text,pwTxtBox.Text);
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
            //CryptoUtility crypt = new CryptoUtility();
            //File.WriteAllText("admin.txt", crypt.Pbkdf2Function("admin",null));
            //File.ReadAllBytes("admin.txt");
        }
    }
}

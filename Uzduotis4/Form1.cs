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
    public partial class Form1 : Form
    {
        private string user;
        private string pw;
        public Form1(string user, string pw)
        {
            InitializeComponent();
            this.user = user;
            this.pw = pw;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Program.
            MemoryStream test = new MemoryStream();
            StreamWriter sWriter = new StreamWriter(test, UnicodeEncoding.Unicode);
            CryptoUtility crypt = new CryptoUtility();
            //File.WriteAllText("admin.txt", crypt.Pbkdf2Function("admin",null));
            sWriter.WriteLine(crypt.Pbkdf2Function(pw, null));
            foreach(DataGridViewRow row in listBoxMain.Rows)
            {
                sWriter.WriteLine(row.Cells["name_col"].Value + "\\" + 
                                    row.Cells["pw_col"].Value + "\\" +
                                    row.Cells["url_col"].Value + "\\" +
                                    row.Cells["com_col"].Value);
            }
            sWriter.Flush();
            test.Position = 0L;

            using (StreamReader sReader = new StreamReader(test,UnicodeEncoding.Unicode))
            {
                string tmp = crypt.EncodeStr(sReader.ReadToEnd(), pw);
                MessageBox.Show(tmp);
                MessageBox.Show(crypt.DecodeStr(tmp, pw));
            }
            sWriter.Dispose();
        }


        private void CreateBtn_Click(object sender, EventArgs e)
        {
            // TODO Empty string check
            int tmpRow = listBoxMain.Rows.Add();
            listBoxMain.Rows[tmpRow].Cells["name_col"].Value = nameTxtBox.Text;
            listBoxMain.Rows[tmpRow].Cells["pw_col"].Value = PwTxtBox.Text;
            listBoxMain.Rows[tmpRow].Cells["url_col"].Value = UrlTxtBox.Text;
            listBoxMain.Rows[tmpRow].Cells["com_col"].Value = ComTxtBox.Text;
        }

        private void ClipboardBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listBoxMain.SelectedCells[0].Value.ToString());
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listBoxMain.SelectedRows)
            {
                listBoxMain.Rows.Remove(row);
            }

        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            var random = new Random();
            string tmpBuffer = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$&1234567890";
            string tmpPw = "";
            for(var i = 0; i < 12; ++i)
            {
                tmpPw += tmpBuffer[random.Next(0, tmpBuffer.Length)];
            }
            PwTxtBox.Text = tmpPw;
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in listBoxMain.Rows)
            {
                if (searchTxtBox.Text.Length > 2 && row.Cells["name_n"].Value.ToString().Contains(searchTxtBox.Text))
                {
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}

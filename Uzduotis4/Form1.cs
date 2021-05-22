using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzduotis4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
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

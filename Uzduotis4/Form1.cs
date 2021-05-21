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
            string tmp = nameTxtBox.Text;
            int tmpRow = listBoxMain.Rows.Add();
            listBoxMain.Rows[tmpRow].Cells["name_n"].Value = tmp;
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
    }
}

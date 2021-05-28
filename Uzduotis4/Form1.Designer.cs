
namespace Uzduotis4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.GenBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComTxtBox = new System.Windows.Forms.TextBox();
            this.UrlTxtBox = new System.Windows.Forms.TextBox();
            this.PwTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.listBoxMain = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClipboardBtn = new System.Windows.Forms.Button();
            this.RetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(17, 273);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(132, 23);
            this.ShowBtn.TabIndex = 1;
            this.ShowBtn.Text = "Show selected";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(60, 13);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(118, 23);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.searchTxtBox_TextChanged);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(155, 273);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(132, 23);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Delete selected";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RetBtn);
            this.groupBox1.Controls.Add(this.CreateBtn);
            this.groupBox1.Controls.Add(this.GenBtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComTxtBox);
            this.groupBox1.Controls.Add(this.UrlTxtBox);
            this.groupBox1.Controls.Add(this.PwTxtBox);
            this.groupBox1.Controls.Add(this.nameTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(482, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New password";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(31, 150);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(100, 23);
            this.CreateBtn.TabIndex = 9;
            this.CreateBtn.Text = "Append to list";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // GenBtn
            // 
            this.GenBtn.Location = new System.Drawing.Point(286, 51);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(75, 23);
            this.GenBtn.TabIndex = 8;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Comment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "URL/App";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // ComTxtBox
            // 
            this.ComTxtBox.Location = new System.Drawing.Point(94, 107);
            this.ComTxtBox.Name = "ComTxtBox";
            this.ComTxtBox.Size = new System.Drawing.Size(176, 23);
            this.ComTxtBox.TabIndex = 3;
            // 
            // UrlTxtBox
            // 
            this.UrlTxtBox.Location = new System.Drawing.Point(94, 80);
            this.UrlTxtBox.Name = "UrlTxtBox";
            this.UrlTxtBox.Size = new System.Drawing.Size(176, 23);
            this.UrlTxtBox.TabIndex = 2;
            // 
            // PwTxtBox
            // 
            this.PwTxtBox.Location = new System.Drawing.Point(94, 51);
            this.PwTxtBox.Name = "PwTxtBox";
            this.PwTxtBox.Size = new System.Drawing.Size(176, 23);
            this.PwTxtBox.TabIndex = 1;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(94, 22);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(176, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // listBoxMain
            // 
            this.listBoxMain.AllowUserToAddRows = false;
            this.listBoxMain.AllowUserToDeleteRows = false;
            this.listBoxMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listBoxMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBoxMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_col,
            this.pw_col,
            this.url_col,
            this.com_col});
            this.listBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listBoxMain.Location = new System.Drawing.Point(0, 0);
            this.listBoxMain.MultiSelect = false;
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.RowTemplate.Height = 25;
            this.listBoxMain.Size = new System.Drawing.Size(450, 219);
            this.listBoxMain.TabIndex = 6;
            this.listBoxMain.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // name_col
            // 
            this.name_col.HeaderText = "Name";
            this.name_col.Name = "name_col";
            // 
            // pw_col
            // 
            this.pw_col.HeaderText = "Password";
            this.pw_col.Name = "pw_col";
            // 
            // url_col
            // 
            this.url_col.HeaderText = "URL/APP";
            this.url_col.Name = "url_col";
            // 
            // com_col
            // 
            this.com_col.HeaderText = "Comment";
            this.com_col.Name = "com_col";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBoxMain);
            this.panel1.Location = new System.Drawing.Point(15, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 219);
            this.panel1.TabIndex = 7;
            // 
            // ClipboardBtn
            // 
            this.ClipboardBtn.Location = new System.Drawing.Point(333, 273);
            this.ClipboardBtn.Name = "ClipboardBtn";
            this.ClipboardBtn.Size = new System.Drawing.Size(132, 23);
            this.ClipboardBtn.TabIndex = 8;
            this.ClipboardBtn.Text = "Copy to clipboard";
            this.ClipboardBtn.UseVisualStyleBackColor = true;
            this.ClipboardBtn.Click += new System.EventHandler(this.ClipboardBtn_Click);
            // 
            // RetBtn
            // 
            this.RetBtn.Location = new System.Drawing.Point(31, 179);
            this.RetBtn.Name = "RetBtn";
            this.RetBtn.Size = new System.Drawing.Size(100, 23);
            this.RetBtn.TabIndex = 10;
            this.RetBtn.Text = "Retrieve pw";
            this.RetBtn.UseVisualStyleBackColor = true;
            this.RetBtn.Click += new System.EventHandler(this.RetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 319);
            this.Controls.Add(this.ClipboardBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Password App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComTxtBox;
        private System.Windows.Forms.TextBox UrlTxtBox;
        private System.Windows.Forms.TextBox PwTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Button GenBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.DataGridView listBoxMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClipboardBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn url_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_col;
        private System.Windows.Forms.Button RetBtn;
    }
}


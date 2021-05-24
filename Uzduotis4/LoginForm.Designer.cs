
namespace Uzduotis4
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.pwTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(126, 55);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(169, 23);
            this.userTxtBox.TabIndex = 0;
            // 
            // pwTxtBox
            // 
            this.pwTxtBox.Location = new System.Drawing.Point(126, 84);
            this.pwTxtBox.Name = "pwTxtBox";
            this.pwTxtBox.Size = new System.Drawing.Size(169, 23);
            this.pwTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(126, 129);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(207, 129);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 5;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 203);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwTxtBox);
            this.Controls.Add(this.userTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(LoginForm_FormClosing);

        }

        #endregion

        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox pwTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button regBtn;
    }
}
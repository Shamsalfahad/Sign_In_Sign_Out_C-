namespace WindowsFormsApp4
{
    partial class FromsignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(52, 133);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(113, 77);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(100, 20);
            this.TbUsername.TabIndex = 2;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(113, 133);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 3;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(127, 177);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUp.TabIndex = 4;
            this.BtnSignUp.Text = "Signup";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already Have An Account? Click Here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FromsignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "FromsignUp";
            this.Text = "FromsignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
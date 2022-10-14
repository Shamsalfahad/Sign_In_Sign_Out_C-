namespace WindowsFormsApp4
{
    partial class FrmLogin
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(293, 223);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(279, 171);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 8;
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(279, 115);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(100, 20);
            this.TbUsername.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(218, 171);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
    }
}
namespace GUI_Duty_Manager
{
    partial class Form1
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.title_Login = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Password.ForeColor = System.Drawing.Color.LightGray;
            this.textBox_Password.Location = new System.Drawing.Point(572, 397);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(133, 30);
            this.textBox_Password.TabIndex = 0;
            this.textBox_Password.Text = "Password";
            // 
            // textBox_User
            // 
            this.textBox_User.Font = new System.Drawing.Font("Aharoni", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_User.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox_User.Location = new System.Drawing.Point(382, 397);
            this.textBox_User.MaximumSize = new System.Drawing.Size(600, 600);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(150, 30);
            this.textBox_User.TabIndex = 1;
            this.textBox_User.Text = "User";
            this.textBox_User.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Aharoni", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(423, 254);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(264, 79);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Log In";
            // 
            // title_Login
            // 
            this.title_Login.AutoSize = true;
            this.title_Login.Font = new System.Drawing.Font("Aharoni", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Login.Location = new System.Drawing.Point(299, 41);
            this.title_Login.Name = "title_Login";
            this.title_Login.Size = new System.Drawing.Size(582, 79);
            this.title_Login.TabIndex = 2;
            this.title_Login.Text = "Duty Manager";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(401, 448);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(572, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 651);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.title_Login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.textBox_Password);
            this.Name = "Form1";
            this.Text = "כניסה";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label title_Login;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


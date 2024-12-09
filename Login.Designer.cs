namespace test2
{
    partial class Login
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.labuser = new System.Windows.Forms.Label();
            this.labpass = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(206, 58);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(172, 20);
            this.txtuser.TabIndex = 0;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(206, 117);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(172, 20);
            this.txtpass.TabIndex = 1;
            // 
            // labuser
            // 
            this.labuser.AutoSize = true;
            this.labuser.Location = new System.Drawing.Point(111, 58);
            this.labuser.Name = "labuser";
            this.labuser.Size = new System.Drawing.Size(55, 13);
            this.labuser.TabIndex = 2;
            this.labuser.Text = "Username";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Location = new System.Drawing.Point(113, 120);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(53, 13);
            this.labpass.TabIndex = 3;
            this.labpass.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(104, 164);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(206, 164);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 5;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(303, 164);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 225);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label labuser;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnexit;
    }
}
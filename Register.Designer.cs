namespace test2
{
    partial class Register
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
            this.labuser = new System.Windows.Forms.Label();
            this.labpass = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labuser
            // 
            this.labuser.AutoSize = true;
            this.labuser.Location = new System.Drawing.Point(115, 58);
            this.labuser.Name = "labuser";
            this.labuser.Size = new System.Drawing.Size(55, 13);
            this.labuser.TabIndex = 0;
            this.labuser.Text = "Username";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Location = new System.Drawing.Point(115, 119);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(53, 13);
            this.labpass.TabIndex = 1;
            this.labpass.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(193, 58);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(199, 20);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(193, 112);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(199, 20);
            this.txtpass.TabIndex = 3;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(118, 164);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 4;
            this.btnreg.Text = "Register";
            this.btnreg.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(217, 164);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(317, 164);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 228);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labuser);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labuser;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
    }
}
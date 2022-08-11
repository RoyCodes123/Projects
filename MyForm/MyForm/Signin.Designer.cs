namespace MyForm
{
    partial class Signin
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
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.Location = new System.Drawing.Point(488, 268);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(104, 40);
            this.btnSignin.TabIndex = 23;
            this.btnSignin.Text = "Login";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(354, 225);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(238, 20);
            this.txtPasswordLogin.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password:";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(354, 192);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(238, 20);
            this.txtEmailLogin.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(348, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Login Form";
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCreateAccount.Location = new System.Drawing.Point(252, 342);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(340, 22);
            this.lblCreateAccount.TabIndex = 24;
            this.lblCreateAccount.Text = "Don\'t have an account? Create one!";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(350, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "View Table Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "Signin";
            this.Text = "Sign-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Label label1;
    }
}
namespace MyForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.ComboBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(283, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sign-Up Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(289, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(289, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Email:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(289, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.FormattingEnabled = true;
            this.txtCountry.Items.AddRange(new object[] {
            "USA",
            "Canada",
            "France",
            "Germany",
            "Italy",
            "Israel"});
            this.txtCountry.Location = new System.Drawing.Point(289, 208);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(238, 28);
            this.txtCountry.TabIndex = 16;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(422, 273);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(104, 40);
            this.btnSignUp.TabIndex = 17;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtCountry;
        private System.Windows.Forms.Button btnSignUp;
    }
}


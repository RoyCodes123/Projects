namespace MyForm
{
    partial class HomePage
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
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.txtCountryHome = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameHome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(160, 306);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(237, 40);
            this.btnUpdateInfo.TabIndex = 26;
            this.btnUpdateInfo.Text = "Update My Account Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // txtCountryHome
            // 
            this.txtCountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryHome.FormattingEnabled = true;
            this.txtCountryHome.Items.AddRange(new object[] {
            "USA",
            "Canada",
            "France",
            "Germany",
            "Italy",
            "Israel"});
            this.txtCountryHome.Location = new System.Drawing.Point(160, 241);
            this.txtCountryHome.Name = "txtCountryHome";
            this.txtCountryHome.Size = new System.Drawing.Size(238, 28);
            this.txtCountryHome.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Country:";
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Location = new System.Drawing.Point(160, 202);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(238, 20);
            this.txtPasswordHome.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            // 
            // txtEmailHome
            // 
            this.txtEmailHome.Location = new System.Drawing.Point(160, 169);
            this.txtEmailHome.Name = "txtEmailHome";
            this.txtEmailHome.Size = new System.Drawing.Size(238, 20);
            this.txtEmailHome.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Email:";
            // 
            // txtNameHome
            // 
            this.txtNameHome.Location = new System.Drawing.Point(160, 133);
            this.txtNameHome.Name = "txtNameHome";
            this.txtNameHome.Size = new System.Drawing.Size(238, 20);
            this.txtNameHome.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(156, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Change Account Settings";
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblWelcomeName.Location = new System.Drawing.Point(261, 21);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(230, 21);
            this.lblWelcomeName.TabIndex = 28;
            this.lblWelcomeName.Text = "Change Account Settings";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(524, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 180);
            this.button1.TabIndex = 29;
            this.button1.Text = "Delete My Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.txtCountryHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmailHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameHome);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.ComboBox txtCountryHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Button button1;
    }
}
namespace MyForm
{
    partial class CommandBuilderForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.performOperBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // performOperBtn
            // 
            this.performOperBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performOperBtn.Location = new System.Drawing.Point(12, 370);
            this.performOperBtn.Name = "performOperBtn";
            this.performOperBtn.Size = new System.Drawing.Size(634, 50);
            this.performOperBtn.TabIndex = 1;
            this.performOperBtn.Text = "Perform Operation";
            this.performOperBtn.UseVisualStyleBackColor = true;
            this.performOperBtn.Click += new System.EventHandler(this.performOperBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Back to Login Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CommandBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.performOperBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CommandBuilderForm";
            this.Text = "CommandBuilderForm";
            this.Load += new System.EventHandler(this.CommandBuilderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button performOperBtn;
        private System.Windows.Forms.Label label1;
    }
}
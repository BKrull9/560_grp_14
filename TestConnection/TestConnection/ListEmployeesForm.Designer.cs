namespace TestConnection
{
    partial class ListEmployeesForm
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
            this.uxEmployeeSearchButton = new System.Windows.Forms.Button();
            this.uxBackButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEmployeeSearchButton
            // 
            this.uxEmployeeSearchButton.Location = new System.Drawing.Point(22, 67);
            this.uxEmployeeSearchButton.Name = "uxEmployeeSearchButton";
            this.uxEmployeeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.uxEmployeeSearchButton.TabIndex = 0;
            this.uxEmployeeSearchButton.Text = "Search";
            this.uxEmployeeSearchButton.UseVisualStyleBackColor = true;
            this.uxEmployeeSearchButton.Click += new System.EventHandler(this.uxEmployeeSearchButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(22, 361);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(75, 23);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID: ";
            // 
            // ListEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEmployeeSearchButton);
            this.Name = "ListEmployeesForm";
            this.Text = "ListEmployeesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEmployeeSearchButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
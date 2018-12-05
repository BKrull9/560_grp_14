namespace TestConnection
{
    partial class Home
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
            this.uxGetCustomer = new System.Windows.Forms.Button();
            this.uxListEmployees = new System.Windows.Forms.Button();
            this.uxCarSearch = new System.Windows.Forms.Button();
            this.uxEmployeePerf = new System.Windows.Forms.Button();
            this.uxDealershipPerf = new System.Windows.Forms.Button();
            this.uxCarWithFeat = new System.Windows.Forms.Button();
            this.uxGetTopEmployees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGetCustomer
            // 
            this.uxGetCustomer.Location = new System.Drawing.Point(9, 31);
            this.uxGetCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxGetCustomer.Name = "uxGetCustomer";
            this.uxGetCustomer.Size = new System.Drawing.Size(276, 26);
            this.uxGetCustomer.TabIndex = 0;
            this.uxGetCustomer.Text = "Get Customer Information ";
            this.uxGetCustomer.UseVisualStyleBackColor = true;
            this.uxGetCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxListEmployees
            // 
            this.uxListEmployees.Location = new System.Drawing.Point(9, 70);
            this.uxListEmployees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxListEmployees.Name = "uxListEmployees";
            this.uxListEmployees.Size = new System.Drawing.Size(276, 26);
            this.uxListEmployees.TabIndex = 2;
            this.uxListEmployees.Text = "Get Employee Information ";
            this.uxListEmployees.UseVisualStyleBackColor = true;
            this.uxListEmployees.Click += new System.EventHandler(this.uxListEmployees_Click);
            // 
            // uxCarSearch
            // 
            this.uxCarSearch.Location = new System.Drawing.Point(9, 109);
            this.uxCarSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxCarSearch.Name = "uxCarSearch";
            this.uxCarSearch.Size = new System.Drawing.Size(276, 26);
            this.uxCarSearch.TabIndex = 3;
            this.uxCarSearch.Text = "Search by Details";
            this.uxCarSearch.UseVisualStyleBackColor = true;
            this.uxCarSearch.Click += new System.EventHandler(this.uxCarSearch_Click);
            // 
            // uxEmployeePerf
            // 
            this.uxEmployeePerf.Location = new System.Drawing.Point(9, 174);
            this.uxEmployeePerf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxEmployeePerf.Name = "uxEmployeePerf";
            this.uxEmployeePerf.Size = new System.Drawing.Size(276, 26);
            this.uxEmployeePerf.TabIndex = 4;
            this.uxEmployeePerf.Text = "Employee Performance";
            this.uxEmployeePerf.UseVisualStyleBackColor = true;
            this.uxEmployeePerf.Click += new System.EventHandler(this.uxEmployeePerf_Click);
            // 
            // uxDealershipPerf
            // 
            this.uxDealershipPerf.Location = new System.Drawing.Point(9, 200);
            this.uxDealershipPerf.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxDealershipPerf.Name = "uxDealershipPerf";
            this.uxDealershipPerf.Size = new System.Drawing.Size(276, 26);
            this.uxDealershipPerf.TabIndex = 5;
            this.uxDealershipPerf.Text = "Dealership Performance";
            this.uxDealershipPerf.UseVisualStyleBackColor = true;
            this.uxDealershipPerf.Click += new System.EventHandler(this.uxDealershipPerf_Click);
            // 
            // uxCarWithFeat
            // 
            this.uxCarWithFeat.Location = new System.Drawing.Point(9, 135);
            this.uxCarWithFeat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxCarWithFeat.Name = "uxCarWithFeat";
            this.uxCarWithFeat.Size = new System.Drawing.Size(276, 26);
            this.uxCarWithFeat.TabIndex = 7;
            this.uxCarWithFeat.Text = "Search by Feature";
            this.uxCarWithFeat.UseVisualStyleBackColor = true;
            this.uxCarWithFeat.Click += new System.EventHandler(this.uxCarWithFeat_Click);
            // 
            // uxGetTopEmployees
            // 
            this.uxGetTopEmployees.Location = new System.Drawing.Point(9, 226);
            this.uxGetTopEmployees.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.uxGetTopEmployees.Name = "uxGetTopEmployees";
            this.uxGetTopEmployees.Size = new System.Drawing.Size(276, 26);
            this.uxGetTopEmployees.TabIndex = 9;
            this.uxGetTopEmployees.Text = "Get Top Employees";
            this.uxGetTopEmployees.UseVisualStyleBackColor = true;
            this.uxGetTopEmployees.Click += new System.EventHandler(this.uxGetTopEmployees_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cutomer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Performance";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Get Top Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGetTopEmployees);
            this.Controls.Add(this.uxCarWithFeat);
            this.Controls.Add(this.uxDealershipPerf);
            this.Controls.Add(this.uxEmployeePerf);
            this.Controls.Add(this.uxCarSearch);
            this.Controls.Add(this.uxListEmployees);
            this.Controls.Add(this.uxGetCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name = "Home";
            this.Text = "Company Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxGetCustomer;
        private System.Windows.Forms.Button uxListEmployees;
        private System.Windows.Forms.Button uxCarSearch;
        private System.Windows.Forms.Button uxEmployeePerf;
        private System.Windows.Forms.Button uxDealershipPerf;
        private System.Windows.Forms.Button uxCarWithFeat;
        private System.Windows.Forms.Button uxGetTopEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
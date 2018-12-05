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
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.employeeId = new System.Windows.Forms.Label();
            this.DealershipName = new System.Windows.Forms.Label();
            this.StreetAddress = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.NumberOfSalesLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
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
            this.uxBackButton.Location = new System.Drawing.Point(22, 373);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(75, 23);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(93, 19);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 236);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name: ";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(291, 19);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // employeeId
            // 
            this.employeeId.AutoSize = true;
            this.employeeId.Location = new System.Drawing.Point(443, 26);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(73, 13);
            this.employeeId.TabIndex = 7;
            this.employeeId.Text = "Employee ID: ";
            // 
            // DealershipName
            // 
            this.DealershipName.AutoSize = true;
            this.DealershipName.Location = new System.Drawing.Point(443, 150);
            this.DealershipName.Name = "DealershipName";
            this.DealershipName.Size = new System.Drawing.Size(91, 13);
            this.DealershipName.TabIndex = 8;
            this.DealershipName.Text = "Dealership Name:";
            // 
            // StreetAddress
            // 
            this.StreetAddress.AutoSize = true;
            this.StreetAddress.Location = new System.Drawing.Point(443, 190);
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.Size = new System.Drawing.Size(38, 13);
            this.StreetAddress.TabIndex = 9;
            this.StreetAddress.Text = "Street:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(443, 234);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "City:";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Location = new System.Drawing.Point(443, 279);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.ZipCodeLabel.TabIndex = 11;
            this.ZipCodeLabel.Text = "Zip Code:";
            // 
            // NumberOfSalesLabel
            // 
            this.NumberOfSalesLabel.AutoSize = true;
            this.NumberOfSalesLabel.Location = new System.Drawing.Point(443, 324);
            this.NumberOfSalesLabel.Name = "NumberOfSalesLabel";
            this.NumberOfSalesLabel.Size = new System.Drawing.Size(88, 13);
            this.NumberOfSalesLabel.TabIndex = 12;
            this.NumberOfSalesLabel.Text = "Number of Sales:";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(443, 363);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(63, 13);
            this.TotalSalesLabel.TabIndex = 13;
            this.TotalSalesLabel.Text = "Total Sales:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(443, 67);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneLabel.TabIndex = 14;
            this.PhoneLabel.Text = "Phone Number:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(443, 110);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email:";
            // 
            // ListEmployeesForm
            // 
            this.AcceptButton = this.uxEmployeeSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 427);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.NumberOfSalesLabel);
            this.Controls.Add(this.ZipCodeLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetAddress);
            this.Controls.Add(this.DealershipName);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.uxBackButton);
            this.Controls.Add(this.uxEmployeeSearchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ListEmployeesForm";
            this.Text = "ListEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEmployeeSearchButton;
        private System.Windows.Forms.Button uxBackButton;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label employeeId;
        private System.Windows.Forms.Label DealershipName;
        private System.Windows.Forms.Label StreetAddress;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.Label NumberOfSalesLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
    }
}
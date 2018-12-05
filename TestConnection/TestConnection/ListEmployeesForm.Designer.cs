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
            this.uxTxtEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.StreetAddress2 = new System.Windows.Forms.Label();
            this.employeeIdRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firsrtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealership = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEmployeeSearchButton
            // 
            this.uxEmployeeSearchButton.Location = new System.Drawing.Point(15, 32);
            this.uxEmployeeSearchButton.Name = "uxEmployeeSearchButton";
            this.uxEmployeeSearchButton.Size = new System.Drawing.Size(75, 23);
            this.uxEmployeeSearchButton.TabIndex = 0;
            this.uxEmployeeSearchButton.Text = "Search";
            this.uxEmployeeSearchButton.UseVisualStyleBackColor = true;
            this.uxEmployeeSearchButton.Click += new System.EventHandler(this.uxEmployeeSearchButton_Click);
            // 
            // uxBackButton
            // 
            this.uxBackButton.Location = new System.Drawing.Point(15, 224);
            this.uxBackButton.Name = "uxBackButton";
            this.uxBackButton.Size = new System.Drawing.Size(75, 23);
            this.uxBackButton.TabIndex = 1;
            this.uxBackButton.Text = "Back";
            this.uxBackButton.UseVisualStyleBackColor = true;
            this.uxBackButton.Click += new System.EventHandler(this.uxBackButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(264, 6);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdRow,
            this.firsrtName,
            this.lastName,
            this.phoneNumber,
            this.email,
            this.dealership,
            this.street,
            this.street2,
            this.city,
            this.zipcode,
            this.numSales,
            this.totalSales});
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(236, 147);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name: ";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(440, 6);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 6;
            // 
            // employeeId
            // 
            this.employeeId.AutoSize = true;
            this.employeeId.Location = new System.Drawing.Point(357, 39);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(13, 13);
            this.employeeId.TabIndex = 7;
            this.employeeId.Text = "--";
            // 
            // DealershipName
            // 
            this.DealershipName.AutoSize = true;
            this.DealershipName.Location = new System.Drawing.Point(357, 103);
            this.DealershipName.Name = "DealershipName";
            this.DealershipName.Size = new System.Drawing.Size(13, 13);
            this.DealershipName.TabIndex = 8;
            this.DealershipName.Text = "--";
            // 
            // StreetAddress
            // 
            this.StreetAddress.AutoSize = true;
            this.StreetAddress.Location = new System.Drawing.Point(357, 126);
            this.StreetAddress.Name = "StreetAddress";
            this.StreetAddress.Size = new System.Drawing.Size(13, 13);
            this.StreetAddress.TabIndex = 9;
            this.StreetAddress.Text = "--";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(357, 166);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(13, 13);
            this.CityLabel.TabIndex = 10;
            this.CityLabel.Text = "--";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Location = new System.Drawing.Point(357, 187);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(13, 13);
            this.ZipCodeLabel.TabIndex = 11;
            this.ZipCodeLabel.Text = "--";
            // 
            // NumberOfSalesLabel
            // 
            this.NumberOfSalesLabel.AutoSize = true;
            this.NumberOfSalesLabel.Location = new System.Drawing.Point(357, 209);
            this.NumberOfSalesLabel.Name = "NumberOfSalesLabel";
            this.NumberOfSalesLabel.Size = new System.Drawing.Size(13, 13);
            this.NumberOfSalesLabel.TabIndex = 12;
            this.NumberOfSalesLabel.Text = "--";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Location = new System.Drawing.Point(357, 232);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalSalesLabel.TabIndex = 13;
            this.TotalSalesLabel.Text = "--";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(357, 59);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(13, 13);
            this.PhoneLabel.TabIndex = 14;
            this.PhoneLabel.Text = "--";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(357, 80);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(13, 13);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "--";
            // 
            // uxTxtEmployeeId
            // 
            this.uxTxtEmployeeId.Location = new System.Drawing.Point(89, 6);
            this.uxTxtEmployeeId.Name = "uxTxtEmployeeId";
            this.uxTxtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.uxTxtEmployeeId.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Employee ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Total Sales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Number of Sales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Zip Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Street:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dealership Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(261, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Employee ID: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Street2:";
            // 
            // StreetAddress2
            // 
            this.StreetAddress2.AutoSize = true;
            this.StreetAddress2.Location = new System.Drawing.Point(357, 145);
            this.StreetAddress2.Name = "StreetAddress2";
            this.StreetAddress2.Size = new System.Drawing.Size(13, 13);
            this.StreetAddress2.TabIndex = 27;
            this.StreetAddress2.Text = "--";
            // 
            // employeeIdRow
            // 
            this.employeeIdRow.HeaderText = "Employee ID";
            this.employeeIdRow.Name = "employeeIdRow";
            this.employeeIdRow.ReadOnly = true;
            this.employeeIdRow.Visible = false;
            // 
            // firsrtName
            // 
            this.firsrtName.HeaderText = "First Name";
            this.firsrtName.Name = "firsrtName";
            this.firsrtName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Visible = false;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // dealership
            // 
            this.dealership.HeaderText = "Dealership Name";
            this.dealership.Name = "dealership";
            this.dealership.ReadOnly = true;
            this.dealership.Visible = false;
            // 
            // street
            // 
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Visible = false;
            // 
            // street2
            // 
            this.street2.HeaderText = "Street2";
            this.street2.Name = "street2";
            this.street2.ReadOnly = true;
            this.street2.Visible = false;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Visible = false;
            // 
            // zipcode
            // 
            this.zipcode.HeaderText = "Zipcode";
            this.zipcode.Name = "zipcode";
            this.zipcode.ReadOnly = true;
            this.zipcode.Visible = false;
            // 
            // numSales
            // 
            this.numSales.HeaderText = "Number Sales";
            this.numSales.Name = "numSales";
            this.numSales.ReadOnly = true;
            this.numSales.Visible = false;
            // 
            // totalSales
            // 
            this.totalSales.HeaderText = "Total Sales";
            this.totalSales.Name = "totalSales";
            this.totalSales.ReadOnly = true;
            this.totalSales.Visible = false;
            // 
            // ListEmployeesForm
            // 
            this.AcceptButton = this.uxEmployeeSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 250);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.StreetAddress2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uxTxtEmployeeId);
            this.Controls.Add(this.label3);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListEmployeesForm_FormClosing);
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
        private System.Windows.Forms.TextBox uxTxtEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label StreetAddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn firsrtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealership;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSales;
    }
}
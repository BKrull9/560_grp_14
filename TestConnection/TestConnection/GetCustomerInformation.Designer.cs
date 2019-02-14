namespace TestConnection
{
    partial class GetCustomerInformation
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
            this.label2 = new System.Windows.Forms.Label();
            this.uxTxtCustomerId = new System.Windows.Forms.TextBox();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxTxtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxTxtFistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uxCustomerId = new System.Windows.Forms.Label();
            this.uxStreet = new System.Windows.Forms.Label();
            this.uxStreet2 = new System.Windows.Forms.Label();
            this.uxCity = new System.Windows.Forms.Label();
            this.uxZipcode = new System.Windows.Forms.Label();
            this.uxNumPurchase = new System.Windows.Forms.Label();
            this.uxPurchaseAmount = new System.Windows.Forms.Label();
            this.uxPhoneNumber = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uxEmail = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID: ";
            // 
            // uxTxtCustomerId
            // 
            this.uxTxtCustomerId.Location = new System.Drawing.Point(86, 9);
            this.uxTxtCustomerId.Name = "uxTxtCustomerId";
            this.uxTxtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.uxTxtCustomerId.TabIndex = 2;
            // 
            // uxBack
            // 
            this.uxBack.Location = new System.Drawing.Point(12, 214);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(75, 23);
            this.uxBack.TabIndex = 4;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(12, 32);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(75, 23);
            this.uxSearch.TabIndex = 5;
            this.uxSearch.Text = "Search";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.AllowUserToAddRows = false;
            this.uxDataGrid.AllowUserToDeleteRows = false;
            this.uxDataGrid.AllowUserToResizeRows = false;
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.firstName,
            this.lastName,
            this.phoneNumber,
            this.email,
            this.street,
            this.street2,
            this.city,
            this.zipcode});
            this.uxDataGrid.Location = new System.Drawing.Point(12, 58);
            this.uxDataGrid.MultiSelect = false;
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.ReadOnly = true;
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGrid.Size = new System.Drawing.Size(237, 150);
            this.uxDataGrid.TabIndex = 6;
            this.uxDataGrid.SelectionChanged += new System.EventHandler(this.uxDataGird_SelectionChanged);
            // 
            // customerId
            // 
            this.customerId.HeaderText = "Customer ID";
            this.customerId.Name = "customerId";
            this.customerId.Visible = false;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
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
            // street
            // 
            this.street.HeaderText = "Street";
            this.street.Name = "street";
            this.street.Visible = false;
            // 
            // street2
            // 
            this.street2.HeaderText = "street2";
            this.street2.Name = "street2";
            this.street2.Visible = false;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            this.city.Visible = false;
            // 
            // zipcode
            // 
            this.zipcode.HeaderText = "Zipcode";
            this.zipcode.Name = "zipcode";
            this.zipcode.Visible = false;
            // 
            // uxTxtLastName
            // 
            this.uxTxtLastName.Location = new System.Drawing.Point(428, 9);
            this.uxTxtLastName.Name = "uxTxtLastName";
            this.uxTxtLastName.Size = new System.Drawing.Size(100, 20);
            this.uxTxtLastName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Last Name:";
            // 
            // uxTxtFistName
            // 
            this.uxTxtFistName.Location = new System.Drawing.Point(255, 9);
            this.uxTxtFistName.Name = "uxTxtFistName";
            this.uxTxtFistName.Size = new System.Drawing.Size(100, 20);
            this.uxTxtFistName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FirstName:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Street:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Street2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zipcode:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "# Purchases:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Purchase Amount:";
            // 
            // uxCustomerId
            // 
            this.uxCustomerId.AutoSize = true;
            this.uxCustomerId.Location = new System.Drawing.Point(361, 58);
            this.uxCustomerId.Name = "uxCustomerId";
            this.uxCustomerId.Size = new System.Drawing.Size(13, 13);
            this.uxCustomerId.TabIndex = 19;
            this.uxCustomerId.Text = "--";
            // 
            // uxStreet
            // 
            this.uxStreet.AutoSize = true;
            this.uxStreet.Location = new System.Drawing.Point(361, 124);
            this.uxStreet.Name = "uxStreet";
            this.uxStreet.Size = new System.Drawing.Size(13, 13);
            this.uxStreet.TabIndex = 20;
            this.uxStreet.Text = "--";
            // 
            // uxStreet2
            // 
            this.uxStreet2.AutoSize = true;
            this.uxStreet2.Location = new System.Drawing.Point(361, 146);
            this.uxStreet2.Name = "uxStreet2";
            this.uxStreet2.Size = new System.Drawing.Size(13, 13);
            this.uxStreet2.TabIndex = 21;
            this.uxStreet2.Text = "--";
            // 
            // uxCity
            // 
            this.uxCity.AutoSize = true;
            this.uxCity.Location = new System.Drawing.Point(361, 169);
            this.uxCity.Name = "uxCity";
            this.uxCity.Size = new System.Drawing.Size(13, 13);
            this.uxCity.TabIndex = 22;
            this.uxCity.Text = "--";
            // 
            // uxZipcode
            // 
            this.uxZipcode.AutoSize = true;
            this.uxZipcode.Location = new System.Drawing.Point(361, 191);
            this.uxZipcode.Name = "uxZipcode";
            this.uxZipcode.Size = new System.Drawing.Size(13, 13);
            this.uxZipcode.TabIndex = 23;
            this.uxZipcode.Text = "--";
            // 
            // uxNumPurchase
            // 
            this.uxNumPurchase.AutoSize = true;
            this.uxNumPurchase.Location = new System.Drawing.Point(361, 213);
            this.uxNumPurchase.Name = "uxNumPurchase";
            this.uxNumPurchase.Size = new System.Drawing.Size(13, 13);
            this.uxNumPurchase.TabIndex = 24;
            this.uxNumPurchase.Text = "--";
            // 
            // uxPurchaseAmount
            // 
            this.uxPurchaseAmount.AutoSize = true;
            this.uxPurchaseAmount.Location = new System.Drawing.Point(361, 232);
            this.uxPurchaseAmount.Name = "uxPurchaseAmount";
            this.uxPurchaseAmount.Size = new System.Drawing.Size(13, 13);
            this.uxPurchaseAmount.TabIndex = 25;
            this.uxPurchaseAmount.Text = "--";
            // 
            // uxPhoneNumber
            // 
            this.uxPhoneNumber.AutoSize = true;
            this.uxPhoneNumber.Location = new System.Drawing.Point(361, 80);
            this.uxPhoneNumber.Name = "uxPhoneNumber";
            this.uxPhoneNumber.Size = new System.Drawing.Size(13, 13);
            this.uxPhoneNumber.TabIndex = 27;
            this.uxPhoneNumber.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Phone Number:";
            // 
            // uxEmail
            // 
            this.uxEmail.AutoSize = true;
            this.uxEmail.Location = new System.Drawing.Point(361, 102);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(13, 13);
            this.uxEmail.TabIndex = 29;
            this.uxEmail.Text = "--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(255, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email:";
            // 
            // GetCustomerInformation
            // 
            this.AcceptButton = this.uxSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 253);
            this.Controls.Add(this.uxEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.uxPhoneNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uxPurchaseAmount);
            this.Controls.Add(this.uxNumPurchase);
            this.Controls.Add(this.uxZipcode);
            this.Controls.Add(this.uxCity);
            this.Controls.Add(this.uxStreet2);
            this.Controls.Add(this.uxStreet);
            this.Controls.Add(this.uxCustomerId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxTxtFistName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxTxtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxTxtCustomerId);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GetCustomerInformation";
            this.Text = "Get Customer Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetCustomerInformation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxTxtCustomerId;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.TextBox uxTxtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTxtFistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label uxCustomerId;
        private System.Windows.Forms.Label uxStreet;
        private System.Windows.Forms.Label uxStreet2;
        private System.Windows.Forms.Label uxCity;
        private System.Windows.Forms.Label uxZipcode;
        private System.Windows.Forms.Label uxNumPurchase;
        private System.Windows.Forms.Label uxPurchaseAmount;
        private System.Windows.Forms.Label uxPhoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label uxEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn street2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipcode;
    }
}
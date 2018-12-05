namespace TestConnection
{
    partial class EmployeePerformance
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
            this.Search = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.Label();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxEmployeeId = new System.Windows.Forms.TextBox();
            this.uxTimeLine = new System.Windows.Forms.ComboBox();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.TotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCarsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HaggleLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(15, 82);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(62, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 304);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(12, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name:";
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(12, 9);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(65, 13);
            this.EmployeeId.TabIndex = 3;
            this.EmployeeId.Text = "EmployeeId:";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(12, 35);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(60, 13);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "First Name:";
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(83, 32);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(100, 20);
            this.uxFirstName.TabIndex = 5;
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(83, 58);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(100, 20);
            this.uxLastName.TabIndex = 6;
            // 
            // uxEmployeeId
            // 
            this.uxEmployeeId.Location = new System.Drawing.Point(83, 6);
            this.uxEmployeeId.Name = "uxEmployeeId";
            this.uxEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.uxEmployeeId.TabIndex = 7;
            // 
            // uxTimeLine
            // 
            this.uxTimeLine.FormattingEnabled = true;
            this.uxTimeLine.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.uxTimeLine.Location = new System.Drawing.Point(83, 84);
            this.uxTimeLine.Name = "uxTimeLine";
            this.uxTimeLine.Size = new System.Drawing.Size(100, 21);
            this.uxTimeLine.TabIndex = 8;
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.AllowUserToAddRows = false;
            this.uxDataGrid.AllowUserToDeleteRows = false;
            this.uxDataGrid.AllowUserToResizeRows = false;
            this.uxDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TotalSales,
            this.NumCarsSold,
            this.HaggleLoss});
            this.uxDataGrid.Location = new System.Drawing.Point(15, 111);
            this.uxDataGrid.MultiSelect = false;
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGrid.Size = new System.Drawing.Size(304, 155);
            this.uxDataGrid.TabIndex = 19;
            // 
            // TotalSales
            // 
            this.TotalSales.HeaderText = "TotalSales";
            this.TotalSales.Name = "TotalSales";
            // 
            // NumCarsSold
            // 
            this.NumCarsSold.HeaderText = "NumCarsSold";
            this.NumCarsSold.Name = "NumCarsSold";
            // 
            // HaggleLoss
            // 
            this.HaggleLoss.HeaderText = "HaggleLoss";
            this.HaggleLoss.Name = "HaggleLoss";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // EmployeePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 339);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.uxTimeLine);
            this.Controls.Add(this.uxEmployeeId);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmployeePerformance";
            this.Text = "Employee Performance";
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.TextBox uxEmployeeId;
        private System.Windows.Forms.ComboBox uxTimeLine;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCarsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn HaggleLoss;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
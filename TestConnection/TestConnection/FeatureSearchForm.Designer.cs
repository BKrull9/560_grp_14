﻿namespace TestConnection
{
    partial class FeatureSearchForm
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
            this.uxFeatureTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxMake = new System.Windows.Forms.Label();
            this.uxModel = new System.Windows.Forms.Label();
            this.uxColor = new System.Windows.Forms.Label();
            this.uxMilage = new System.Windows.Forms.Label();
            this.uxYear = new System.Windows.Forms.Label();
            this.uxOwnerCount = new System.Windows.Forms.Label();
            this.uxAskPrice = new System.Windows.Forms.Label();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealershipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.uxEmployeeLocationLbl = new System.Windows.Forms.Label();
            this.uxEmployeeEmailLbl = new System.Windows.Forms.Label();
            this.uxEmployeeEmailTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.uxWarningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFeatureTable
            // 
            this.uxFeatureTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFeatureTable.ColumnCount = 1;
            this.uxFeatureTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uxFeatureTable.Location = new System.Drawing.Point(12, 12);
            this.uxFeatureTable.Name = "uxFeatureTable";
            this.uxFeatureTable.RowCount = 5;
            this.uxFeatureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uxFeatureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uxFeatureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uxFeatureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uxFeatureTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.uxFeatureTable.Size = new System.Drawing.Size(696, 129);
            this.uxFeatureTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Owner Count:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ask Price:";
            // 
            // uxMake
            // 
            this.uxMake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMake.AutoSize = true;
            this.uxMake.Location = new System.Drawing.Point(589, 152);
            this.uxMake.Name = "uxMake";
            this.uxMake.Size = new System.Drawing.Size(13, 13);
            this.uxMake.TabIndex = 10;
            this.uxMake.Text = "--";
            // 
            // uxModel
            // 
            this.uxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxModel.AutoSize = true;
            this.uxModel.Location = new System.Drawing.Point(589, 174);
            this.uxModel.Name = "uxModel";
            this.uxModel.Size = new System.Drawing.Size(13, 13);
            this.uxModel.TabIndex = 11;
            this.uxModel.Text = "--";
            // 
            // uxColor
            // 
            this.uxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxColor.AutoSize = true;
            this.uxColor.Location = new System.Drawing.Point(589, 218);
            this.uxColor.Name = "uxColor";
            this.uxColor.Size = new System.Drawing.Size(13, 13);
            this.uxColor.TabIndex = 12;
            this.uxColor.Text = "--";
            // 
            // uxMilage
            // 
            this.uxMilage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMilage.AutoSize = true;
            this.uxMilage.Location = new System.Drawing.Point(589, 243);
            this.uxMilage.Name = "uxMilage";
            this.uxMilage.Size = new System.Drawing.Size(13, 13);
            this.uxMilage.TabIndex = 13;
            this.uxMilage.Text = "--";
            // 
            // uxYear
            // 
            this.uxYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxYear.AutoSize = true;
            this.uxYear.Location = new System.Drawing.Point(589, 196);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(13, 13);
            this.uxYear.TabIndex = 14;
            this.uxYear.Text = "--";
            // 
            // uxOwnerCount
            // 
            this.uxOwnerCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOwnerCount.AutoSize = true;
            this.uxOwnerCount.Location = new System.Drawing.Point(589, 265);
            this.uxOwnerCount.Name = "uxOwnerCount";
            this.uxOwnerCount.Size = new System.Drawing.Size(13, 13);
            this.uxOwnerCount.TabIndex = 15;
            this.uxOwnerCount.Text = "--";
            // 
            // uxAskPrice
            // 
            this.uxAskPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAskPrice.AutoSize = true;
            this.uxAskPrice.Location = new System.Drawing.Point(589, 288);
            this.uxAskPrice.Name = "uxAskPrice";
            this.uxAskPrice.Size = new System.Drawing.Size(13, 13);
            this.uxAskPrice.TabIndex = 16;
            this.uxAskPrice.Text = "--";
            // 
            // uxBack
            // 
            this.uxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxBack.Location = new System.Drawing.Point(12, 335);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(75, 23);
            this.uxBack.TabIndex = 17;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
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
            this.id,
            this.make,
            this.model,
            this.year,
            this.askPrice,
            this.color,
            this.milage,
            this.dealershipId,
            this.ownerCnt});
            this.uxDataGrid.Location = new System.Drawing.Point(12, 152);
            this.uxDataGrid.MultiSelect = false;
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.ReadOnly = true;
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGrid.Size = new System.Drawing.Size(486, 155);
            this.uxDataGrid.TabIndex = 18;
            this.uxDataGrid.SelectionChanged += new System.EventHandler(this.uxDataGrid_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // make
            // 
            this.make.HeaderText = "Make";
            this.make.Name = "make";
            this.make.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Model";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // askPrice
            // 
            this.askPrice.HeaderText = "Ask Price";
            this.askPrice.Name = "askPrice";
            this.askPrice.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Visible = false;
            // 
            // milage
            // 
            this.milage.HeaderText = "Milage";
            this.milage.Name = "milage";
            this.milage.ReadOnly = true;
            this.milage.Visible = false;
            // 
            // dealershipId
            // 
            this.dealershipId.HeaderText = "Dealership ID";
            this.dealershipId.Name = "dealershipId";
            this.dealershipId.ReadOnly = true;
            this.dealershipId.Visible = false;
            // 
            // ownerCnt
            // 
            this.ownerCnt.HeaderText = "Owner Count";
            this.ownerCnt.Name = "ownerCnt";
            this.ownerCnt.ReadOnly = true;
            this.ownerCnt.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(93, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxEmployeeLocationLbl
            // 
            this.uxEmployeeLocationLbl.AutoSize = true;
            this.uxEmployeeLocationLbl.Location = new System.Drawing.Point(470, 341);
            this.uxEmployeeLocationLbl.Name = "uxEmployeeLocationLbl";
            this.uxEmployeeLocationLbl.Size = new System.Drawing.Size(103, 13);
            this.uxEmployeeLocationLbl.TabIndex = 33;
            this.uxEmployeeLocationLbl.Text = "Employee Location: ";
            // 
            // uxEmployeeEmailLbl
            // 
            this.uxEmployeeEmailLbl.AutoSize = true;
            this.uxEmployeeEmailLbl.Location = new System.Drawing.Point(174, 340);
            this.uxEmployeeEmailLbl.Name = "uxEmployeeEmailLbl";
            this.uxEmployeeEmailLbl.Size = new System.Drawing.Size(136, 13);
            this.uxEmployeeEmailLbl.TabIndex = 32;
            this.uxEmployeeEmailLbl.Text = "Employee Email (Required):";
            // 
            // uxEmployeeEmailTxtBox
            // 
            this.uxEmployeeEmailTxtBox.Location = new System.Drawing.Point(316, 338);
            this.uxEmployeeEmailTxtBox.Name = "uxEmployeeEmailTxtBox";
            this.uxEmployeeEmailTxtBox.Size = new System.Drawing.Size(148, 20);
            this.uxEmployeeEmailTxtBox.TabIndex = 31;
            this.uxEmployeeEmailTxtBox.TextChanged += new System.EventHandler(this.uxEmployeeEmailTxtBox_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Location: ";
            // 
            // uxWarningLabel
            // 
            this.uxWarningLabel.AutoSize = true;
            this.uxWarningLabel.Location = new System.Drawing.Point(387, 368);
            this.uxWarningLabel.Name = "uxWarningLabel";
            this.uxWarningLabel.Size = new System.Drawing.Size(321, 13);
            this.uxWarningLabel.TabIndex = 35;
            this.uxWarningLabel.Text = "Note: locations of car and salesman must match to make purchase";
            // 
            // FeatureSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 390);
            this.Controls.Add(this.uxWarningLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uxEmployeeLocationLbl);
            this.Controls.Add(this.uxEmployeeEmailLbl);
            this.Controls.Add(this.uxEmployeeEmailTxtBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.uxAskPrice);
            this.Controls.Add(this.uxOwnerCount);
            this.Controls.Add(this.uxYear);
            this.Controls.Add(this.uxMilage);
            this.Controls.Add(this.uxColor);
            this.Controls.Add(this.uxModel);
            this.Controls.Add(this.uxMake);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxFeatureTable);
            this.Name = "FeatureSearchForm";
            this.Text = "FeatureSearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeatureSearchForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uxFeatureTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uxMake;
        private System.Windows.Forms.Label uxModel;
        private System.Windows.Forms.Label uxColor;
        private System.Windows.Forms.Label uxMilage;
        private System.Windows.Forms.Label uxYear;
        private System.Windows.Forms.Label uxOwnerCount;
        private System.Windows.Forms.Label uxAskPrice;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn askPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn milage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealershipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerCnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label uxEmployeeLocationLbl;
        private System.Windows.Forms.Label uxEmployeeEmailLbl;
        private System.Windows.Forms.TextBox uxEmployeeEmailTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label uxWarningLabel;
    }
}
namespace TestConnection
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.uxFeatureTable.Size = new System.Drawing.Size(481, 129);
            this.uxFeatureTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(365, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Test Feature Population";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 160);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Owner Count:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ask Price:";
            // 
            // uxMake
            // 
            this.uxMake.AutoSize = true;
            this.uxMake.Location = new System.Drawing.Point(374, 152);
            this.uxMake.Name = "uxMake";
            this.uxMake.Size = new System.Drawing.Size(13, 13);
            this.uxMake.TabIndex = 10;
            this.uxMake.Text = "--";
            // 
            // uxModel
            // 
            this.uxModel.AutoSize = true;
            this.uxModel.Location = new System.Drawing.Point(374, 174);
            this.uxModel.Name = "uxModel";
            this.uxModel.Size = new System.Drawing.Size(13, 13);
            this.uxModel.TabIndex = 11;
            this.uxModel.Text = "--";
            // 
            // uxColor
            // 
            this.uxColor.AutoSize = true;
            this.uxColor.Location = new System.Drawing.Point(374, 197);
            this.uxColor.Name = "uxColor";
            this.uxColor.Size = new System.Drawing.Size(13, 13);
            this.uxColor.TabIndex = 12;
            this.uxColor.Text = "--";
            // 
            // uxMilage
            // 
            this.uxMilage.AutoSize = true;
            this.uxMilage.Location = new System.Drawing.Point(374, 243);
            this.uxMilage.Name = "uxMilage";
            this.uxMilage.Size = new System.Drawing.Size(13, 13);
            this.uxMilage.TabIndex = 13;
            this.uxMilage.Text = "--";
            // 
            // uxYear
            // 
            this.uxYear.AutoSize = true;
            this.uxYear.Location = new System.Drawing.Point(374, 219);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(13, 13);
            this.uxYear.TabIndex = 14;
            this.uxYear.Text = "--";
            // 
            // uxOwnerCount
            // 
            this.uxOwnerCount.AutoSize = true;
            this.uxOwnerCount.Location = new System.Drawing.Point(374, 265);
            this.uxOwnerCount.Name = "uxOwnerCount";
            this.uxOwnerCount.Size = new System.Drawing.Size(13, 13);
            this.uxOwnerCount.TabIndex = 15;
            this.uxOwnerCount.Text = "--";
            // 
            // uxAskPrice
            // 
            this.uxAskPrice.AutoSize = true;
            this.uxAskPrice.Location = new System.Drawing.Point(374, 288);
            this.uxAskPrice.Name = "uxAskPrice";
            this.uxAskPrice.Size = new System.Drawing.Size(13, 13);
            this.uxAskPrice.TabIndex = 16;
            this.uxAskPrice.Text = "--";
            // 
            // uxBack
            // 
            this.uxBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxBack.Location = new System.Drawing.Point(12, 313);
            this.uxBack.Name = "uxBack";
            this.uxBack.Size = new System.Drawing.Size(75, 23);
            this.uxBack.TabIndex = 17;
            this.uxBack.Text = "Back";
            this.uxBack.UseVisualStyleBackColor = true;
            this.uxBack.Click += new System.EventHandler(this.uxBack_Click);
            // 
            // FeatureSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 343);
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
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uxFeatureTable);
            this.Name = "FeatureSearchForm";
            this.Text = "FeatureSearchForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeatureSearchForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel uxFeatureTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
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
    }
}
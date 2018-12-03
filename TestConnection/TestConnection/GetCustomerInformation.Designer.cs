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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxBack = new System.Windows.Forms.Button();
            this.uxSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // GetCustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 253);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Name = "GetCustomerInformation";
            this.Text = "Get Customer Information";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetCustomerInformation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button uxBack;
        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
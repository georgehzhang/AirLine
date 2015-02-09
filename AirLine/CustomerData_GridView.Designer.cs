namespace AirLine
{
    partial class CustomerData_GridView
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
            this.FirstName_Search_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Load_Table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(653, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstName_Search_TextBox
            // 
            this.FirstName_Search_TextBox.Location = new System.Drawing.Point(286, 56);
            this.FirstName_Search_TextBox.Name = "FirstName_Search_TextBox";
            this.FirstName_Search_TextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstName_Search_TextBox.TabIndex = 6;
            this.FirstName_Search_TextBox.TextChanged += new System.EventHandler(this.Destination_Search_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // Load_Table
            // 
            this.Load_Table.Location = new System.Drawing.Point(277, 12);
            this.Load_Table.Name = "Load_Table";
            this.Load_Table.Size = new System.Drawing.Size(75, 23);
            this.Load_Table.TabIndex = 4;
            this.Load_Table.Text = "Load Table";
            this.Load_Table.UseVisualStyleBackColor = true;
            this.Load_Table.Click += new System.EventHandler(this.Load_Table_Click);
            // 
            // CustomerData_GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 441);
            this.Controls.Add(this.FirstName_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load_Table);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerData_GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerData_GridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FirstName_Search_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load_Table;
    }
}
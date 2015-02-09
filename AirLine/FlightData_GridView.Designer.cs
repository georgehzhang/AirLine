namespace AirLine
{
    partial class FlightData_GridView
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
            this.Load_Table = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Destination_Search_TextBox = new System.Windows.Forms.TextBox();
            this.customersDatabaseDataSet1 = new AirLine.customersDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(663, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // Load_Table
            // 
            this.Load_Table.Location = new System.Drawing.Point(285, 30);
            this.Load_Table.Name = "Load_Table";
            this.Load_Table.Size = new System.Drawing.Size(75, 23);
            this.Load_Table.TabIndex = 1;
            this.Load_Table.Text = "Load Table";
            this.Load_Table.UseVisualStyleBackColor = true;
            this.Load_Table.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // Destination_Search_TextBox
            // 
            this.Destination_Search_TextBox.Location = new System.Drawing.Point(273, 72);
            this.Destination_Search_TextBox.Name = "Destination_Search_TextBox";
            this.Destination_Search_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Destination_Search_TextBox.TabIndex = 3;
            this.Destination_Search_TextBox.TextChanged += new System.EventHandler(this.Destination_Search_TextBox_TextChanged);
            // 
            // customersDatabaseDataSet1
            // 
            this.customersDatabaseDataSet1.DataSetName = "customersDatabaseDataSet";
            this.customersDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FlightData_GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 487);
            this.Controls.Add(this.Destination_Search_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load_Table);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FlightData_GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightData_GridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Load_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Destination_Search_TextBox;
        private customersDatabaseDataSet customersDatabaseDataSet1;
    }
}
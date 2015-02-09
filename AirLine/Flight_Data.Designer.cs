namespace AirLine
{
    partial class Flight_Data
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
            this.components = new System.ComponentModel.Container();
            this.flightDatabaseDataSet = new AirLine.flightDatabaseDataSet();
            this.flightInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfoTableAdapter = new AirLine.flightDatabaseDataSetTableAdapters.flightInfoTableAdapter();
            this.tableAdapterManager = new AirLine.flightDatabaseDataSetTableAdapters.TableAdapterManager();
            this.flightInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchToolStrip = new System.Windows.Forms.ToolStrip();
            this.planeIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.planeIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoDataGridView)).BeginInit();
            this.searchToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightDatabaseDataSet
            // 
            this.flightDatabaseDataSet.DataSetName = "flightDatabaseDataSet";
            this.flightDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightInfoBindingSource
            // 
            this.flightInfoBindingSource.DataMember = "flightInfo";
            this.flightInfoBindingSource.DataSource = this.flightDatabaseDataSet;
            // 
            // flightInfoTableAdapter
            // 
            this.flightInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.flightInfoTableAdapter = this.flightInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AirLine.flightDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightInfoDataGridView
            // 
            this.flightInfoDataGridView.AutoGenerateColumns = false;
            this.flightInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.flightInfoDataGridView.DataSource = this.flightInfoBindingSource;
            this.flightInfoDataGridView.Location = new System.Drawing.Point(12, 123);
            this.flightInfoDataGridView.Name = "flightInfoDataGridView";
            this.flightInfoDataGridView.Size = new System.Drawing.Size(762, 326);
            this.flightInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlaneID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlaneID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DepartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "DepartTime";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Origin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Origin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "ArrivalTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn7.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn8.HeaderText = "Company";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Terminal";
            this.dataGridViewTextBoxColumn9.HeaderText = "Terminal";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Seats";
            this.dataGridViewTextBoxColumn10.HeaderText = "Seats";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // searchToolStrip
            // 
            this.searchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.searchToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planeIDToolStripLabel,
            this.planeIDToolStripTextBox,
            this.searchToolStripButton});
            this.searchToolStrip.Location = new System.Drawing.Point(282, 31);
            this.searchToolStrip.Name = "searchToolStrip";
            this.searchToolStrip.Size = new System.Drawing.Size(201, 25);
            this.searchToolStrip.TabIndex = 3;
            this.searchToolStrip.Text = "searchToolStrip";
            // 
            // planeIDToolStripLabel
            // 
            this.planeIDToolStripLabel.Name = "planeIDToolStripLabel";
            this.planeIDToolStripLabel.Size = new System.Drawing.Size(50, 22);
            this.planeIDToolStripLabel.Text = "PlaneID:";
            // 
            // planeIDToolStripTextBox
            // 
            this.planeIDToolStripTextBox.Name = "planeIDToolStripTextBox";
            this.planeIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.searchToolStripButton.Text = "Search";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Flight_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchToolStrip);
            this.Controls.Add(this.flightInfoDataGridView);
            this.Name = "Flight_Data";
            this.Text = "Flight Data";
            this.Load += new System.EventHandler(this.Choose_Flight_As_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoDataGridView)).EndInit();
            this.searchToolStrip.ResumeLayout(false);
            this.searchToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private flightDatabaseDataSet flightDatabaseDataSet;
        private System.Windows.Forms.BindingSource flightInfoBindingSource;
        private flightDatabaseDataSetTableAdapters.flightInfoTableAdapter flightInfoTableAdapter;
        private flightDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView flightInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStrip searchToolStrip;
        private System.Windows.Forms.ToolStripLabel planeIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox planeIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}
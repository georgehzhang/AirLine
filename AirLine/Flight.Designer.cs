namespace AirLine
{
    partial class Flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label planeIDLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label departTimeLabel;
            System.Windows.Forms.Label originLabel;
            System.Windows.Forms.Label arrivalTimeLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label terminalLabel;
            System.Windows.Forms.Label seatsLabel;
            System.Windows.Forms.Label priceLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flightDatabaseDataSet = new AirLine.flightDatabaseDataSet();
            this.flightInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightInfoTableAdapter = new AirLine.flightDatabaseDataSetTableAdapters.flightInfoTableAdapter();
            this.tableAdapterManager = new AirLine.flightDatabaseDataSetTableAdapters.TableAdapterManager();
            this.flightInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.flightInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.planeIDTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.terminalTextBox = new System.Windows.Forms.TextBox();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            planeIDLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            departTimeLabel = new System.Windows.Forms.Label();
            originLabel = new System.Windows.Forms.Label();
            arrivalTimeLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            terminalLabel = new System.Windows.Forms.Label();
            seatsLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flightDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingNavigator)).BeginInit();
            this.flightInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // flightInfoBindingNavigator
            // 
            this.flightInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.flightInfoBindingNavigator.BindingSource = this.flightInfoBindingSource;
            this.flightInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.flightInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.flightInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.flightInfoBindingNavigatorSaveItem});
            this.flightInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.flightInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.flightInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.flightInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.flightInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.flightInfoBindingNavigator.Name = "flightInfoBindingNavigator";
            this.flightInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.flightInfoBindingNavigator.Size = new System.Drawing.Size(867, 25);
            this.flightInfoBindingNavigator.TabIndex = 27;
            this.flightInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // flightInfoBindingNavigatorSaveItem
            // 
            this.flightInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.flightInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("flightInfoBindingNavigatorSaveItem.Image")));
            this.flightInfoBindingNavigatorSaveItem.Name = "flightInfoBindingNavigatorSaveItem";
            this.flightInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.flightInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.flightInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.flightInfoBindingNavigatorSaveItem_Click_3);
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
            this.flightInfoDataGridView.Location = new System.Drawing.Point(292, 79);
            this.flightInfoDataGridView.Name = "flightInfoDataGridView";
            this.flightInfoDataGridView.Size = new System.Drawing.Size(575, 292);
            this.flightInfoDataGridView.TabIndex = 27;
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
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 79);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 27;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(86, 76);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 28;
            // 
            // planeIDLabel
            // 
            planeIDLabel.AutoSize = true;
            planeIDLabel.Location = new System.Drawing.Point(12, 105);
            planeIDLabel.Name = "planeIDLabel";
            planeIDLabel.Size = new System.Drawing.Size(51, 13);
            planeIDLabel.TabIndex = 29;
            planeIDLabel.Text = "Plane ID:";
            // 
            // planeIDTextBox
            // 
            this.planeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "PlaneID", true));
            this.planeIDTextBox.Location = new System.Drawing.Point(86, 102);
            this.planeIDTextBox.Name = "planeIDTextBox";
            this.planeIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.planeIDTextBox.TabIndex = 30;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 132);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 31;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightInfoBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(86, 128);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 32;
            // 
            // departTimeLabel
            // 
            departTimeLabel.AutoSize = true;
            departTimeLabel.Location = new System.Drawing.Point(12, 158);
            departTimeLabel.Name = "departTimeLabel";
            departTimeLabel.Size = new System.Drawing.Size(68, 13);
            departTimeLabel.TabIndex = 33;
            departTimeLabel.Text = "Depart Time:";
            // 
            // departTimeDateTimePicker
            // 
            this.departTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightInfoBindingSource, "DepartTime", true));
            this.departTimeDateTimePicker.Location = new System.Drawing.Point(86, 154);
            this.departTimeDateTimePicker.Name = "departTimeDateTimePicker";
            this.departTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.departTimeDateTimePicker.TabIndex = 34;
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new System.Drawing.Point(12, 183);
            originLabel.Name = "originLabel";
            originLabel.Size = new System.Drawing.Size(37, 13);
            originLabel.TabIndex = 35;
            originLabel.Text = "Origin:";
            // 
            // originTextBox
            // 
            this.originTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Origin", true));
            this.originTextBox.Location = new System.Drawing.Point(86, 180);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(200, 20);
            this.originTextBox.TabIndex = 36;
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new System.Drawing.Point(12, 210);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new System.Drawing.Size(65, 13);
            arrivalTimeLabel.TabIndex = 37;
            arrivalTimeLabel.Text = "Arrival Time:";
            // 
            // arrivalTimeDateTimePicker
            // 
            this.arrivalTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.flightInfoBindingSource, "ArrivalTime", true));
            this.arrivalTimeDateTimePicker.Location = new System.Drawing.Point(86, 206);
            this.arrivalTimeDateTimePicker.Name = "arrivalTimeDateTimePicker";
            this.arrivalTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.arrivalTimeDateTimePicker.TabIndex = 38;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(12, 235);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(63, 13);
            destinationLabel.TabIndex = 39;
            destinationLabel.Text = "Destination:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(86, 232);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(200, 20);
            this.destinationTextBox.TabIndex = 40;
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(12, 261);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(54, 13);
            companyLabel.TabIndex = 41;
            companyLabel.Text = "Company:";
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(86, 258);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(200, 20);
            this.companyTextBox.TabIndex = 42;
            // 
            // terminalLabel
            // 
            terminalLabel.AutoSize = true;
            terminalLabel.Location = new System.Drawing.Point(12, 287);
            terminalLabel.Name = "terminalLabel";
            terminalLabel.Size = new System.Drawing.Size(50, 13);
            terminalLabel.TabIndex = 43;
            terminalLabel.Text = "Terminal:";
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Terminal", true));
            this.terminalTextBox.Location = new System.Drawing.Point(86, 284);
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.Size = new System.Drawing.Size(200, 20);
            this.terminalTextBox.TabIndex = 44;
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new System.Drawing.Point(12, 313);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new System.Drawing.Size(37, 13);
            seatsLabel.TabIndex = 45;
            seatsLabel.Text = "Seats:";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Seats", true));
            this.seatsTextBox.Location = new System.Drawing.Point(86, 310);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(200, 20);
            this.seatsTextBox.TabIndex = 46;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 339);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 47;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flightInfoBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(86, 336);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 48;
            // 
            // Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(planeIDLabel);
            this.Controls.Add(this.planeIDTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(departTimeLabel);
            this.Controls.Add(this.departTimeDateTimePicker);
            this.Controls.Add(originLabel);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(arrivalTimeLabel);
            this.Controls.Add(this.arrivalTimeDateTimePicker);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(terminalLabel);
            this.Controls.Add(this.terminalTextBox);
            this.Controls.Add(seatsLabel);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.flightInfoDataGridView);
            this.Controls.Add(this.flightInfoBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Flight";
            this.Text = "Flight";
            this.Load += new System.EventHandler(this.Flight_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.flightDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoBindingNavigator)).EndInit();
            this.flightInfoBindingNavigator.ResumeLayout(false);
            this.flightInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private flightDatabaseDataSet flightDatabaseDataSet;
        private System.Windows.Forms.BindingSource flightInfoBindingSource;
        private flightDatabaseDataSetTableAdapters.flightInfoTableAdapter flightInfoTableAdapter;
        private flightDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator flightInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton flightInfoBindingNavigatorSaveItem;
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox planeIDTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker departTimeDateTimePicker;
        private System.Windows.Forms.TextBox originTextBox;
        private System.Windows.Forms.DateTimePicker arrivalTimeDateTimePicker;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox terminalTextBox;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;


    }
}
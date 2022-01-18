namespace WindowsProg
{
    partial class Siparis
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
            this.userDataDataSet = new WindowsProg.UserDataDataSet();
            this.foodGrid = new System.Windows.Forms.DataGridView();
            this.drinkGrid = new System.Windows.Forms.DataGridView();
            this.dessertGrid = new System.Windows.Forms.DataGridView();
            this.foodGroupBox = new System.Windows.Forms.GroupBox();
            this.Quantity = new System.Windows.Forms.NumericUpDown();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.drinkGroupBox = new System.Windows.Forms.GroupBox();
            this.drinkQuantity = new System.Windows.Forms.NumericUpDown();
            this.drinkPriceTextBox = new System.Windows.Forms.TextBox();
            this.drinkNameTextBox = new System.Windows.Forms.TextBox();
            this.dessertGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertQuantity = new System.Windows.Forms.NumericUpDown();
            this.dessertPriceTextBox = new System.Windows.Forms.TextBox();
            this.dessertNameTextBox = new System.Windows.Forms.TextBox();
            this.tableOrTakeawayGroupBox = new System.Windows.Forms.GroupBox();
            this.takeawayRadioButton = new System.Windows.Forms.RadioButton();
            this.toTableRadioButton = new System.Windows.Forms.RadioButton();
            this.tableGroupBox = new System.Windows.Forms.GroupBox();
            this.table6RadioButton = new System.Windows.Forms.RadioButton();
            this.table5RadioButton = new System.Windows.Forms.RadioButton();
            this.table4RadioButton = new System.Windows.Forms.RadioButton();
            this.table3RadioButton = new System.Windows.Forms.RadioButton();
            this.table2RadioButton = new System.Windows.Forms.RadioButton();
            this.table1RadioButton = new System.Windows.Forms.RadioButton();
            this.payButton = new FontAwesome.Sharp.IconButton();
            this.saveTableButton = new FontAwesome.Sharp.IconButton();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertGrid)).BeginInit();
            this.foodGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            this.drinkGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantity)).BeginInit();
            this.dessertGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertQuantity)).BeginInit();
            this.tableOrTakeawayGroupBox.SuspendLayout();
            this.tableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userDataDataSet
            // 
            this.userDataDataSet.DataSetName = "UserDataDataSet";
            this.userDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodGrid
            // 
            this.foodGrid.AutoGenerateColumns = false;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.foodGrid.DataSource = this.productBindingSource;
            this.foodGrid.Location = new System.Drawing.Point(18, 18);
            this.foodGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.ReadOnly = true;
            this.foodGrid.RowHeadersWidth = 62;
            this.foodGrid.Size = new System.Drawing.Size(480, 262);
            this.foodGrid.TabIndex = 0;
            this.foodGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGrid_CellClick);
            // 
            // drinkGrid
            // 
            this.drinkGrid.AutoGenerateColumns = false;
            this.drinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.drinkGrid.DataSource = this.productBindingSource;
            this.drinkGrid.Location = new System.Drawing.Point(507, 18);
            this.drinkGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkGrid.Name = "drinkGrid";
            this.drinkGrid.RowHeadersWidth = 62;
            this.drinkGrid.Size = new System.Drawing.Size(480, 262);
            this.drinkGrid.TabIndex = 1;
            this.drinkGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drinkGrid_CellClick);
            // 
            // dessertGrid
            // 
            this.dessertGrid.AutoGenerateColumns = false;
            this.dessertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dessertGrid.DataSource = this.productBindingSource;
            this.dessertGrid.Location = new System.Drawing.Point(996, 18);
            this.dessertGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertGrid.Name = "dessertGrid";
            this.dessertGrid.RowHeadersWidth = 62;
            this.dessertGrid.Size = new System.Drawing.Size(480, 262);
            this.dessertGrid.TabIndex = 2;
            this.dessertGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dessertGrid_CellClick);
            // 
            // foodGroupBox
            // 
            this.foodGroupBox.Controls.Add(this.Quantity);
            this.foodGroupBox.Controls.Add(this.priceTextBox);
            this.foodGroupBox.Controls.Add(this.foodNameTextBox);
            this.foodGroupBox.Location = new System.Drawing.Point(20, 291);
            this.foodGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodGroupBox.Name = "foodGroupBox";
            this.foodGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodGroupBox.Size = new System.Drawing.Size(478, 280);
            this.foodGroupBox.TabIndex = 3;
            this.foodGroupBox.TabStop = false;
            this.foodGroupBox.Text = "Food";
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(327, 29);
            this.Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(141, 26);
            this.Quantity.TabIndex = 2;
            this.Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Quantity.ValueChanged += new System.EventHandler(this.Quantity_ValueChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.priceTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.priceTextBox.Location = new System.Drawing.Point(168, 29);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priceTextBox.Multiline = true;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(148, 239);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.Text = "0";
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.foodNameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.foodNameTextBox.Location = new System.Drawing.Point(9, 29);
            this.foodNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodNameTextBox.Multiline = true;
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(148, 239);
            this.foodNameTextBox.TabIndex = 0;
            // 
            // drinkGroupBox
            // 
            this.drinkGroupBox.Controls.Add(this.drinkQuantity);
            this.drinkGroupBox.Controls.Add(this.drinkPriceTextBox);
            this.drinkGroupBox.Controls.Add(this.drinkNameTextBox);
            this.drinkGroupBox.Location = new System.Drawing.Point(508, 291);
            this.drinkGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkGroupBox.Name = "drinkGroupBox";
            this.drinkGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkGroupBox.Size = new System.Drawing.Size(478, 280);
            this.drinkGroupBox.TabIndex = 4;
            this.drinkGroupBox.TabStop = false;
            this.drinkGroupBox.Text = "Drink";
            // 
            // drinkQuantity
            // 
            this.drinkQuantity.Location = new System.Drawing.Point(327, 29);
            this.drinkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkQuantity.Name = "drinkQuantity";
            this.drinkQuantity.Size = new System.Drawing.Size(141, 26);
            this.drinkQuantity.TabIndex = 2;
            this.drinkQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.drinkQuantity.ValueChanged += new System.EventHandler(this.drinkQuantity_ValueChanged);
            // 
            // drinkPriceTextBox
            // 
            this.drinkPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.drinkPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drinkPriceTextBox.Location = new System.Drawing.Point(168, 29);
            this.drinkPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkPriceTextBox.Multiline = true;
            this.drinkPriceTextBox.Name = "drinkPriceTextBox";
            this.drinkPriceTextBox.Size = new System.Drawing.Size(148, 239);
            this.drinkPriceTextBox.TabIndex = 1;
            this.drinkPriceTextBox.Text = "0";
            // 
            // drinkNameTextBox
            // 
            this.drinkNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.drinkNameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drinkNameTextBox.Location = new System.Drawing.Point(9, 29);
            this.drinkNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkNameTextBox.Multiline = true;
            this.drinkNameTextBox.Name = "drinkNameTextBox";
            this.drinkNameTextBox.Size = new System.Drawing.Size(148, 239);
            this.drinkNameTextBox.TabIndex = 0;
            // 
            // dessertGroupBox
            // 
            this.dessertGroupBox.Controls.Add(this.dessertQuantity);
            this.dessertGroupBox.Controls.Add(this.dessertPriceTextBox);
            this.dessertGroupBox.Controls.Add(this.dessertNameTextBox);
            this.dessertGroupBox.Location = new System.Drawing.Point(998, 282);
            this.dessertGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertGroupBox.Name = "dessertGroupBox";
            this.dessertGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertGroupBox.Size = new System.Drawing.Size(478, 280);
            this.dessertGroupBox.TabIndex = 5;
            this.dessertGroupBox.TabStop = false;
            this.dessertGroupBox.Text = "Dessert";
            // 
            // dessertQuantity
            // 
            this.dessertQuantity.Location = new System.Drawing.Point(327, 29);
            this.dessertQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertQuantity.Name = "dessertQuantity";
            this.dessertQuantity.Size = new System.Drawing.Size(141, 26);
            this.dessertQuantity.TabIndex = 2;
            this.dessertQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dessertQuantity.ValueChanged += new System.EventHandler(this.dessertQuantity_ValueChanged);
            // 
            // dessertPriceTextBox
            // 
            this.dessertPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dessertPriceTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dessertPriceTextBox.Location = new System.Drawing.Point(168, 29);
            this.dessertPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertPriceTextBox.Multiline = true;
            this.dessertPriceTextBox.Name = "dessertPriceTextBox";
            this.dessertPriceTextBox.Size = new System.Drawing.Size(148, 239);
            this.dessertPriceTextBox.TabIndex = 1;
            this.dessertPriceTextBox.Text = "0";
            // 
            // dessertNameTextBox
            // 
            this.dessertNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.dessertNameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dessertNameTextBox.Location = new System.Drawing.Point(9, 29);
            this.dessertNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dessertNameTextBox.Multiline = true;
            this.dessertNameTextBox.Name = "dessertNameTextBox";
            this.dessertNameTextBox.Size = new System.Drawing.Size(148, 239);
            this.dessertNameTextBox.TabIndex = 0;
            // 
            // tableOrTakeawayGroupBox
            // 
            this.tableOrTakeawayGroupBox.Controls.Add(this.takeawayRadioButton);
            this.tableOrTakeawayGroupBox.Controls.Add(this.toTableRadioButton);
            this.tableOrTakeawayGroupBox.Location = new System.Drawing.Point(28, 628);
            this.tableOrTakeawayGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableOrTakeawayGroupBox.Name = "tableOrTakeawayGroupBox";
            this.tableOrTakeawayGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableOrTakeawayGroupBox.Size = new System.Drawing.Size(470, 203);
            this.tableOrTakeawayGroupBox.TabIndex = 6;
            this.tableOrTakeawayGroupBox.TabStop = false;
            this.tableOrTakeawayGroupBox.Text = "Table or Takeaway";
            // 
            // takeawayRadioButton
            // 
            this.takeawayRadioButton.AutoSize = true;
            this.takeawayRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.takeawayRadioButton.Location = new System.Drawing.Point(9, 74);
            this.takeawayRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.takeawayRadioButton.Name = "takeawayRadioButton";
            this.takeawayRadioButton.Size = new System.Drawing.Size(151, 31);
            this.takeawayRadioButton.TabIndex = 1;
            this.takeawayRadioButton.TabStop = true;
            this.takeawayRadioButton.Text = "Takeaway";
            this.takeawayRadioButton.UseVisualStyleBackColor = true;
            this.takeawayRadioButton.CheckedChanged += new System.EventHandler(this.takeawayRadioButton_CheckedChanged);
            // 
            // toTableRadioButton
            // 
            this.toTableRadioButton.AutoSize = true;
            this.toTableRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toTableRadioButton.Location = new System.Drawing.Point(10, 31);
            this.toTableRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toTableRadioButton.Name = "toTableRadioButton";
            this.toTableRadioButton.Size = new System.Drawing.Size(129, 31);
            this.toTableRadioButton.TabIndex = 0;
            this.toTableRadioButton.TabStop = true;
            this.toTableRadioButton.Text = "To Table";
            this.toTableRadioButton.UseVisualStyleBackColor = true;
            this.toTableRadioButton.CheckedChanged += new System.EventHandler(this.toTableRadioButton_CheckedChanged);
            // 
            // tableGroupBox
            // 
            this.tableGroupBox.Controls.Add(this.table6RadioButton);
            this.tableGroupBox.Controls.Add(this.table5RadioButton);
            this.tableGroupBox.Controls.Add(this.table4RadioButton);
            this.tableGroupBox.Controls.Add(this.table3RadioButton);
            this.tableGroupBox.Controls.Add(this.table2RadioButton);
            this.tableGroupBox.Controls.Add(this.table1RadioButton);
            this.tableGroupBox.Location = new System.Drawing.Point(507, 628);
            this.tableGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableGroupBox.Name = "tableGroupBox";
            this.tableGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableGroupBox.Size = new System.Drawing.Size(470, 203);
            this.tableGroupBox.TabIndex = 7;
            this.tableGroupBox.TabStop = false;
            this.tableGroupBox.Text = "Tables";
            this.tableGroupBox.Visible = false;
            // 
            // table6RadioButton
            // 
            this.table6RadioButton.AutoSize = true;
            this.table6RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table6RadioButton.Location = new System.Drawing.Point(170, 123);
            this.table6RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table6RadioButton.Name = "table6RadioButton";
            this.table6RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table6RadioButton.TabIndex = 5;
            this.table6RadioButton.TabStop = true;
            this.table6RadioButton.Text = "Table 6";
            this.table6RadioButton.UseVisualStyleBackColor = true;
            // 
            // table5RadioButton
            // 
            this.table5RadioButton.AutoSize = true;
            this.table5RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table5RadioButton.Location = new System.Drawing.Point(170, 80);
            this.table5RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table5RadioButton.Name = "table5RadioButton";
            this.table5RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table5RadioButton.TabIndex = 4;
            this.table5RadioButton.TabStop = true;
            this.table5RadioButton.Text = "Table 5";
            this.table5RadioButton.UseVisualStyleBackColor = true;
            // 
            // table4RadioButton
            // 
            this.table4RadioButton.AutoSize = true;
            this.table4RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table4RadioButton.Location = new System.Drawing.Point(170, 37);
            this.table4RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table4RadioButton.Name = "table4RadioButton";
            this.table4RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table4RadioButton.TabIndex = 3;
            this.table4RadioButton.TabStop = true;
            this.table4RadioButton.Text = "Table 4";
            this.table4RadioButton.UseVisualStyleBackColor = true;
            // 
            // table3RadioButton
            // 
            this.table3RadioButton.AutoSize = true;
            this.table3RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table3RadioButton.Location = new System.Drawing.Point(9, 123);
            this.table3RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table3RadioButton.Name = "table3RadioButton";
            this.table3RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table3RadioButton.TabIndex = 2;
            this.table3RadioButton.TabStop = true;
            this.table3RadioButton.Text = "Table 3";
            this.table3RadioButton.UseVisualStyleBackColor = true;
            // 
            // table2RadioButton
            // 
            this.table2RadioButton.AutoSize = true;
            this.table2RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table2RadioButton.Location = new System.Drawing.Point(10, 80);
            this.table2RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table2RadioButton.Name = "table2RadioButton";
            this.table2RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table2RadioButton.TabIndex = 1;
            this.table2RadioButton.TabStop = true;
            this.table2RadioButton.Text = "Table 2";
            this.table2RadioButton.UseVisualStyleBackColor = true;
            // 
            // table1RadioButton
            // 
            this.table1RadioButton.AutoSize = true;
            this.table1RadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.table1RadioButton.Location = new System.Drawing.Point(10, 37);
            this.table1RadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.table1RadioButton.Name = "table1RadioButton";
            this.table1RadioButton.Size = new System.Drawing.Size(117, 31);
            this.table1RadioButton.TabIndex = 0;
            this.table1RadioButton.TabStop = true;
            this.table1RadioButton.Text = "Table 1";
            this.table1RadioButton.UseVisualStyleBackColor = true;
            // 
            // payButton
            // 
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.payButton.IconColor = System.Drawing.Color.Violet;
            this.payButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.payButton.Location = new System.Drawing.Point(1324, 628);
            this.payButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(152, 157);
            this.payButton.TabIndex = 8;
            this.payButton.Text = "Pay";
            this.payButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // saveTableButton
            // 
            this.saveTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTableButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveTableButton.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.saveTableButton.IconColor = System.Drawing.Color.Violet;
            this.saveTableButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveTableButton.Location = new System.Drawing.Point(1006, 628);
            this.saveTableButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveTableButton.Name = "saveTableButton";
            this.saveTableButton.Size = new System.Drawing.Size(152, 157);
            this.saveTableButton.TabIndex = 9;
            this.saveTableButton.Text = "Save Table";
            this.saveTableButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveTableButton.UseVisualStyleBackColor = true;
            this.saveTableButton.Visible = false;
            this.saveTableButton.Click += new System.EventHandler(this.saveTableButton_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn7.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn8.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PricePerUnit";
            this.dataGridViewTextBoxColumn9.HeaderText = "PricePerUnit";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsProg.Product);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn5.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PricePerUnit";
            this.dataGridViewTextBoxColumn6.HeaderText = "PricePerUnit";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn3.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PricePerUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "PricePerUnit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // Siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1596, 886);
            this.Controls.Add(this.saveTableButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.tableGroupBox);
            this.Controls.Add(this.tableOrTakeawayGroupBox);
            this.Controls.Add(this.dessertGroupBox);
            this.Controls.Add(this.drinkGroupBox);
            this.Controls.Add(this.foodGroupBox);
            this.Controls.Add(this.dessertGrid);
            this.Controls.Add(this.drinkGrid);
            this.Controls.Add(this.foodGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.Load += new System.EventHandler(this.Siparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertGrid)).EndInit();
            this.foodGroupBox.ResumeLayout(false);
            this.foodGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            this.drinkGroupBox.ResumeLayout(false);
            this.drinkGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drinkQuantity)).EndInit();
            this.dessertGroupBox.ResumeLayout(false);
            this.dessertGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dessertQuantity)).EndInit();
            this.tableOrTakeawayGroupBox.ResumeLayout(false);
            this.tableOrTakeawayGroupBox.PerformLayout();
            this.tableGroupBox.ResumeLayout(false);
            this.tableGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserDataDataSet userDataDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView foodGrid;
        private System.Windows.Forms.DataGridView drinkGrid;
        private System.Windows.Forms.DataGridView dessertGrid;
        private System.Windows.Forms.GroupBox foodGroupBox;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown Quantity;
        private System.Windows.Forms.GroupBox drinkGroupBox;
        private System.Windows.Forms.NumericUpDown drinkQuantity;
        private System.Windows.Forms.TextBox drinkPriceTextBox;
        private System.Windows.Forms.TextBox drinkNameTextBox;
        private System.Windows.Forms.GroupBox dessertGroupBox;
        private System.Windows.Forms.NumericUpDown dessertQuantity;
        private System.Windows.Forms.TextBox dessertPriceTextBox;
        private System.Windows.Forms.TextBox dessertNameTextBox;
        private System.Windows.Forms.GroupBox tableOrTakeawayGroupBox;
        private System.Windows.Forms.RadioButton toTableRadioButton;
        private System.Windows.Forms.RadioButton takeawayRadioButton;
        private System.Windows.Forms.GroupBox tableGroupBox;
        private System.Windows.Forms.RadioButton table1RadioButton;
        private System.Windows.Forms.RadioButton table6RadioButton;
        private System.Windows.Forms.RadioButton table5RadioButton;
        private System.Windows.Forms.RadioButton table4RadioButton;
        private System.Windows.Forms.RadioButton table3RadioButton;
        private System.Windows.Forms.RadioButton table2RadioButton;
        private FontAwesome.Sharp.IconButton payButton;
        private FontAwesome.Sharp.IconButton saveTableButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
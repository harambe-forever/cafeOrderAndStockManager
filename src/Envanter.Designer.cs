namespace WindowsProg
{
    partial class Envanter
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
            this.foodGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drinkGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dessertGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.orderNowButton = new System.Windows.Forms.RadioButton();
            this.furtherDateRadioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderButton = new FontAwesome.Sharp.IconButton();
            this.userDataDataSet = new WindowsProg.UserDataDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.willOrderAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedDeliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertGrid)).BeginInit();
            this.dateTimeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodGrid
            // 
            this.foodGrid.AutoGenerateColumns = false;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.foodGrid.DataSource = this.productBindingSource;
            this.foodGrid.Location = new System.Drawing.Point(12, 12);
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.Size = new System.Drawing.Size(299, 170);
            this.foodGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn3.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsProg.Product);
            // 
            // drinkGrid
            // 
            this.drinkGrid.AutoGenerateColumns = false;
            this.drinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drinkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.drinkGrid.DataSource = this.productBindingSource;
            this.drinkGrid.Location = new System.Drawing.Point(317, 12);
            this.drinkGrid.Name = "drinkGrid";
            this.drinkGrid.Size = new System.Drawing.Size(299, 170);
            this.drinkGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn4.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dessertGrid
            // 
            this.dessertGrid.AutoGenerateColumns = false;
            this.dessertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dessertGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dessertGrid.DataSource = this.productBindingSource;
            this.dessertGrid.Location = new System.Drawing.Point(622, 12);
            this.dessertGrid.Name = "dessertGrid";
            this.dessertGrid.Size = new System.Drawing.Size(299, 170);
            this.dessertGrid.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn5.HeaderText = "ProductName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "inStock";
            this.dataGridViewTextBoxColumn6.HeaderText = "inStock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dateTimeGroupBox
            // 
            this.dateTimeGroupBox.Controls.Add(this.orderNowButton);
            this.dateTimeGroupBox.Controls.Add(this.furtherDateRadioButton);
            this.dateTimeGroupBox.Location = new System.Drawing.Point(12, 221);
            this.dateTimeGroupBox.Name = "dateTimeGroupBox";
            this.dateTimeGroupBox.Size = new System.Drawing.Size(299, 143);
            this.dateTimeGroupBox.TabIndex = 4;
            this.dateTimeGroupBox.TabStop = false;
            this.dateTimeGroupBox.Text = "Date?";
            // 
            // orderNowButton
            // 
            this.orderNowButton.AutoSize = true;
            this.orderNowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderNowButton.Location = new System.Drawing.Point(6, 87);
            this.orderNowButton.Name = "orderNowButton";
            this.orderNowButton.Size = new System.Drawing.Size(106, 22);
            this.orderNowButton.TabIndex = 1;
            this.orderNowButton.TabStop = true;
            this.orderNowButton.Text = "Order Now";
            this.orderNowButton.UseVisualStyleBackColor = true;
            this.orderNowButton.CheckedChanged += new System.EventHandler(this.orderNowButton_CheckedChanged);
            // 
            // furtherDateRadioButton
            // 
            this.furtherDateRadioButton.AutoSize = true;
            this.furtherDateRadioButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.furtherDateRadioButton.Location = new System.Drawing.Point(6, 34);
            this.furtherDateRadioButton.Name = "furtherDateRadioButton";
            this.furtherDateRadioButton.Size = new System.Drawing.Size(134, 22);
            this.furtherDateRadioButton.TabIndex = 0;
            this.furtherDateRadioButton.TabStop = true;
            this.furtherDateRadioButton.Text = "To Further Date";
            this.furtherDateRadioButton.UseVisualStyleBackColor = true;
            this.furtherDateRadioButton.CheckedChanged += new System.EventHandler(this.furtherDateRadioButton_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker.Location = new System.Drawing.Point(416, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 5;
            this.dateTimePicker.Visible = false;
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.orderButton.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.orderButton.IconColor = System.Drawing.Color.Black;
            this.orderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.orderButton.Location = new System.Drawing.Point(820, 221);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(101, 102);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Place Order";
            this.orderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // userDataDataSet
            // 
            this.userDataDataSet.DataSetName = "UserDataDataSet";
            this.userDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryIDDataGridViewTextBoxColumn,
            this.willOrderAtDataGridViewTextBoxColumn,
            this.expectedDeliveryDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.deliveryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(652, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(WindowsProg.Delivery);
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // willOrderAtDataGridViewTextBoxColumn
            // 
            this.willOrderAtDataGridViewTextBoxColumn.DataPropertyName = "Will_Order_At";
            this.willOrderAtDataGridViewTextBoxColumn.HeaderText = "Will_Order_At";
            this.willOrderAtDataGridViewTextBoxColumn.Name = "willOrderAtDataGridViewTextBoxColumn";
            this.willOrderAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.willOrderAtDataGridViewTextBoxColumn.Width = 200;
            // 
            // expectedDeliveryDateDataGridViewTextBoxColumn
            // 
            this.expectedDeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "Expected_Delivery_Date";
            this.expectedDeliveryDateDataGridViewTextBoxColumn.HeaderText = "Expected_Delivery_Date";
            this.expectedDeliveryDateDataGridViewTextBoxColumn.Name = "expectedDeliveryDateDataGridViewTextBoxColumn";
            this.expectedDeliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expectedDeliveryDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Envanter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateTimeGroupBox);
            this.Controls.Add(this.dessertGrid);
            this.Controls.Add(this.drinkGrid);
            this.Controls.Add(this.foodGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Envanter";
            this.Text = "Envanter";
            this.Load += new System.EventHandler(this.Envanter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dessertGrid)).EndInit();
            this.dateTimeGroupBox.ResumeLayout(false);
            this.dateTimeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView foodGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView drinkGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dessertGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox dateTimeGroupBox;
        private System.Windows.Forms.RadioButton orderNowButton;
        private System.Windows.Forms.RadioButton furtherDateRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private FontAwesome.Sharp.IconButton orderButton;
        private UserDataDataSet userDataDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn willOrderAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expectedDeliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
    }
}
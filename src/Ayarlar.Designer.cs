namespace WindowsProg
{
    partial class Ayarlar
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
            this.satisAlisGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisAliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectQueryComboBox = new System.Windows.Forms.ComboBox();
            this.queryResultTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new FontAwesome.Sharp.IconButton();
            this.yeniCalisanEkleButton = new FontAwesome.Sharp.IconButton();
            this.yaniCalisanLabel = new System.Windows.Forms.Label();
            this.showEmployees = new System.Windows.Forms.RadioButton();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newItemButton = new FontAwesome.Sharp.IconButton();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new FontAwesome.Sharp.IconButton();
            this.removeItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // satisAlisGrid
            // 
            this.satisAlisGrid.AutoGenerateColumns = false;
            this.satisAlisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisAlisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.satisAlisGrid.DataSource = this.satisAliBindingSource;
            this.satisAlisGrid.Location = new System.Drawing.Point(18, 18);
            this.satisAlisGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.satisAlisGrid.Name = "satisAlisGrid";
            this.satisAlisGrid.RowHeadersWidth = 62;
            this.satisAlisGrid.Size = new System.Drawing.Size(526, 338);
            this.satisAlisGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Urun_Adi";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProcutName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Satis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gained";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Spent";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // satisAliBindingSource
            // 
            this.satisAliBindingSource.DataSource = typeof(WindowsProg.SatisAli);
            // 
            // selectQueryComboBox
            // 
            this.selectQueryComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectQueryComboBox.Items.AddRange(new object[] {
            "Profit made or money lost on the selected item",
            "Total profit or lost money on all items"});
            this.selectQueryComboBox.Location = new System.Drawing.Point(18, 395);
            this.selectQueryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectQueryComboBox.Name = "selectQueryComboBox";
            this.selectQueryComboBox.Size = new System.Drawing.Size(524, 35);
            this.selectQueryComboBox.TabIndex = 2;
            this.selectQueryComboBox.Text = "Select";
            // 
            // queryResultTextBox
            // 
            this.queryResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.queryResultTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.queryResultTextBox.Location = new System.Drawing.Point(663, 18);
            this.queryResultTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.queryResultTextBox.Multiline = true;
            this.queryResultTextBox.Name = "queryResultTextBox";
            this.queryResultTextBox.Size = new System.Drawing.Size(808, 336);
            this.queryResultTextBox.TabIndex = 3;
            this.queryResultTextBox.Text = "Query results will be listed here";
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.showButton.IconColor = System.Drawing.Color.Black;
            this.showButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showButton.IconSize = 36;
            this.showButton.Location = new System.Drawing.Point(663, 383);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(147, 65);
            this.showButton.TabIndex = 4;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // yeniCalisanEkleButton
            // 
            this.yeniCalisanEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniCalisanEkleButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniCalisanEkleButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.yeniCalisanEkleButton.IconColor = System.Drawing.Color.Black;
            this.yeniCalisanEkleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yeniCalisanEkleButton.IconSize = 36;
            this.yeniCalisanEkleButton.Location = new System.Drawing.Point(1276, 786);
            this.yeniCalisanEkleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yeniCalisanEkleButton.Name = "yeniCalisanEkleButton";
            this.yeniCalisanEkleButton.Size = new System.Drawing.Size(147, 65);
            this.yeniCalisanEkleButton.TabIndex = 5;
            this.yeniCalisanEkleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yeniCalisanEkleButton.UseVisualStyleBackColor = true;
            this.yeniCalisanEkleButton.Click += new System.EventHandler(this.yeniCalisanEkleButton_Click);
            // 
            // yaniCalisanLabel
            // 
            this.yaniCalisanLabel.AutoSize = true;
            this.yaniCalisanLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yaniCalisanLabel.Location = new System.Drawing.Point(1272, 740);
            this.yaniCalisanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yaniCalisanLabel.Name = "yaniCalisanLabel";
            this.yaniCalisanLabel.Size = new System.Drawing.Size(168, 27);
            this.yaniCalisanLabel.TabIndex = 6;
            this.yaniCalisanLabel.Text = "Add New User";
            // 
            // showEmployees
            // 
            this.showEmployees.AutoSize = true;
            this.showEmployees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showEmployees.Location = new System.Drawing.Point(1276, 860);
            this.showEmployees.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showEmployees.Name = "showEmployees";
            this.showEmployees.Size = new System.Drawing.Size(159, 31);
            this.showEmployees.TabIndex = 7;
            this.showEmployees.TabStop = true;
            this.showEmployees.Text = "Show Users";
            this.showEmployees.UseVisualStyleBackColor = true;
            this.showEmployees.CheckedChanged += new System.EventHandler(this.showEmployees_CheckedChanged);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7});
            this.usersDataGridView.DataSource = this.tableBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(27, 497);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 62;
            this.usersDataGridView.Size = new System.Drawing.Size(518, 338);
            this.usersDataGridView.TabIndex = 7;
            this.usersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Username";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(WindowsProg.Table);
            // 
            // newItemButton
            // 
            this.newItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newItemButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newItemButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.newItemButton.IconColor = System.Drawing.Color.Black;
            this.newItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newItemButton.IconSize = 36;
            this.newItemButton.Location = new System.Drawing.Point(1034, 786);
            this.newItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newItemButton.Name = "newItemButton";
            this.newItemButton.Size = new System.Drawing.Size(147, 65);
            this.newItemButton.TabIndex = 8;
            this.newItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newItemButton.UseVisualStyleBackColor = true;
            this.newItemButton.Click += new System.EventHandler(this.newItemButton_Click);
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addItemLabel.Location = new System.Drawing.Point(1029, 740);
            this.addItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(171, 27);
            this.addItemLabel.TabIndex = 9;
            this.addItemLabel.Text = "Add New Item";
            // 
            // removeItemButton
            // 
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeItemButton.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.removeItemButton.IconColor = System.Drawing.Color.Black;
            this.removeItemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removeItemButton.IconSize = 36;
            this.removeItemButton.Location = new System.Drawing.Point(1034, 908);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(147, 65);
            this.removeItemButton.TabIndex = 10;
            this.removeItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // removeItemLabel
            // 
            this.removeItemLabel.AutoSize = true;
            this.removeItemLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.removeItemLabel.Location = new System.Drawing.Point(1029, 864);
            this.removeItemLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removeItemLabel.Name = "removeItemLabel";
            this.removeItemLabel.Size = new System.Drawing.Size(161, 27);
            this.removeItemLabel.TabIndex = 11;
            this.removeItemLabel.Text = "Remove Item";
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1503, 1038);
            this.Controls.Add(this.removeItemLabel);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemLabel);
            this.Controls.Add(this.newItemButton);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.showEmployees);
            this.Controls.Add(this.yaniCalisanLabel);
            this.Controls.Add(this.yeniCalisanEkleButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.queryResultTextBox);
            this.Controls.Add(this.selectQueryComboBox);
            this.Controls.Add(this.satisAlisGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource satisAliBindingSource;
        private System.Windows.Forms.DataGridView satisAlisGrid;
        private System.Windows.Forms.ComboBox selectQueryComboBox;
        private System.Windows.Forms.TextBox queryResultTextBox;
        private FontAwesome.Sharp.IconButton showButton;
        private FontAwesome.Sharp.IconButton yeniCalisanEkleButton;
        private System.Windows.Forms.Label yaniCalisanLabel;
        private System.Windows.Forms.RadioButton showEmployees;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private FontAwesome.Sharp.IconButton newItemButton;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private FontAwesome.Sharp.IconButton removeItemButton;
        private System.Windows.Forms.Label removeItemLabel;
    }
}
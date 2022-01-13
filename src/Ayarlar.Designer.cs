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
            this.selectQueryComboBox = new System.Windows.Forms.ComboBox();
            this.queryResultTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new FontAwesome.Sharp.IconButton();
            this.yeniCalisanEkleButton = new FontAwesome.Sharp.IconButton();
            this.yaniCalisanLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisAliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showEmployees = new System.Windows.Forms.RadioButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
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
            this.satisAlisGrid.Location = new System.Drawing.Point(12, 12);
            this.satisAlisGrid.Name = "satisAlisGrid";
            this.satisAlisGrid.Size = new System.Drawing.Size(351, 220);
            this.satisAlisGrid.TabIndex = 1;
            // 
            // selectQueryComboBox
            // 
            this.selectQueryComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectQueryComboBox.Items.AddRange(new object[] {
            "Seçilen ürünün kar-zarar durumunu raporla",
            "Toplam kar-zarar durumunu raporla"});
            this.selectQueryComboBox.Location = new System.Drawing.Point(12, 257);
            this.selectQueryComboBox.Name = "selectQueryComboBox";
            this.selectQueryComboBox.Size = new System.Drawing.Size(351, 26);
            this.selectQueryComboBox.TabIndex = 2;
            this.selectQueryComboBox.Text = "Select";
            // 
            // queryResultTextBox
            // 
            this.queryResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.queryResultTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.queryResultTextBox.Location = new System.Drawing.Point(442, 12);
            this.queryResultTextBox.Multiline = true;
            this.queryResultTextBox.Name = "queryResultTextBox";
            this.queryResultTextBox.Size = new System.Drawing.Size(540, 220);
            this.queryResultTextBox.TabIndex = 3;
            this.queryResultTextBox.Text = "Query sonuçları burada listelenecek";
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.showButton.IconColor = System.Drawing.Color.Black;
            this.showButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showButton.IconSize = 36;
            this.showButton.Location = new System.Drawing.Point(442, 249);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(98, 42);
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
            this.yeniCalisanEkleButton.Location = new System.Drawing.Point(851, 511);
            this.yeniCalisanEkleButton.Name = "yeniCalisanEkleButton";
            this.yeniCalisanEkleButton.Size = new System.Drawing.Size(98, 42);
            this.yeniCalisanEkleButton.TabIndex = 5;
            this.yeniCalisanEkleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.yeniCalisanEkleButton.UseVisualStyleBackColor = true;
            this.yeniCalisanEkleButton.Click += new System.EventHandler(this.yeniCalisanEkleButton_Click);
            // 
            // yaniCalisanLabel
            // 
            this.yaniCalisanLabel.AutoSize = true;
            this.yaniCalisanLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yaniCalisanLabel.Location = new System.Drawing.Point(848, 481);
            this.yaniCalisanLabel.Name = "yaniCalisanLabel";
            this.yaniCalisanLabel.Size = new System.Drawing.Size(134, 18);
            this.yaniCalisanLabel.TabIndex = 6;
            this.yaniCalisanLabel.Text = "Yeni Çalışan Ekle";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Urun_Adi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Urun_Adi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Satis";
            this.dataGridViewTextBoxColumn2.HeaderText = "Satis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Alis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Alis";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // satisAliBindingSource
            // 
            this.satisAliBindingSource.DataSource = typeof(WindowsProg.SatisAli);
            // 
            // showEmployees
            // 
            this.showEmployees.AutoSize = true;
            this.showEmployees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showEmployees.Location = new System.Drawing.Point(703, 521);
            this.showEmployees.Name = "showEmployees";
            this.showEmployees.Size = new System.Drawing.Size(106, 22);
            this.showEmployees.TabIndex = 7;
            this.showEmployees.TabStop = true;
            this.showEmployees.Text = "Show Users";
            this.showEmployees.UseVisualStyleBackColor = true;
            this.showEmployees.CheckedChanged += new System.EventHandler(this.showEmployees_CheckedChanged);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(WindowsProg.Table);
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
            this.usersDataGridView.Location = new System.Drawing.Point(352, 418);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(345, 220);
            this.usersDataGridView.TabIndex = 7;
            this.usersDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn4.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn5.HeaderText = "Username";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn7.HeaderText = "Position";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1002, 675);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.showEmployees);
            this.Controls.Add(this.yaniCalisanLabel);
            this.Controls.Add(this.yeniCalisanEkleButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.queryResultTextBox);
            this.Controls.Add(this.selectQueryComboBox);
            this.Controls.Add(this.satisAlisGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource satisAliBindingSource;
        private System.Windows.Forms.DataGridView satisAlisGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
    }
}
namespace WindowsProg
{
    partial class Masalar
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
            this.cafeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableDataGrid = new System.Windows.Forms.DataGridView();
            this.payButtonMasa = new FontAwesome.Sharp.IconButton();
            this.cafeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cafeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDataGrid
            // 
            this.tableDataGrid.AutoGenerateColumns = false;
            this.tableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tableDataGrid.DataSource = this.cafeTableBindingSource1;
            this.tableDataGrid.Location = new System.Drawing.Point(12, 12);
            this.tableDataGrid.Name = "tableDataGrid";
            this.tableDataGrid.Size = new System.Drawing.Size(444, 192);
            this.tableDataGrid.TabIndex = 0;
            this.tableDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGrid_CellClick);
            // 
            // payButtonMasa
            // 
            this.payButtonMasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButtonMasa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.payButtonMasa.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.payButtonMasa.IconColor = System.Drawing.Color.Violet;
            this.payButtonMasa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.payButtonMasa.Location = new System.Drawing.Point(483, 102);
            this.payButtonMasa.Name = "payButtonMasa";
            this.payButtonMasa.Size = new System.Drawing.Size(101, 102);
            this.payButtonMasa.TabIndex = 9;
            this.payButtonMasa.Text = "Pay";
            this.payButtonMasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.payButtonMasa.UseVisualStyleBackColor = true;
            this.payButtonMasa.Click += new System.EventHandler(this.payButtonMasa_Click);
            // 
            // cafeTableBindingSource1
            // 
            this.cafeTableBindingSource1.DataSource = typeof(WindowsProg.CafeTable);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tableID";
            this.dataGridViewTextBoxColumn1.HeaderText = "tableID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "table_total";
            this.dataGridViewTextBoxColumn2.HeaderText = "table_total";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Masalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.payButtonMasa);
            this.Controls.Add(this.tableDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Masalar";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.Masalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeTableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource cafeTableBindingSource;
        private System.Windows.Forms.BindingSource cafeTableBindingSource1;
        private System.Windows.Forms.DataGridView tableDataGrid;
        private FontAwesome.Sharp.IconButton payButtonMasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
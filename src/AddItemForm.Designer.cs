namespace WindowsProg
{
    partial class AddItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ppuNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ppuLabel = new System.Windows.Forms.Label();
            this.confirmButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppuNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 45);
            this.panel1.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.exitButton.IconColor = System.Drawing.Color.Gainsboro;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 36;
            this.exitButton.Location = new System.Drawing.Point(454, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(24, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimizeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 36;
            this.minimizeButton.Location = new System.Drawing.Point(424, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 23);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.itemNameTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemNameTextBox.Location = new System.Drawing.Point(23, 76);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(228, 26);
            this.itemNameTextBox.TabIndex = 5;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemNameLabel.Location = new System.Drawing.Point(20, 55);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(89, 18);
            this.itemNameLabel.TabIndex = 6;
            this.itemNameLabel.Text = "Item Name";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeLabel.Location = new System.Drawing.Point(20, 125);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(103, 18);
            this.productTypeLabel.TabIndex = 8;
            this.productTypeLabel.Text = "Product Type";
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.productTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Items.AddRange(new object[] {
            "food",
            "drink",
            "dessert"});
            this.productTypeComboBox.Location = new System.Drawing.Point(23, 147);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(228, 26);
            this.productTypeComboBox.TabIndex = 9;
            // 
            // ppuNumericUpDown
            // 
            this.ppuNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ppuNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ppuNumericUpDown.Location = new System.Drawing.Point(23, 214);
            this.ppuNumericUpDown.Name = "ppuNumericUpDown";
            this.ppuNumericUpDown.Size = new System.Drawing.Size(228, 26);
            this.ppuNumericUpDown.TabIndex = 10;
            // 
            // ppuLabel
            // 
            this.ppuLabel.AutoSize = true;
            this.ppuLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ppuLabel.Location = new System.Drawing.Point(20, 193);
            this.ppuLabel.Name = "ppuLabel";
            this.ppuLabel.Size = new System.Drawing.Size(103, 18);
            this.ppuLabel.TabIndex = 11;
            this.ppuLabel.Text = "Price Per Unit";
            // 
            // confirmButton
            // 
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.confirmButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.confirmButton.IconColor = System.Drawing.Color.Black;
            this.confirmButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.confirmButton.Location = new System.Drawing.Point(23, 303);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 53);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(480, 500);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ppuLabel);
            this.Controls.Add(this.ppuNumericUpDown);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppuNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label productTypeLabel;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.NumericUpDown ppuNumericUpDown;
        private System.Windows.Forms.Label ppuLabel;
        private FontAwesome.Sharp.IconButton confirmButton;
    }
}
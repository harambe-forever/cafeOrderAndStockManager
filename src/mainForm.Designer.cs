namespace WindowsProg
{
    partial class mainForm
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
            this.navigatePanel = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.inventoryButton = new FontAwesome.Sharp.IconButton();
            this.tablesButton = new FontAwesome.Sharp.IconButton();
            this.placeOrderButton = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logo = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.navigatePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatePanel
            // 
            this.navigatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.navigatePanel.Controls.Add(this.settingsButton);
            this.navigatePanel.Controls.Add(this.inventoryButton);
            this.navigatePanel.Controls.Add(this.tablesButton);
            this.navigatePanel.Controls.Add(this.placeOrderButton);
            this.navigatePanel.Controls.Add(this.logoPanel);
            this.navigatePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigatePanel.Location = new System.Drawing.Point(0, 0);
            this.navigatePanel.Name = "navigatePanel";
            this.navigatePanel.Size = new System.Drawing.Size(171, 720);
            this.navigatePanel.TabIndex = 1;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.settingsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 36;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 307);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingsButton.Size = new System.Drawing.Size(171, 69);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Ayarlar";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // inventoryButton
            // 
            this.inventoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inventoryButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.inventoryButton.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.inventoryButton.IconColor = System.Drawing.Color.Gainsboro;
            this.inventoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inventoryButton.IconSize = 36;
            this.inventoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryButton.Location = new System.Drawing.Point(0, 238);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.inventoryButton.Size = new System.Drawing.Size(171, 69);
            this.inventoryButton.TabIndex = 3;
            this.inventoryButton.Text = "Envanter";
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // tablesButton
            // 
            this.tablesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablesButton.FlatAppearance.BorderSize = 0;
            this.tablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablesButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.tablesButton.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.tablesButton.IconColor = System.Drawing.Color.Gainsboro;
            this.tablesButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tablesButton.IconSize = 36;
            this.tablesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tablesButton.Location = new System.Drawing.Point(0, 169);
            this.tablesButton.Name = "tablesButton";
            this.tablesButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.tablesButton.Size = new System.Drawing.Size(171, 69);
            this.tablesButton.TabIndex = 2;
            this.tablesButton.Text = "Masalar";
            this.tablesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tablesButton.UseVisualStyleBackColor = true;
            this.tablesButton.Click += new System.EventHandler(this.tablesButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeOrderButton.FlatAppearance.BorderSize = 0;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.placeOrderButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.placeOrderButton.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.placeOrderButton.IconColor = System.Drawing.Color.Gainsboro;
            this.placeOrderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.placeOrderButton.IconSize = 36;
            this.placeOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placeOrderButton.Location = new System.Drawing.Point(0, 100);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.placeOrderButton.Size = new System.Drawing.Size(171, 69);
            this.placeOrderButton.TabIndex = 1;
            this.placeOrderButton.Text = "Siparis";
            this.placeOrderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click_1);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(171, 100);
            this.logoPanel.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.logo.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.logo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.logo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logo.IconSize = 100;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(171, 100);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 45);
            this.panel1.TabIndex = 2;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 7);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 4;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(44, 16);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(75, 16);
            this.lblTitleChildForm.TabIndex = 3;
            this.lblTitleChildForm.Text = "Ana Sayfa";
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
            this.exitButton.Location = new System.Drawing.Point(1003, 0);
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
            this.minimizeButton.Location = new System.Drawing.Point(973, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(24, 23);
            this.minimizeButton.TabIndex = 0;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(171, 45);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1029, 675);
            this.panelDesktop.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navigatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.navigatePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigatePanel;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton inventoryButton;
        private FontAwesome.Sharp.IconButton tablesButton;
        private FontAwesome.Sharp.IconButton placeOrderButton;
        private System.Windows.Forms.Panel logoPanel;
        private FontAwesome.Sharp.IconPictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private System.Windows.Forms.Panel panelDesktop;
    }
}
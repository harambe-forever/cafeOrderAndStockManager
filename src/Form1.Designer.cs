﻿namespace WindowsProg
{
    partial class loginPage
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
            this.textGroup = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.textGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // textGroup
            // 
            this.textGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textGroup.Controls.Add(this.passwordLabel);
            this.textGroup.Controls.Add(this.idLabel);
            this.textGroup.Controls.Add(this.passwordTextBox);
            this.textGroup.Controls.Add(this.idTextBox);
            this.textGroup.Location = new System.Drawing.Point(12, 94);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(440, 146);
            this.textGroup.TabIndex = 0;
            this.textGroup.TabStop = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordLabel.Location = new System.Drawing.Point(13, 95);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 18);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idLabel.Location = new System.Drawing.Point(12, 48);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(86, 18);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordTextBox.Location = new System.Drawing.Point(98, 90);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(230, 30);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.idTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idTextBox.Location = new System.Drawing.Point(98, 43);
            this.idTextBox.Multiline = true;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(230, 30);
            this.idTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(185, 246);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(155, 60);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.Location = new System.Drawing.Point(13, 47);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 18);
            this.timeLabel.TabIndex = 2;
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textGroup);
            this.Name = "loginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginPage_Load);
            this.textGroup.ResumeLayout(false);
            this.textGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox textGroup;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
    }
}


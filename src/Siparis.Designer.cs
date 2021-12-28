namespace CafeStokSatisTakip
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
            this.checkoutPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkoutPanel
            // 
            this.checkoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkoutPanel.Location = new System.Drawing.Point(600, 0);
            this.checkoutPanel.Name = "checkoutPanel";
            this.checkoutPanel.Size = new System.Drawing.Size(200, 450);
            this.checkoutPanel.TabIndex = 1;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Siparis";
            this.Text = "Siparis";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel checkoutPanel;
    }
}
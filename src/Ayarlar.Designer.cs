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
            this.satisAliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisAlisGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // satisAliBindingSource
            // 
            this.satisAliBindingSource.DataSource = typeof(WindowsProg.SatisAli);
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
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.satisAlisGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisAliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisAlisGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource satisAliBindingSource;
        private System.Windows.Forms.DataGridView satisAlisGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
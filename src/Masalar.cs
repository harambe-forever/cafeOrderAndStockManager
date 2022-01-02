using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProg
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
        }

        private WindowsProg.UserDataEntitiesMasalar dbMasalar = new WindowsProg.UserDataEntitiesMasalar();
        private void Masalar_Load(object sender, EventArgs e)
        {
            dbMasalar.CafeTables
                .Load();

            cafeTableBindingSource1.DataSource = dbMasalar.CafeTables.Local;
        }

        private void tableDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void payButtonMasa_Click(object sender, EventArgs e)
        {
            makePayment(tableDataGrid);
        }

        private void makePayment(DataGridView dataGridName)
        {
            if (dataGridName.CurrentCell.RowIndex >= 0)
            {
                DataGridViewRow row = tableDataGrid.Rows[dataGridName.CurrentCell.RowIndex];
                row.Cells[1].Value = 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProg
{
    public partial class removeItemForm : Form
    {
        public removeItemForm()
        {
            InitializeComponent();
            productDataGridLoad();
        }
        private WindowsProg.UserDataEntities2 dbProducts = new WindowsProg.UserDataEntities2();

        private void productDataGridLoad()
        {
            var queryProducts = from prod in dbProducts.Products
                             select prod;
            productDataGridView.DataSource = queryProducts.ToList();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeItems()
        {
            int rowIndex = productDataGridView.CurrentCell.RowIndex;
            DataGridViewRow row = productDataGridView.Rows[rowIndex];
            string productName = row.Cells[0].Value.ToString();
            var deletos = from product in dbProducts.Products
                          where product.ProductName == productName
                          select product;
            foreach(var delet in deletos)
            {
                dbProducts.Products.Remove(delet);
            }
            dbProducts.SaveChanges();
            productDataGridLoad();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            removeItems();
        }
    }
}

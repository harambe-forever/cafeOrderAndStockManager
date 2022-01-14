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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }
        private WindowsProg.UserDataEntities2 dbProducts = new WindowsProg.UserDataEntities2();

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            dbProducts.Products.Add(new Product()
            {
                inStock = 0,
                PricePerUnit = ppuNumericUpDown.Value,
                ProductName = itemNameTextBox.Text,
                ProductType = productTypeComboBox.SelectedItem.ToString()
            });
            dbProducts.SaveChanges();
            MessageBox.Show("Item Added Successfully");
        }
    }
}

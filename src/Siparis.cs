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
    public partial class Siparis : Form
    {
        public Siparis()
        {
            InitializeComponent();
        }

        private WindowsProg.UserDataEntities2 dbcontext = new WindowsProg.UserDataEntities2();

        private void Siparis_Load(object sender, EventArgs e)
        {
            foodLoad();
            drinkLoad();
            dessertLoad();
        }

        private void foodLoad()
        {
            var queryFood = from food in dbcontext.Products
                            where food.ProductType == "food"
                            select food;
            foodGrid.DataSource = queryFood.ToList();
        }

        private void drinkLoad()
        {
            var queryDrink = from drink in dbcontext.Products
                             where drink.ProductType == "drink"
                             select drink;
            drinkGrid.DataSource = queryDrink.ToList();
        }

        private void dessertLoad()
        {
            var queryDessert = from dessert in dbcontext.Products
                               where dessert.ProductType == "dessert"
                               select dessert;
            dessertGrid.DataSource = queryDessert.ToList();
        }

        private void gridCellClick(DataGridView gridName, TextBox nameTextBox, TextBox priceTextBox, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridName.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells[0].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }
        private void foodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Quantity.Value = 1;
            gridCellClick(foodGrid, foodNameTextBox, priceTextBox, e);        
        }
        private void drinkGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            drinkQuantity.Value = 1;
            gridCellClick(drinkGrid, drinkNameTextBox, drinkPriceTextBox, e);
        }
        private void dessertGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dessertQuantity.Value = 1;
            gridCellClick(dessertGrid, dessertNameTextBox, dessertPriceTextBox, e);
        }

        

        private void qttChg(TextBox textBoxName, DataGridView dataGridName, int qtt, int previousValue)
        {
            int price = Int16.Parse(textBoxName.Text);
            int temp;
            int row = dataGridName.CurrentCell.RowIndex;
            DataGridViewRow row2 = dataGridName.Rows[row];
            temp = Int16.Parse(row2.Cells[2].Value.ToString());
            if(qtt > previousValue)
            {
                price += temp;
                textBoxName.Text = price.ToString();
            }else if(qtt < previousValue)
            {
                price -= temp;
                textBoxName.Text = price.ToString();
            }
            previousValue = qtt;
            
            switch (dataGridName.Name.ToString())
            {
                case "foodGrid":
                    prevValue = previousValue;
                    break;
                case "drinkGrid":
                    prevVal = previousValue;
                    break;
                case "dessertGrid":
                    prev = previousValue;
                    break;

            }
        }

        int prevValue = 0;
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {      
            qttChg(priceTextBox, foodGrid, (int)Quantity.Value, prevValue);
        }

        int prevVal = 0;
        private void drinkQuantity_ValueChanged(object sender, EventArgs e)
        {
            qttChg(drinkPriceTextBox, drinkGrid, (int)drinkQuantity.Value, prevVal);
        }

        int prev = 0;
        private void dessertQuantity_ValueChanged(object sender, EventArgs e)
        {
            qttChg(dessertPriceTextBox, dessertGrid, (int)dessertQuantity.Value, prev);
        }

        private void toTableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tableGroupBox.Visible = toTableRadioButton.Checked;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (takeawayRadioButton.Checked)
            {
                var query = from foodOrder in dbcontext.Products
                            where foodOrder.ProductName == foodNameTextBox.Text
                            select foodOrder;

                foreach(Product fOrder in query)
                {
                    fOrder.inStock -= (int)Quantity.Value;
                }

                dbcontext.SaveChanges();

                this.Refresh();
            }
        }
    }
}

    


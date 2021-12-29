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

        private void foodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = foodGrid.Rows[e.RowIndex];
                foodNameTextBox.Text = row.Cells[0].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();
            }            
        }

        int prevValue = 0;
        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            int price = Int16.Parse(priceTextBox.Text);
            int temp;
            int row = foodGrid.CurrentCell.RowIndex;
            DataGridViewRow row2 = foodGrid.Rows[row];
            temp = Int16.Parse(row2.Cells[2].Value.ToString());
            if (Quantity.Value > prevValue)
            {
                price += temp;
                priceTextBox.Text = price.ToString();
            }else if(Quantity.Value < prevValue)
            {
                price -= temp;
                priceTextBox.Text = price.ToString();
            }
            prevValue = (int)Quantity.Value;
        }

        private void drinkGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = drinkGrid.Rows[e.RowIndex];
                drinkNameTextBox.Text = row.Cells[0].Value.ToString();
                drinkPriceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }

        int prevVal = 0;
        private void drinkQuantity_ValueChanged(object sender, EventArgs e)
        {
            int price = Int16.Parse(drinkPriceTextBox.Text);
            int temp;
            int row = drinkGrid.CurrentCell.RowIndex;
            DataGridViewRow row2 = drinkGrid.Rows[row];
            temp = Int16.Parse(row2.Cells[2].Value.ToString());
            if (drinkQuantity.Value > prevVal)
            {
                price += temp;
                drinkPriceTextBox.Text = price.ToString();
            }
            else if (drinkQuantity.Value < prevVal)
            {
                price -= temp;
                drinkPriceTextBox.Text = price.ToString();
            }
            prevVal = (int)drinkQuantity.Value;
        }

        private void dessertGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dessertGrid.Rows[e.RowIndex];
                dessertNameTextBox.Text = row.Cells[0].Value.ToString();
                dessertPriceTextBox.Text = row.Cells[2].Value.ToString();
            }
        }

        int prev = 0;
        private void dessertQuantity_ValueChanged(object sender, EventArgs e)
        {
            int price = Int16.Parse(dessertPriceTextBox.Text);
            int temp;
            int row = dessertGrid.CurrentCell.RowIndex;
            DataGridViewRow row2 = dessertGrid.Rows[row];
            temp = Int16.Parse(row2.Cells[2].Value.ToString());
            if (dessertQuantity.Value > prev)
            {
                price += temp;
                dessertPriceTextBox.Text = price.ToString();
            }
            else if (dessertQuantity.Value < prev)
            {
                price -= temp;
                dessertPriceTextBox.Text = price.ToString();
            }
            prev = (int)dessertQuantity.Value;
        }
    }
}

    


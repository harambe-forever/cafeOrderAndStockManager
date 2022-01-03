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
    public partial class Envanter : Form
    {
        public Envanter()
        {
            InitializeComponent();
        }

        int id;
        private WindowsProg.UserDataEntities2 dbcontext = new WindowsProg.UserDataEntities2();
        private WindowsProg.UserDataEntitiesDelivery dbDelivery = new WindowsProg.UserDataEntitiesDelivery();
        private void Envanter_Load(object sender, EventArgs e)
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

        private void orderNowButton_CheckedChanged(object sender, EventArgs e)
        {
            orderButton.Show();
            dateTimePicker.Hide();
        }

        private void furtherDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            orderButton.Show();
            dateTimePicker.Show();
        }
        /*
         QUANTITY FALAN DA EKLIYCEN MK HAYATTA UGRASMAZSIN BUNLA AKSAM AKSAM
         */
        private void orderButton_Click(object sender, EventArgs e)
        {
            dbDelivery.Deliveries.Add(new Delivery()
            {
                deliveryID = id
            });
            id += 1;
        }

        private void qtt(DataGridView dataGridName, NumericUpDown quantityName, int quantity)
        {
            int cost = Int16.Parse(textBox1.Text);
            int row = dataGridName.CurrentCell.RowIndex;
            DataGridViewRow row2 = dataGridName.Rows[row];
            int ppu; //price per unit
            ppu = Int16.Parse(row2.Cells[2].Value.ToString());
            if(quantityName.Value > quantity)
            {
                //cost += (ppu * (int)quantityName.Value);
                cost += ppu;
            }
            else if (quantityName.Value < quantity)
            {
                cost -= (ppu);
            }
            quantity = (int)quantityName.Value;

            switch (dataGridName.Name.ToString())
            {
                case "foodGrid":
                    oldQttForFood = quantity;
                    break;
                case "drinkGrid":
                    oldQttForDrink = quantity;
                    break;
                case "dessertGrid":
                    oldQttForDessert = quantity;
                    break;
            }
            textBox1.Text = cost.ToString();
        }

        int oldQttForFood = 0;
        private void foodQuantity_ValueChanged(object sender, EventArgs e)
        {
            qtt(foodGrid, foodQuantity, oldQttForFood);
        }

        int oldQttForDrink = 0;
        private void drinkQuantity_ValueChanged(object sender, EventArgs e)
        {
            qtt(drinkGrid, drinkQuantity, oldQttForDrink);
        }

        int oldQttForDessert = 0;
        private void dessertQuantity_ValueChanged(object sender, EventArgs e)
        {
            qtt(dessertGrid, dessertQuantity, oldQttForDessert);
        }
    }
}

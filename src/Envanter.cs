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

        private static int randomIDGenerator()
        {
            Random rnd = new Random();
            int randId = rnd.Next(1000);
            return randId;
        }

        int id = randomIDGenerator();
        int cost;
        private WindowsProg.UserDataEntities2 dbcontext = new WindowsProg.UserDataEntities2();
        private WindowsProg.UserDataEntitiesDelivery dbDelivery = new WindowsProg.UserDataEntitiesDelivery();
        private void Envanter_Load(object sender, EventArgs e)
        {
            foodLoad();
            drinkLoad();
            dessertLoad();
            deliveryLoad();
        }

        private void deliveryLoad()
        {
            var queryDeliveries = from delivery in dbDelivery.Deliveries
                                  select delivery;
            deliveryGrid.DataSource = queryDeliveries.ToList();
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
        private void orderButton_Click(object sender, EventArgs e)
        {
            
            var ID = from iddd in dbDelivery.Deliveries
                     select iddd.deliveryID;
            textBox1.Text = id.ToString();
            dbDelivery.Deliveries.Add(new Delivery()
            {
                deliveryID = id,
                Will_Order_At = DateTime.Now,
                Expected_Delivery_Date = DateTime.Now,
                Cost = cost
            });
            id += 1;
            dbDelivery.SaveChanges();
            deliveryGrid.Refresh();
            this.Refresh();         
        }


        /* 
         Cell degtistirecegin zaman sifirlayip degistirmen gerekiyor
        */
        private void qtt(DataGridView dataGridName, NumericUpDown quantityName, int quantity)
        {
            cost = Int16.Parse(textBox1.Text);
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

        private void deliveryGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = deliveryGrid.CurrentCell.RowIndex;
            DataGridViewRow row2 = deliveryGrid.Rows[row];
            int rowID = (int)row2.Cells[0].Value;
            var deletos = from delivered in dbDelivery.Deliveries
                          where delivered.deliveryID == rowID
                          select delivered;
            foreach(var delete in deletos)
            {
                dbDelivery.Deliveries.Remove(delete);
            }
            dbDelivery.SaveChanges();
            this.Refresh();
        }
    }
}

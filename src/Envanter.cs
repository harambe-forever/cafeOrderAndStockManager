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

        int id = 0;
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
         QUANTITY FALAN DA EKLIYCEN MK HAYATTA UGRASMAZDIN BUNLA AKSAM AKSAM
         */
        private void orderButton_Click(object sender, EventArgs e)
        {
            dbDelivery.Deliveries.Add(new Delivery()
            {
                deliveryID = id
            });
            id += 1;
        }
    }
}

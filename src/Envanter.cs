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

        
        private static int randomIntGenerator(int len)
        {
            Random rnd = new Random();
            int randId = rnd.Next(len);
            return randId;
        }

        int id = randomIntGenerator(1000);
        int cost;
        private WindowsProg.UserDataEntities2 dbcontext = new WindowsProg.UserDataEntities2();
        private WindowsProg.UserDataEntitiesDelivery dbDelivery = new WindowsProg.UserDataEntitiesDelivery();
        private WindowsProg.SatisAlisEntity dbSatisAlis = new WindowsProg.SatisAlisEntity();
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
            DateTime dt = new DateTime();
            dt = dateTimePicker.Value;
            orderButton.Show();
            dateTimePicker.Show();
        }

        private void addItems(DataGridView dataGridName, NumericUpDown amount)
        {
            int row = dataGridName.CurrentCell.RowIndex;
            DataGridViewRow row2 = dataGridName.Rows[row];
            string productName = row2.Cells[0].Value.ToString();
            int inStock = Int16.Parse(row2.Cells[1].Value.ToString());
            inStock += (int)amount.Value;

            var eklenecek = from urun in dbcontext.Products
                            where urun.ProductName == productName
                            select urun;
            foreach(Product p in eklenecek)
            {
                p.inStock = inStock;
            }
            dbcontext.SaveChanges();
            this.Refresh();

            int ppu = Int16.Parse(row2.Cells[2].Value.ToString());
            ppu = (ppu - ((ppu * 25) / 100)) * (int)amount.Value;

            if(amount.Value > 0)
            {
                var qry1 = dbSatisAlis.SatisAlis.Where(x => x.Urun_Adi == productName).FirstOrDefault();
                if(qry1 != null)
                {
                    qry1.Alis += ppu;
                }
                else
                {
                    dbSatisAlis.SatisAlis.Add(new SatisAli()
                    {
                        Urun_Adi = productName,
                        Satis = 0,
                        Alis = ppu
                    });
                }
            }
            dbSatisAlis.SaveChanges();

        }
        private void orderButton_Click(object sender, EventArgs e)
        {
            addItems(foodGrid, foodQuantity);
            addItems(drinkGrid, drinkQuantity);
            addItems(dessertGrid, dessertQuantity);

            dbDelivery.Deliveries.Add(new Delivery()
            {
                deliveryID = id,
                Will_Order_At = dateTimePicker.Value,
                Expected_Delivery_Date = dateTimePicker.Value.AddDays(randomIntGenerator(7)),
                Cost = cost
            });
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
            ppu = ppu - ((ppu * 25) / 100);
            if(quantityName.Value > quantity)
            {
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

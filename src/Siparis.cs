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
        private WindowsProg.UserDataEntitiesMasalar dbMasalar = new WindowsProg.UserDataEntitiesMasalar();
        private WindowsProg.SatisAlisEntity dbSatisAlis = new WindowsProg.SatisAlisEntity();

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
            payButton.Hide();
            saveTableButton.Show();
        }
        private void takeawayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            payButton.Show();
            saveTableButton.Hide();
        }


        private void satisUpdate(TextBox textBoxName, TextBox priceTB, NumericUpDown amount)
        {
            if(amount.Value > 0)
            {
                var qry1 = dbSatisAlis.SatisAlis.Where(x => x.Urun_Adi == textBoxName.Text).FirstOrDefault();
                if (qry1 != null)
                {
                    qry1.Satis += Int16.Parse(priceTB.Text);
                }
                else
                {
                    dbSatisAlis.SatisAlis.Add(new SatisAli()
                    {
                        Urun_Adi = textBoxName.Text,
                        Satis = Int16.Parse(priceTB.Text),
                        Alis = 0
                    });
                }
            }
            dbSatisAlis.SaveChanges();

        }
        private void stockUpdate()
        {
            var query = from foodOrder in dbcontext.Products
                        where foodOrder.ProductName == foodNameTextBox.Text
                        select foodOrder;

            foreach (Product fOrder in query)
            {
                fOrder.inStock -= (int)Quantity.Value;
            }

            satisUpdate(foodNameTextBox, priceTextBox, Quantity);

            var query2 = from drinkOrder in dbcontext.Products
                         where drinkOrder.ProductName == drinkNameTextBox.Text
                         select drinkOrder;
            foreach (Product dOrder in query2)
            {
                dOrder.inStock -= (int)drinkQuantity.Value;
            }

            satisUpdate(drinkNameTextBox, drinkPriceTextBox, drinkQuantity);

            var query3 = from dessertOrder in dbcontext.Products
                         where dessertOrder.ProductName == dessertNameTextBox.Text
                         select dessertOrder;

            foreach (Product dsOrder in query3)
            {
                dsOrder.inStock -= (int)dessertQuantity.Value;
            }

            satisUpdate(dessertNameTextBox, dessertPriceTextBox, dessertQuantity);

            dbcontext.SaveChanges();
        }

        private void payButton_Click(object sender, EventArgs e)
        {

            if (takeawayRadioButton.Checked)
            {
                stockUpdate();
                this.Refresh();
                MessageBox.Show("Payment successful, payment amount: " + 
                    (Int16.Parse(priceTextBox.Text) + Int16.Parse(drinkPriceTextBox.Text) + Int16.Parse(dessertPriceTextBox.Text)) + 
                    " bucks.");
            }
            else
            {
                MessageBox.Show("You need to specify table or takeout!");                     
            }
        }

        private void saveTableButton_Click(object sender, EventArgs e)
        {
            stockUpdate();

            var checkedButton = tableGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if(checkedButton == null)
            {
                MessageBox.Show("Ooops, Please Choose a Table!");
            }
            else
            {
                string tableID = checkedButton.Text;
                var query4 = from masaData in dbMasalar.CafeTables
                             where masaData.tableID == tableID
                             select masaData;

                foreach (CafeTable tab in query4)
                {
                    tab.table_total += (Int16.Parse(priceTextBox.Text) + Int16.Parse(drinkPriceTextBox.Text) + Int16.Parse(dessertPriceTextBox.Text));
                }
            }

            dbMasalar.SaveChanges();
            this.Refresh();
        }

        
    }
}

    


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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }
        private WindowsProg.SatisAlisEntity dbSatisAlis = new WindowsProg.SatisAlisEntity();
        private WindowsProg.UserDataEntities dbUserData = new WindowsProg.UserDataEntities();


        private void Ayarlar_Load(object sender, EventArgs e)
        {
            satisAlisGridLoad();
            usersDataGridLoad();
        }

        private void usersDataGridLoad()
        {
            var queryUsers = from user in dbUserData.Tables
                             select user;
            usersDataGridView.DataSource = queryUsers.ToList();
        }
        private void satisAlisGridLoad()
        {
            var querySatisAlis = from liste in dbSatisAlis.SatisAlis
                                  select liste;
            satisAlisGrid.DataSource = querySatisAlis.ToList();
        }

        private void queryle(int comboBoxIndex)
        {
            switch (comboBoxIndex)
            {
                case 0:
                    q0(satisAlisGrid);
                    break;
                case 1:
                    q1(satisAlisGrid);
                    break;
            }
        }

        private void q1(DataGridView dataGridName)
        {
            int count = dataGridName.Rows.Count;
            int urunSatis = 0;
            int urunAlis = 0;
            DataGridViewRow currentRow;
            for (int i = 0; i < count; i++)
            {
                currentRow = dataGridName.Rows[i];
                urunSatis += Int16.Parse(currentRow.Cells[1].Value.ToString());
                urunAlis += Int16.Parse(currentRow.Cells[2].Value.ToString());
            }
            int kar_zarar = urunSatis - urunAlis;
            string hmm;
            if (kar_zarar > 0)
            {
                hmm = " tl profit made";
            }
            else if (kar_zarar < 0)
            {
                hmm = " tl money lost";
            }
            else
            {
                hmm = " tl so nothing changed";
            }
            queryResultTextBox.Text = "Totally: " + kar_zarar.ToString() + hmm;
        }

        private void q0(DataGridView dataGridName)
        {
            int currentRowIndex = dataGridName.CurrentCell.RowIndex;
            DataGridViewRow currentRow = dataGridName.Rows[currentRowIndex];

            string urunAdi = currentRow.Cells[0].Value.ToString();
            int urunSatis = Int16.Parse(currentRow.Cells[1].Value.ToString());
            int urunAlis = Int16.Parse(currentRow.Cells[2].Value.ToString());
            int kar_zarar = urunSatis - urunAlis;
            string hmm;
            if(kar_zarar > 0)
            {
                hmm = " tl profit made";
            }else if(kar_zarar < 0)
            {
                hmm = " tl money lost";
            }else
            {
                hmm = " tl so nothing changhed";
            }

            queryResultTextBox.Text = "Product Name: " + urunAdi + 
                Environment.NewLine + "Totally: " + kar_zarar.ToString() + hmm;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int index = selectQueryComboBox.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("No such query??");
                queryResultTextBox.Text = "Oops. Looks like you made a mistake.";
            }
            else
            {
                selectQueryComboBox.SelectedIndex = index;
            }

            queryle(index);
        }

        private void yeniCalisanEkleButton_Click(object sender, EventArgs e)
        {
            AddUserForm newUser = new AddUserForm();
            newUser.Show();
        }

        private void showEmployees_CheckedChanged(object sender, EventArgs e)
        {
            usersDataGridView.Show();
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm newItem = new AddItemForm();
            newItem.Show();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            removeItemForm removeItem = new removeItemForm();
            removeItem.Show();
        }
    }
}

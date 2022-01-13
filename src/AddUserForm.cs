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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private WindowsProg.UserDataEntities dbUserData = new WindowsProg.UserDataEntities();

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static int randomIntGenerator(int len)
        {
            Random rnd = new Random();
            int randId = rnd.Next(len);
            return randId;
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            dbUserData.Tables.Add(new Table()
            {
                Password = passwordTextBox.Text,
                Position = positionComboBox.SelectedItem.ToString(),
                UserID = randomIntGenerator(100),
                Username = usernameTextBox.Text
            });
            dbUserData.SaveChanges();
            MessageBox.Show("User Added Successfully");
        }
    }
}

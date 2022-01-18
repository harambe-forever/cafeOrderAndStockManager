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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private WindowsProg.UserDataEntities dbcont = new WindowsProg.UserDataEntities();

        private void loginPage_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToString();
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton.PerformClick();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidUser(idTextBox.Text, passwordTextBox.Text))
            {
                mainForm mainF = new mainForm();
                mainF.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check Username or Password");
            }
            /*mainForm mainF = new mainForm();
            mainF.Show();*/
        }

        private bool isValidUser(string userName, string password)
        {
            var q = from p in dbcont.Tables
                    where p.Username == idTextBox.Text && p.Password == passwordTextBox.Text
                    select p;

            if (q.Any())
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

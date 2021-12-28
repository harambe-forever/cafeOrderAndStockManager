using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeStokSatisTakip
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gokbe\Documents\data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                
                if (dt.Rows[i][i].ToString() == "1")
                {
                    main mainform = new main();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Check Username or Password");
                }
            }
            
            
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.timeLabel.Text = DateTime.Now.ToString();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loginButton.PerformClick();
        }
    }
}

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


        private void Ayarlar_Load(object sender, EventArgs e)
        {
            satisAlisGridLoad();
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
            }
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
                hmm = " tl kar";
            }else if(kar_zarar < 0)
            {
                hmm = " tl zarar";
            }else
            {
                hmm = " tl yani değişiklik yok";
            }

            queryResultTextBox.Text = "Ürün adı: " + urunAdi + 
                Environment.NewLine + "Kar-zarar miktarı: " + kar_zarar.ToString() + hmm;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int index = selectQueryComboBox.SelectedIndex;
            if(index < 0)
            {
                MessageBox.Show("Böyle bir sorgu bulunamadı??");
                queryResultTextBox.Text = "Oops. Bir hata yaptın sanki";
            }
            else
            {
                selectQueryComboBox.SelectedIndex = index;
            }

            queryle(index);
        }
    }
}

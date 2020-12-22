using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_kebutuhanData
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();

        }
        public void insertTable(string jenisData,string kodeData,string levelData,string periodeData,string sumberInformasi,string lengkapData,string akurasiData,string mutakhirData)
        {
            
            tabelData_blok2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tabelData_blok2.Controls.Add(new Label() { Text = i.ToString() ,AutoSize=true}, 0, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = jenisData, AutoSize = true }, 1, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = kodeData, AutoSize = true }, 2, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = levelData, AutoSize = true }, 3, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = periodeData, AutoSize = true }, 4, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = sumberInformasi, AutoSize = true }, 5, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = lengkapData, AutoSize = true }, 6, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = akurasiData, AutoSize = true }, 7, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = mutakhirData, AutoSize = true }, 8, tabelData_blok2.RowCount - 1);
            tabelData_blok2.RowCount = tabelData_blok2.RowCount + 1;
            i++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            insertData idt = new insertData(this);
            idt.ShowDialog();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Buat Variabel dan Validasi Blok I

            // Buat Variabel dan Validasi Blok II

            // Buat Variabel dan Validasi Blok III

        }
    }
}

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
        public void insertTable(string jenisData, string kodeData, string levelData, string periodeData, string sumberInformasi, string lengkapData, string akurasiData, string mutakhirData)
        {

            tabelData_blok2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tabelData_blok2.Controls.Add(new Label() { Text = i.ToString(), AutoSize = true }, 0, tabelData_blok2.RowCount - 1);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
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

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Oke", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                // Buat objek Blok I
                Blok1Model blok1 = new Blok1Model();
                blok1.nama = blok1_nama.Text;
                blok1.umur = Convert.ToInt16(blok1_tahunLahir.Text);
                blok1.pendidikan = blok1_pendidikan.Text;
                blok1.jenisInstitusi = blok1_kategoriInstitusi.Text;

                blok1.institusi = blok1_institusi.Text;
                blok1.jeniskelamin = blok1_jenisKelamin.Text;
                blok1.layanan = blok1_layanan.Text;
                blok1.tujuan = blok1_manfaat.Text;

                // buat Objek BLok II


            }
            
            // Buat Variabel dan Validasi Blok I

            // Buat Variabel dan Validasi Blok II

            // Buat Variabel dan Validasi Blok III

        }

        private void blok1_nama_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_nama.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_nama.Focus();
                errorProvider1.SetError(blok1_nama, "Nama harus diisi !");
            }
            else if (blok1_nama.Text.Length < 3)
            {
                e.Cancel = true;
                blok1_nama.Focus();
                errorProvider1.SetError(blok1_nama, "Nama harus lebih dari 2 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_nama, null);


            }
        }

        

        private void blok1_jenisKelamin_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_jenisKelamin.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_jenisKelamin.Focus();
                errorProvider1.SetError(blok1_jenisKelamin, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_jenisKelamin, "");
            }
        }

        private void blok1_pendidikan_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_pendidikan.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_pendidikan.Focus();
                errorProvider1.SetError(blok1_pendidikan, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_jenisKelamin, "");
            }
        }

        private void blok1_institusi_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_institusi.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama harus diisi !");
            }
            else if (blok1_institusi.Text.Length < 3)
            {

                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama harus lebih dari 2 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_institusi, "");


            }
        }

        private void blok1_layanan_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_layanan.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_layanan.Focus();
                errorProvider1.SetError(blok1_layanan, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_layanan, "");
            }
        }

        private void blok1_tujuan_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_manfaat.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_manfaat.Focus();
                errorProvider1.SetError(blok1_manfaat, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_manfaat, "");
            }
        }

        private void blok1_jenisInstitusi_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_kategoriInstitusi.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_kategoriInstitusi.Focus();
                errorProvider1.SetError(blok1_kategoriInstitusi, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_kategoriInstitusi, "");
            }
        }

        private void blok1_tahunLahir_Validating(object sender, CancelEventArgs e)
        { int tahunLahir;
            if (int.TryParse(blok1_tahunLahir.Text,out tahunLahir))
            {
                if ( tahunLahir < 1920 || tahunLahir > DateTime.Now.Year)
                {

                    e.Cancel = true;
                    blok1_tahunLahir.Focus();
                    errorProvider1.SetError(blok1_tahunLahir, $"Tahun Lahir harus diantara 1920 sampai {DateTime.Now.Year}");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(blok1_tahunLahir, null);
                }
            }
            else
            {
                e.Cancel = true;
                blok1_tahunLahir.Focus();
                errorProvider1.SetError(blok1_tahunLahir, "Format tahun tidak valid");
            }
            
        }

        private void blok2_puas_q1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            insertData idx = new insertData(this);
            idx.Show();
        }
    }
}
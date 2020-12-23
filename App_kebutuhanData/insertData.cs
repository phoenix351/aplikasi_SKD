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
    public partial class insertData : Form
    {
        Form1 form;
        private int angka;

        public insertData(Form1 form1)
        {
            InitializeComponent();
            form = form1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // variabel ambil data dari form

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Data ditambahkan !","Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Blok2Model blok2 = new Blok2Model();
                blok2.jenisData = blok3_insert_jenisData.Text;
                blok2.kodeData = blok3_insert_kodeData.Text;
                blok2.levelData = blok3_insert_levelData.Text;
                blok2.periodeData = blok3_insert_periodeData.Text;
                blok2.sumberInformasi = blok3_insert_judulSumber.Text;
                blok2.lengkapData = blok3_insert_lengkapData.Text;
                blok2.akurasiData = blok3_insert_akurasiData.Text;
                blok2.mutakhirData = blok3_insert_mutakhirData.Text;

                form.insertTable(blok2.jenisData, blok2.kodeData, blok2.levelData, blok2.periodeData, blok2.sumberInformasi, blok2.lengkapData, blok2.akurasiData, blok2.mutakhirData);

            }



            // validasi form 

            // insert variabel ke tabel form parent


            
            
            

            // tutup dialog
            //this.Close();
        }

        private void jenisData_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_jenisData.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_jenisData.Focus();
                errorProvider1.SetError(blok3_insert_jenisData, "Variabel ini harus diisi");
            } else if(blok3_insert_jenisData.Text.Length < 10)
            {
                e.Cancel = true;
                blok3_insert_jenisData.Focus();
                errorProvider1.SetError(blok3_insert_jenisData, "Panjang karakter harus lebih dari 9 karakter");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_jenisData, null);
            }
        }

        private void kodeData_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_kodeData.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_kodeData.Focus();
                errorProvider1.SetError(blok3_insert_kodeData, "Variabel ini harus diisi");
            }
            else if (blok3_insert_kodeData.Text.Length != 2)
            {
                e.Cancel = true;
                blok3_insert_kodeData.Focus();
                errorProvider1.SetError(blok3_insert_kodeData, "Panjang karakter harus 2 karakter");

            }
            else
            {
                if (Int32.TryParse(blok3_insert_kodeData.Text,out angka))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(blok3_insert_kodeData, null);
                }
                else
                {
                    e.Cancel = true;
                    blok3_insert_kodeData.Focus();
                    errorProvider1.SetError(blok3_insert_kodeData, "Kode tidak Valid");
                }
                
            }
        }

        private void levelData_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_levelData.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_levelData.Focus();
                errorProvider1.SetError(blok3_insert_levelData, "Variabel ini harus diisi");
            }
            else if (blok3_insert_levelData.Text.Length < 5)
            {
                e.Cancel = true;
                blok3_insert_levelData.Focus();
                errorProvider1.SetError(blok3_insert_levelData, "Panjang karakter harus lebih dari 4 karakter");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_levelData, null);
            }
        }

        private void periodeData_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_periodeData.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_periodeData.Focus();
                errorProvider1.SetError(blok3_insert_periodeData, "Variabel ini harus diisi");
            }
            else if (blok3_insert_periodeData.Text.Length < 5)
            {
                e.Cancel = true;
                blok3_insert_periodeData.Focus();
                errorProvider1.SetError(blok3_insert_periodeData, "Panjang karakter harus lebih dari 4 karakter");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_periodeData, null);
            }
        }

        private void sumberInformasi_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_judulSumber.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_judulSumber.Focus();
                errorProvider1.SetError(blok3_insert_judulSumber, "Variabel ini harus diisi");
            }
            else if (blok3_insert_judulSumber.Text.Length < 5)
            {
                e.Cancel = true;
                blok3_insert_judulSumber.Focus();
                errorProvider1.SetError(blok3_insert_judulSumber, "Panjang karakter harus lebih dari 4 karakter");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_judulSumber, null);
            }
        }
        public void validasiDPList(ComboBox boks, CancelEventArgs e)
        {
            if (boks.SelectedIndex == -1)
            {
                e.Cancel = true;
                boks.Focus();
                errorProvider1.SetError(boks, "Harus memilih salah satu !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(boks, null);
            }
        }
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_perolehData.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok3_insert_perolehData.Focus();
                errorProvider1.SetError(blok3_insert_perolehData, "Harus memilih salah satu !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_perolehData, null);
            }
        }

      
       
    }
}

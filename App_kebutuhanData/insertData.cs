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
            blok3_insert_jenisData.Text = "Luas Wilayah Pertanian";
            blok3_insert_tahunData.Text = "2009";
            blok3_insert_levelData.Text = "Kabupaten";
            blok3_insert_perolehData.SelectedIndex = 1;
            blok3_insert_judulSumber.Text = "Banyumas dalam Angka";
            blok3_insert_tahunSumber.Text = "2009";
            blok3_insert_jenisSumber.SelectedIndex = 1;
            blok3_insert_lengkapData.Value = 7;
            blok3_insert_akurasiData.Value = 8;
            blok3_insert_mutakhirData.Value = 6;
            blok3_insert_kualitasData.Value = 9;
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
                Blok3Model blok3 = new Blok3Model();
                blok3.jenisData = blok3_insert_jenisData.Text;
                blok3.tahunData = Convert.ToInt16(blok3_insert_tahunData.Text);
                blok3.levelData = blok3_insert_levelData.Text;
                blok3.periodeData = blok3_insert_periodeData.Text;
                blok3.perolehData = blok3_insert_perolehData.SelectedIndex +1;
                blok3.judulSumber = blok3_insert_judulSumber.Text;
                blok3.jenisSumber = blok3_insert_jenisSumber.SelectedIndex + 1;
                blok3.tahunSumber = Convert.ToInt16(blok3_insert_tahunSumber.Text);
                blok3.lengkapData = blok3_insert_lengkapData.Value;
                blok3.akurasiData = blok3_insert_akurasiData.Value;
                blok3.mutakhirData =blok3_insert_mutakhirData.Value;
                blok3.kualitasData = blok3_insert_kualitasData.Value;

                form.insertTable(blok3.jenisData, blok3.tahunData, blok3.levelData, blok3.periodeData,blok3.perolehData, blok3.jenisSumber, blok3.judulSumber,blok3.tahunSumber ,blok3.lengkapData, blok3.akurasiData, blok3.mutakhirData,blok3.kualitasData);
                form.DataPerlu.Add(blok3);
                this.Close();

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
            } else if(blok3_insert_jenisData.Text.Length < 4)
            {
                e.Cancel = true;
                blok3_insert_jenisData.Focus();
                errorProvider1.SetError(blok3_insert_jenisData, "Panjang karakter harus lebih dari 3 karakter");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_jenisData, null);
            }
        }

        private void kodeData_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_tahunData.Text == String.Empty)
            {
                e.Cancel = true;
                blok3_insert_tahunData.Focus();
                errorProvider1.SetError(blok3_insert_tahunData, "Variabel ini harus diisi");
            }
            else if (blok3_insert_tahunData.Text.Length != 2)
            {
                e.Cancel = true;
                blok3_insert_tahunData.Focus();
                errorProvider1.SetError(blok3_insert_tahunData, "Panjang karakter harus 2 karakter");

            }
            else
            {
                if (Int32.TryParse(blok3_insert_tahunData.Text,out angka))
                {
                    e.Cancel = false;
                    errorProvider1.SetError(blok3_insert_tahunData, null);
                }
                else
                {
                    e.Cancel = true;
                    blok3_insert_tahunData.Focus();
                    errorProvider1.SetError(blok3_insert_tahunData, "Kode tidak Valid");
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

        private void blok3_insert_tahunData_Validating(object sender, CancelEventArgs e)
        {
            int tahunData;
            if (int.TryParse(blok3_insert_tahunData.Text, out tahunData))
            {
                if (tahunData < 1920 || tahunData > DateTime.Now.Year)
                {

                    e.Cancel = true;
                    blok3_insert_tahunData.Focus();
                    errorProvider1.SetError(blok3_insert_tahunData, $"Tahun Data harus diantara 1920 sampai {DateTime.Now.Year}");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(blok3_insert_tahunData, null);
                }
            }
            else
            {
                e.Cancel = true;
                blok3_insert_tahunData.Focus();
                errorProvider1.SetError(blok3_insert_tahunData, "Format tahun tidak valid");
            }
        }

        private void blok3_insert_tahunSumber_Validating(object sender, CancelEventArgs e)
        {
            int tahunSumber;
            if (int.TryParse(blok3_insert_tahunSumber.Text, out tahunSumber))
            {
                if (tahunSumber< 1920 || tahunSumber> DateTime.Now.Year)
                {

                    e.Cancel = true;
                    blok3_insert_tahunSumber.Focus();
                    errorProvider1.SetError(blok3_insert_tahunSumber, $"Tahun Data harus diantara 1920 sampai {DateTime.Now.Year}");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(blok3_insert_tahunSumber, null);
                }
            }
            else
            {
                e.Cancel = true;
                blok3_insert_tahunSumber.Focus();
                errorProvider1.SetError(blok3_insert_tahunSumber, "Format tahun tidak valid");
            }
        }

      

        private void blok3_insert_jenisSumber_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_jenisSumber.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok3_insert_jenisSumber.Focus();
                errorProvider1.SetError(blok3_insert_jenisSumber, "Harus dipilih salah satu !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_jenisSumber, null);
            }
        }

        private void blok3_insert_judulSumber_Validating(object sender, CancelEventArgs e)
        {
            if (blok3_insert_judulSumber.Text.Length <5)
            {
                e.Cancel = true;
                blok3_insert_judulSumber.Focus();
                errorProvider1.SetError(blok3_insert_judulSumber, "Harus diisi dan lebih dari 4 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok3_insert_judulSumber, null);
            }
        }
    }
}

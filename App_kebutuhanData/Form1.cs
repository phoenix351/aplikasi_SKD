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
                MessageBox.Show("Oke", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Buat objek Blok I
                Blok1Model blok1 = new Blok1Model();
                blok1.nama = blok1_nama.Text;
                blok1.umur = Convert.ToInt16(blok1_responden_nomor.Text);
                blok1.pendidikan = blok1_pendidikan.Text;
                blok1.jenisInstitusi = blok1_kategoriInstitusi.Text;

                blok1.institusi = blok1_institusi.Text;
                blok1.jeniskelamin = blok1_jenisKelamin.Text;
                blok1.layanan = blok1_fasilitas.Text;
                blok1.tujuan = blok1_manfaat.Text;

                // buat Objek BLok II


            }

            // Buat Variabel dan Validasi Blok I

            // Buat Variabel dan Validasi Blok II

            // Buat Variabel dan Validasi Blok III

        }

        private void blok1_nama_Validating(object sender, CancelEventArgs e)
        {

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
                errorProvider1.SetError(blok1_jenisKelamin, null);
            }
        }

        private void blok1_pendidikan_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_pendidikan, "Pendidikan terakhir", e);
        }

        private void blok1_institusi_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_institusi.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama Institusi harus diisi !");
            }
            else if (blok1_institusi.Text.Length < 3)
            {

                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama Institusi harus lebih dari 2 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_institusi, null);


            }
        }

        private void blok1_layanan_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_fasilitas.SelectedIndex == -1)
            {
                e.Cancel = true;
                blok1_fasilitas.Focus();
                errorProvider1.SetError(blok1_fasilitas, "Harus dipilih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_fasilitas, null);
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
                errorProvider1.SetError(blok1_manfaat, null);
            }
        }



        private void blok1_tahunLahir_Validating(object sender, CancelEventArgs e)
        {
            int tahunLahir;
            if (int.TryParse(blok1_tahunLahir.Text, out tahunLahir))
            {
                if (tahunLahir < 1920 || tahunLahir > DateTime.Now.Year)
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

        private void blok2_tabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void blok1_cacah_nama_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_cacah_nama.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_cacah_nama.Focus();
                errorProvider1.SetError(blok1_cacah_nama, "Nama Pencacah harus diisi !");
            }
            else if (blok1_cacah_nama.Text.Length < 2)
            {

                e.Cancel = true;
                blok1_cacah_nama.Focus();
                errorProvider1.SetError(blok1_cacah_nama, "Nama Pencacah harus lebih dari 1 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_cacah_nama, null);


            }
        }

        private void blok1_periksa_nama_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_periksa_nama.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_periksa_nama.Focus();
                errorProvider1.SetError(blok1_periksa_nama, "Nama Pemeriksa harus diisi !");
            }
            else if (blok1_periksa_nama.Text.Length < 2)
            {

                e.Cancel = true;
                blok1_periksa_nama.Focus();
                errorProvider1.SetError(blok1_periksa_nama, "Nama Pemeriksa lebih dari 1 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_periksa_nama, null);


            }
        }

        private void blok1_cacah_tanggal_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_cacah_tanggal.Value > DateTime.Now)
            {
                e.Cancel = true;
                blok1_cacah_tanggal.Focus();
                errorProvider1.SetError(blok1_cacah_tanggal, "Tanggal tidak boleh lebih dari hari ini ");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_cacah_tanggal, null);
            }
        }

        private void blok1_periksa_tanggal_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_periksa_tanggal.Value > DateTime.Now)
            {
                e.Cancel = true;
                blok1_periksa_tanggal.Focus();
                errorProvider1.SetError(blok1_periksa_tanggal, "Tanggal tidak boleh lebih dari hari ini");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_periksa_tanggal, null);
            }
        }

        private void blok1_responden_nomor_Validating(object sender, CancelEventArgs e)
        {
            if (blok1_responden_nomor.Text.Length < 1)
            {
                e.Cancel = true;
                blok1_responden_nomor.Focus();
                errorProvider1.SetError(blok1_responden_nomor, "Isian ini harus diisi !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_responden_nomor, null);
            }
        }



        private void blok1_email_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                var addr = new System.Net.Mail.MailAddress(blok1_email.Text);
                e.Cancel = false;
                errorProvider1.SetError(blok1_email, null);
            }
            catch
            {
                e.Cancel = true;
                errorProvider1.SetError(blok1_email, "Email tidak valid");
            }

        }

        public void validasiDropdown(ComboBox co, String namaVar, CancelEventArgs e)
        {
            if (co.SelectedIndex == -1)
            {
                e.Cancel = true;
                co.Focus();
                errorProvider1.SetError(co, $"{namaVar} harus dipilih salah satu !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(co, null);
            }
        }

        private void blok1_jenisKelamin_Validating_1(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_jenisKelamin, "Jenis Kelamin", e);
        }


        private void blok1_pekerjaan_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_pekerjaan, "Pekerjaan", e);
        }

        private void blok1_institusi_Validating_1(object sender, CancelEventArgs e)
        {
            if (blok1_institusi.Text == String.Empty)
            {
                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama Pemeriksa harus diisi !");
            }
            else if (blok1_institusi.Text.Length < 2)
            {

                e.Cancel = true;
                blok1_institusi.Focus();
                errorProvider1.SetError(blok1_institusi, "Nama Pemeriksa lebih dari 1 karakter !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_institusi, null);


            }
        }

        private void blok1_kategoriInstitusi_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_kategoriInstitusi, "Kategori Institusi", e);
        }

        private void blok1_manfaat_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_manfaat, "Isian Ini", e);
        }

        private void blok1_fasilitas_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_fasilitas, "Isian ini", e);
        }

        private void blok1_gunaq_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_gunaq, "Isian ini", e);
        }

        private void blok1_rujukanq_Validating(object sender, CancelEventArgs e)
        {
            validasiDropdown(blok1_rujukanq, "Isian ini", e);

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }


        private void blok1_layanan_Validating_1(object sender, CancelEventArgs e)
        {

            if (blok1_layanan.CheckedItems.Count < 1)
            {
                e.Cancel = true;
                blok1_layanan.Focus();
                errorProvider1.SetError(blok1_layanan, "Harus memilih salah satu atau lebih !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(blok1_layanan, null);
            }
        }

        private void blok1_next_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // Buat objek blok 1

                // Pindah ke Blok 2
                tabControl1.SelectedIndex = 1;
            }
        }
    }
}
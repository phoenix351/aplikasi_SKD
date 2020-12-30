using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_kebutuhanData
{
    public partial class Form1 : Form
    {
        int i = 1;

        private List<Blok3Model> dataPerlu = new List<Blok3Model>();
        private Blok2Model b2;
        private Blok1Model b1;
        private Pencacahan p;

        internal List<Blok3Model> DataPerlu { get => dataPerlu; set => dataPerlu = value; }

        public Form1()
        {
            InitializeComponent();

            
             blok1_cacah_nama.Text = "Nama Pencacah1";
            blok1_periksa_nama.Text = "Nama periksa1";
            blok1_responden_nomor.Text = "01";
            blok1_nama.Text = "Nama01";
            blok1_jenisKelamin.SelectedIndex = 1;
            blok1_pendidikan.SelectedIndex = 2;
            blok1_tahunLahir.Text = "2010";
            blok1_email.Text = "16.9351@stis.ac.id";
            blok1_pekerjaan.SelectedIndex = 1;
            blok1_institusi.Text = "PPP";
            blok1_kategoriInstitusi.SelectedIndex = 3;
            blok1_manfaat.SelectedIndex = 1;
            blok1_fasilitas.SelectedIndex = 1;
            blok1_gunaq.SelectedIndex = 1;
            blok1_rujukanq.SelectedIndex = 0;
            
        }
        public void insertTable(string jenisData, int tahunData, string levelData, string periodeData, int perolehData, int jenisSumber, string judulSumber, int tahunSumber, int lengkapData, int akurasiData, int mutakhirData, int kualitasData)
        {


            tabelData_blok2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tabelData_blok2.Controls.Add(new Label() { Text = i.ToString(), AutoSize = true }, 0, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = jenisData, AutoSize = true }, 1, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(tahunData), AutoSize = true }, 2, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = levelData, AutoSize = true }, 3, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = periodeData, AutoSize = true }, 4, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(perolehData), AutoSize = true }, 5, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(jenisSumber), AutoSize = true }, 6, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = judulSumber, AutoSize = true }, 7, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(tahunSumber), AutoSize = true }, 8, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(lengkapData), AutoSize = true }, 9, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(akurasiData), AutoSize = true }, 10, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(mutakhirData), AutoSize = true }, 11, tabelData_blok2.RowCount - 1);
            tabelData_blok2.Controls.Add(new Label() { Text = Convert.ToString(kualitasData), AutoSize = true }, 12, tabelData_blok2.RowCount - 1);
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

            // buat objek pencacaahan
            p = new Pencacahan();
            p.nomor_responden = $"{blok1_kodeWil.Text}{blok1_responden_nomor.Text}";
            p.pencacahan_nama = blok1_cacah_nama.Text;
            p.pencacahan_tanggal = blok1_cacah_tanggal.Text;
            p.periksa_nama = blok1_periksa_nama.Text;
            p.periksa_tanggal = blok1_periksa_tanggal.Text;

            // Buat objek blok 1
            b1 = new Blok1Model();
            b1.nama = blok1_nama.Text;
            b1.tahunLahir = Convert.ToInt16(blok1_tahunLahir.Text);
            b1.jeniskelamin = blok1_jenisKelamin.Text;
            b1.email = blok1_email.Text;
            b1.pendidikan = blok1_pendidikan.Text;
            b1.pekerjaan = blok1_pekerjaan.Text;
            b1.institusi = blok1_institusi.Text;
            b1.kategoriInstitusi = blok1_kategoriInstitusi.Text;
            b1.manfaat = blok1_manfaat.Text;
            b1.layanan = new List<string>();
            foreach (string item in blok1_layanan.CheckedItems)
            {
                b1.layanan.Add(item);
            }
            b1.fasilitas = blok1_fasilitas.Text;
            b1.gunaq = blok1_gunaq.Text;
            b1.rujukanq = blok1_rujukanq.Text;

            MessageBox.Show($"{b1.csvFormat()} \n {p.csvFormat()} true", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;



        }

        private void AddText(FileStream fs, string v)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(v);
            fs.Write(info, 0, info.Length);
        }

        private void button2_Click(object sender, EventArgs e)

        {
            tabControl1.SelectedIndex += tabControl1.SelectedIndex;
            b2 = new Blok2Model();

            b2.tingkatKepuasan = new List<int>();
            b2.tingkatKepuasan.Add(blok2_puas_q1.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q2.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q3.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q4.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q5.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q6.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q7.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q8.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q9.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q10.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q11.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q12.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q13.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q14.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q15.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q16.Value);
            b2.tingkatKepuasan.Add(blok2_puas_q17.Value);

            b2.tingkatKepentingan = new List<int>();
            b2.tingkatKepentingan.Add(blok2_penting_q1.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q2.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q3.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q4.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q5.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q6.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q7.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q8.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q9.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q10.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q11.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q12.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q13.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q14.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q15.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q16.Value);
            b2.tingkatKepentingan.Add(blok2_penting_q17.Value);


        }
        public void validasiSlider(TrackBar t, CancelEventArgs e)
        {
            if (t.Value < 1)
            {
                e.Cancel = true;
                t.Focus();
                errorProvider1.SetError(t, "Nilai tidak boleh 0");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(t, null);
            }
        }
        private void blok2_puas_q1_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q1, e);
        }

        private void blok2_puas_q2_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q2, e);
        }

        private void blok2_puas_q3_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q3, e);
        }

        private void blok2_puas_q4_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q4, e);
        }

        private void blok2_puas_q5_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q5, e);
        }

        private void blok2__puas_q6_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q6, e);
        }

        private void blok2__puas_q7_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q7, e);
        }

        private void blok2__puas_q8_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q8, e);
        }

        private void blok2__puas_q9_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q9, e);
        }

        private void blok2__puas_q10_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q10, e);
        }

        private void blok2__puas_q11_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q11, e);
        }

        private void blok2__puas_q12_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q12, e);
        }

        private void blok2__puas_q13_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q13, e);
        }

        private void blok2__puas_q14_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q14, e);

        }

        private void blok2__puas_q15_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q15, e);
        }

        private void blok2__puas_q16_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q16, e);
        }

        private void blok2__puas_q17_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q17, e);
        }

        private void blok2__penting_q1_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q1, e);
        }

        private void blok2__penting_q2_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q2, e);
        }

        private void blok2__penting_q3_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q3, e);
        }

        private void blok2__penting_q4_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q4, e);
        }

        private void blok2__penting_q5_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q5, e);
        }

        private void blok2__penting_q6_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q6, e);
        }

        private void blok2__penting_q7_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q7, e);
        }

        private void blok2__penting_q8_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q8, e);
        }

        private void blok2__penting_q9_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_penting_q9, e);
        }

        private void blok2__penting_q10_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q10, e);
        }

        private void blok2__penting_q11_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q11, e);
        }

        private void blok2__penting_q12_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q12, e);
        }

        private void blok2__penting_q13_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q13, e);
        }

        private void blok2__penting_q14_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q14, e);
        }

        private void blok2__penting_q15_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q15, e);
        }

        private void blok2__penting_q16_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q16, e);
        }

        private void blok2__penting_q17_Validating(object sender, CancelEventArgs e)
        {
            validasiSlider(blok2_puas_q17, e);
        }

        private void Sebelumnya_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= tabControl1.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataPerlu.Count >= 1)
            {
                string[] b3str = new string[DataPerlu.Count];
                int i = 0;
                foreach (Blok3Model b3 in DataPerlu)
                {
                    b3str[i] = b3.ToJson();
                    i += 1;

                }


               

                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] b3str = new string[DataPerlu.Count];
            string path = @"d:\MyTest.txt";
            if (DataPerlu.Count >= 1)
            {

                int i = 0;
                foreach (Blok3Model b3 in DataPerlu)
                {
                    b3str[i] = b3.ToJson();
                    i += 1;

                }

                
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Nama Pencacah;Tanggal Cacah;Nama Pemeriksa;Tanggal Periksa;Nomor Responden;Nama Responden;Tahun Lahir;E-mail;Jenis Kelamin;Pendidikan Terakhir;Pekerjaan;Institusi;Kategori Institusi;Pemanfaatan Data;Layanan yang digunakan;blok1_pertanyaan12;blok1_pertanyaan13;Tingkat Kepentingan;Tingkat Kepuasan;Blok3 (dalam json);Catatan");
                        sw.WriteLine($"{p.csvFormat()};{b1.csvFormat()};{b2.csvFormat()};[{string.Join(",", b3str)}];{blok4_catatan.Text}\n");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine($"{p.csvFormat()};{b1.csvFormat()};{b2.csvFormat()};[{string.Join(",", b3str)}];{blok4_catatan.Text}\n");


                    }
                }

                MessageBox.Show("Data Telah disubmit !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                
            }
        }
    }
}
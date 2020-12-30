using System.Collections.Generic;

namespace App_kebutuhanData
{
    internal class Blok1Model
    {
        public string nama { get; set; }
        public int tahunLahir { set; get; } // dalam tahun
        public string email { set; get; }
        public string jeniskelamin { set; get; }
        public string pendidikan { set; get; } // pendidikan terakhir yang ditamatkan
        public string pekerjaan { set; get; }
        public string institusi { set; get; } // nama asal institusi
        public string kategoriInstitusi { set; get; }
        public string manfaat { set; get; }
        public List<string> layanan { set; get; } 
        public string fasilitas { set; get; } // tujuan menggunakan data
        public string gunaq { set; get; }
        public string rujukanq { set; get; }

        public string csvFormat()
        {
            string csv = $"{this.nama};{this.tahunLahir};{this.email};{this.jeniskelamin};{this.pendidikan};{this.pekerjaan};{this.institusi};{this.kategoriInstitusi};{this.manfaat};[";
            foreach (string i in this.layanan)
            {
                csv += $" {i} ";
            }
            csv += $"];{this.fasilitas};{this.gunaq};{this.rujukanq}";
            return csv;
        }
        override
        public string ToString()
        {
            string r = $"Nama = {this.nama} \n";
            r += $"Tahun Lahir = {this.tahunLahir} \n";
            r += $"Email = {this.email} \n";
            r += $"Jenis Kelamin = {this.jeniskelamin} \n";
            r += $"Pendidikan Terakhir = {this.pendidikan} \n";
            r += $"Pekerjaan = {this.pekerjaan} \n";
            r += $"Institusi = {this.institusi} \n";
            r += $"Kategori institusi = {this.kategoriInstitusi} \n";
            r += $"Manfaat = {this.manfaat} \n";
            r += "Layanan yang digunakan : \n";
            foreach (string i in this.layanan)
            {
                r += $"\t {i} \n";
            }
            r += $"Fasilitas = {this.fasilitas} \n";
            r += $"Pertanyaan Guna Data = {this.gunaq} \n";
            r += $"Pertanyaan rujukan Data {this.rujukanq} \n";
            return r;
        }

    }
}
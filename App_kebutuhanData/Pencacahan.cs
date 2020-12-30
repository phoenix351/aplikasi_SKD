using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_kebutuhanData
{
    class Pencacahan
    {
        public string pencacahan_nama { set; get; }
        public string pencacahan_tanggal { set; get; }
        public string periksa_nama { set; get; }
        public string periksa_tanggal { set; get; }
        public string nomor_responden { set; get; }

        public string csvFormat()
        {
            string csv = $"{this.pencacahan_nama};{this.pencacahan_tanggal};{this.periksa_nama};{this.periksa_tanggal};{this.nomor_responden}"; 
            return csv;
        }
        override
        public string ToString()
    
        {
            string r = $"Nama Pencacah = {this.pencacahan_nama} \n";
            r += $"Tanggal caacah = {this.pencacahan_tanggal} \n";
            r += $"Nama Pemeriksa = {this.periksa_nama} \n";
            r += $"Tanggal periksa = {this.periksa_tanggal} \n";
            r += $"Nomor Responden = {this.nomor_responden} \n";
            return r;
            }
    }

}

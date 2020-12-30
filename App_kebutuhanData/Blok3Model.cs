using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_kebutuhanData
{
    class Blok3Model
    {
        public String jenisData { get; set; }
        public int tahunData { get; set; }
        public String levelData { get; set; }
        public String periodeData { get; set; }
        public int perolehData { get; set; }
        public int jenisSumber { get; set; }
        public String judulSumber { get; set; }
        public int tahunSumber { get; set; }
        public int lengkapData{ get; set; }
        public int akurasiData{ get; set; }
        public int mutakhirData { get; set; }
        public int kualitasData { get; set; }

        public string ToJson()
        {
            string json = "";
            json += $"{{'jenisData':{this.jenisData},'tahunData':{this.levelData},'periodeData':{this.periodeData},'perolehData':{this.perolehData},";
            json += $"'jenisSumber':{this.jenisSumber},'judulSumber':{this.judulSumber},'tahunSumber':{this.tahunSumber},'lengkapData':{this.lengkapData},";
            json += $"'akurasiData':{this.akurasiData},'mutakhirData':{this.mutakhirData},'kualitasData':{this.kualitasData}}}";
            return json;
        }
    }
}

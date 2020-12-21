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

            
            
            String jenisDatav = jenisData.Text;
            String kodeDatav = kodeData.Text;
            String levelDatav = levelData.Text;
            String periodeDatav = periodeData.Text;
            String sumberInformasiv = sumberInformasi.Text;
            String kelengkapanDatav = kelengkapanData.Text;
            String akurasiDatav = akurasiData.Text;
            String mutakhirDatav = mutakhirData.Text;
            

            // validasi form 

            // insert variabel ke tabel form parent
            

            form.insertTable(jenisDatav,kodeDatav,levelDatav,periodeDatav,sumberInformasiv,kelengkapanDatav,akurasiDatav,mutakhirDatav);
            
            

            // tutup dialog
            //this.Close();
        }
    }
}

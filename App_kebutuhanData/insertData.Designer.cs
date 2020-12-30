namespace App_kebutuhanData
{
    partial class insertData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.blok3_insert_perolehData = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.blok3_insert_jenisData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.blok3_insert_levelData = new System.Windows.Forms.TextBox();
            this.blok3_insert_periodeData = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.blok3_insert_mutakhirData = new System.Windows.Forms.TrackBar();
            this.blok3_insert_akurasiData = new System.Windows.Forms.TrackBar();
            this.blok3_insert_lengkapData = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.blok3_insert_jenisSumber = new System.Windows.Forms.ComboBox();
            this.blok3_insert_judulSumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.blok3_insert_kualitasData = new System.Windows.Forms.TrackBar();
            this.blok3_insert_tahunData = new System.Windows.Forms.MaskedTextBox();
            this.blok3_insert_tahunSumber = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_mutakhirData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_akurasiData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_lengkapData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_kualitasData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(685, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "BATAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(595, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OKE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kelengkapan Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Akurasi Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kemutakhiran Data";
            // 
            // blok3_insert_perolehData
            // 
            this.blok3_insert_perolehData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blok3_insert_perolehData.FormattingEnabled = true;
            this.blok3_insert_perolehData.Items.AddRange(new object[] {
            " Ya, Sesuai",
            "Ya, tidak sesuai",
            "Data tidak dapat diperoleh",
            "Tidak diperoleh",
            "Belum diperoleh"});
            this.blok3_insert_perolehData.Location = new System.Drawing.Point(363, 176);
            this.blok3_insert_perolehData.Name = "blok3_insert_perolehData";
            this.blok3_insert_perolehData.Size = new System.Drawing.Size(267, 21);
            this.blok3_insert_perolehData.TabIndex = 17;
            this.blok3_insert_perolehData.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apakah data dapat diperoleh";
            // 
            // blok3_insert_jenisData
            // 
            this.blok3_insert_jenisData.Location = new System.Drawing.Point(363, 4);
            this.blok3_insert_jenisData.Name = "blok3_insert_jenisData";
            this.blok3_insert_jenisData.Size = new System.Drawing.Size(267, 20);
            this.blok3_insert_jenisData.TabIndex = 8;
            this.blok3_insert_jenisData.Validating += new System.ComponentModel.CancelEventHandler(this.jenisData_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tahun Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level Data";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periode Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis data yang diperlukan";
            // 
            // blok3_insert_levelData
            // 
            this.blok3_insert_levelData.Location = new System.Drawing.Point(363, 90);
            this.blok3_insert_levelData.Name = "blok3_insert_levelData";
            this.blok3_insert_levelData.Size = new System.Drawing.Size(267, 20);
            this.blok3_insert_levelData.TabIndex = 10;
            this.blok3_insert_levelData.Validating += new System.ComponentModel.CancelEventHandler(this.levelData_Validating);
            // 
            // blok3_insert_periodeData
            // 
            this.blok3_insert_periodeData.Location = new System.Drawing.Point(363, 133);
            this.blok3_insert_periodeData.Name = "blok3_insert_periodeData";
            this.blok3_insert_periodeData.Size = new System.Drawing.Size(267, 20);
            this.blok3_insert_periodeData.TabIndex = 11;
            this.blok3_insert_periodeData.Validating += new System.ComponentModel.CancelEventHandler(this.periodeData_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_tahunSumber, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_periodeData, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_levelData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_jenisData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_mutakhirData, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_akurasiData, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_lengkapData, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_perolehData, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_jenisSumber, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_judulSumber, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_kualitasData, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.blok3_insert_tahunData, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Judul Sumber Data";
            // 
            // blok3_insert_mutakhirData
            // 
            this.blok3_insert_mutakhirData.Location = new System.Drawing.Point(363, 477);
            this.blok3_insert_mutakhirData.Name = "blok3_insert_mutakhirData";
            this.blok3_insert_mutakhirData.Size = new System.Drawing.Size(267, 45);
            this.blok3_insert_mutakhirData.TabIndex = 39;
            // 
            // blok3_insert_akurasiData
            // 
            this.blok3_insert_akurasiData.Location = new System.Drawing.Point(363, 434);
            this.blok3_insert_akurasiData.Name = "blok3_insert_akurasiData";
            this.blok3_insert_akurasiData.Size = new System.Drawing.Size(267, 36);
            this.blok3_insert_akurasiData.TabIndex = 40;
            // 
            // blok3_insert_lengkapData
            // 
            this.blok3_insert_lengkapData.Location = new System.Drawing.Point(363, 391);
            this.blok3_insert_lengkapData.Name = "blok3_insert_lengkapData";
            this.blok3_insert_lengkapData.Size = new System.Drawing.Size(267, 36);
            this.blok3_insert_lengkapData.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Jenis Sumber Data";
            // 
            // blok3_insert_jenisSumber
            // 
            this.blok3_insert_jenisSumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blok3_insert_jenisSumber.FormattingEnabled = true;
            this.blok3_insert_jenisSumber.Items.AddRange(new object[] {
            "Publikasi",
            "Data Mikro",
            "Peta",
            "Tabulasi Data",
            "Tabel di Website"});
            this.blok3_insert_jenisSumber.Location = new System.Drawing.Point(363, 219);
            this.blok3_insert_jenisSumber.Name = "blok3_insert_jenisSumber";
            this.blok3_insert_jenisSumber.Size = new System.Drawing.Size(267, 21);
            this.blok3_insert_jenisSumber.TabIndex = 45;
            this.blok3_insert_jenisSumber.Validating += new System.ComponentModel.CancelEventHandler(this.blok3_insert_jenisSumber_Validating);
            // 
            // blok3_insert_judulSumber
            // 
            this.blok3_insert_judulSumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blok3_insert_judulSumber.Location = new System.Drawing.Point(363, 262);
            this.blok3_insert_judulSumber.Name = "blok3_insert_judulSumber";
            this.blok3_insert_judulSumber.Size = new System.Drawing.Size(267, 26);
            this.blok3_insert_judulSumber.TabIndex = 46;
            this.blok3_insert_judulSumber.Validating += new System.ComponentModel.CancelEventHandler(this.blok3_insert_judulSumber_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Tahun Sumber Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Kualitas Data";
            // 
            // blok3_insert_kualitasData
            // 
            this.blok3_insert_kualitasData.Location = new System.Drawing.Point(363, 348);
            this.blok3_insert_kualitasData.Name = "blok3_insert_kualitasData";
            this.blok3_insert_kualitasData.Size = new System.Drawing.Size(267, 36);
            this.blok3_insert_kualitasData.TabIndex = 38;
            // 
            // blok3_insert_tahunData
            // 
            this.blok3_insert_tahunData.Location = new System.Drawing.Point(363, 47);
            this.blok3_insert_tahunData.Mask = "0000";
            this.blok3_insert_tahunData.Name = "blok3_insert_tahunData";
            this.blok3_insert_tahunData.Size = new System.Drawing.Size(267, 20);
            this.blok3_insert_tahunData.TabIndex = 49;
            this.blok3_insert_tahunData.ValidatingType = typeof(int);
            this.blok3_insert_tahunData.Validating += new System.ComponentModel.CancelEventHandler(this.blok3_insert_tahunData_Validating);
            // 
            // blok3_insert_tahunSumber
            // 
            this.blok3_insert_tahunSumber.Location = new System.Drawing.Point(363, 305);
            this.blok3_insert_tahunSumber.Mask = "0000";
            this.blok3_insert_tahunSumber.Name = "blok3_insert_tahunSumber";
            this.blok3_insert_tahunSumber.Size = new System.Drawing.Size(267, 20);
            this.blok3_insert_tahunSumber.TabIndex = 50;
            this.blok3_insert_tahunSumber.ValidatingType = typeof(int);
            this.blok3_insert_tahunSumber.Validating += new System.ComponentModel.CancelEventHandler(this.blok3_insert_tahunSumber_Validating);
            // 
            // insertData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "insertData";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_mutakhirData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_akurasiData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_lengkapData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blok3_insert_kualitasData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox blok3_insert_periodeData;
        private System.Windows.Forms.TextBox blok3_insert_levelData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox blok3_insert_jenisData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox blok3_insert_perolehData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar blok3_insert_mutakhirData;
        private System.Windows.Forms.TrackBar blok3_insert_akurasiData;
        private System.Windows.Forms.TrackBar blok3_insert_lengkapData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox blok3_insert_jenisSumber;
        private System.Windows.Forms.TextBox blok3_insert_judulSumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar blok3_insert_kualitasData;
        private System.Windows.Forms.MaskedTextBox blok3_insert_tahunSumber;
        private System.Windows.Forms.MaskedTextBox blok3_insert_tahunData;
    }
}
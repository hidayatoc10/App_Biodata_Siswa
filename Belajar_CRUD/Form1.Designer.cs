namespace Belajar_CRUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.judul = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.nama_siswa = new System.Windows.Forms.Label();
            this.textBox1_nama = new System.Windows.Forms.TextBox();
            this.textBox2_kelas = new System.Windows.Forms.TextBox();
            this.kelas = new System.Windows.Forms.Label();
            this.textBox3_jurusan = new System.Windows.Forms.TextBox();
            this.jurusan = new System.Windows.Forms.Label();
            this.mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            this.button1_submit = new System.Windows.Forms.Button();
            this.button2_reset = new System.Windows.Forms.Button();
            this.button3_keluar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5_delete = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(178, 33);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(329, 24);
            this.judul.TabIndex = 0;
            this.judul.Text = "DATA SISWA SMKN 17 JAKARTA";
            this.judul.Click += new System.EventHandler(this.label1_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // nama_siswa
            // 
            this.nama_siswa.AutoSize = true;
            this.nama_siswa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_siswa.Location = new System.Drawing.Point(60, 87);
            this.nama_siswa.Name = "nama_siswa";
            this.nama_siswa.Size = new System.Drawing.Size(120, 24);
            this.nama_siswa.TabIndex = 1;
            this.nama_siswa.Text = "Nama Siswa";
            // 
            // textBox1_nama
            // 
            this.textBox1_nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_nama.Location = new System.Drawing.Point(196, 84);
            this.textBox1_nama.Multiline = true;
            this.textBox1_nama.Name = "textBox1_nama";
            this.textBox1_nama.Size = new System.Drawing.Size(147, 32);
            this.textBox1_nama.TabIndex = 2;
            // 
            // textBox2_kelas
            // 
            this.textBox2_kelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_kelas.Location = new System.Drawing.Point(196, 136);
            this.textBox2_kelas.Multiline = true;
            this.textBox2_kelas.Name = "textBox2_kelas";
            this.textBox2_kelas.Size = new System.Drawing.Size(147, 32);
            this.textBox2_kelas.TabIndex = 4;
            // 
            // kelas
            // 
            this.kelas.AutoSize = true;
            this.kelas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelas.Location = new System.Drawing.Point(60, 139);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(61, 24);
            this.kelas.TabIndex = 3;
            this.kelas.Text = "Kelas";
            // 
            // textBox3_jurusan
            // 
            this.textBox3_jurusan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_jurusan.Location = new System.Drawing.Point(196, 195);
            this.textBox3_jurusan.Multiline = true;
            this.textBox3_jurusan.Name = "textBox3_jurusan";
            this.textBox3_jurusan.Size = new System.Drawing.Size(147, 32);
            this.textBox3_jurusan.TabIndex = 6;
            // 
            // jurusan
            // 
            this.jurusan.AutoSize = true;
            this.jurusan.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusan.Location = new System.Drawing.Point(60, 198);
            this.jurusan.Name = "jurusan";
            this.jurusan.Size = new System.Drawing.Size(81, 24);
            this.jurusan.TabIndex = 5;
            this.jurusan.Text = "Jurusan";
            // 
            // mySqlCommand2
            // 
            this.mySqlCommand2.CacheAge = 0;
            this.mySqlCommand2.Connection = null;
            this.mySqlCommand2.EnableCaching = false;
            this.mySqlCommand2.Transaction = null;
            // 
            // button1_submit
            // 
            this.button1_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_submit.Location = new System.Drawing.Point(380, 84);
            this.button1_submit.Name = "button1_submit";
            this.button1_submit.Size = new System.Drawing.Size(86, 32);
            this.button1_submit.TabIndex = 7;
            this.button1_submit.Text = "Submit";
            this.button1_submit.UseVisualStyleBackColor = true;
            this.button1_submit.Click += new System.EventHandler(this.button1_submit_Click);
            // 
            // button2_reset
            // 
            this.button2_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_reset.Location = new System.Drawing.Point(493, 84);
            this.button2_reset.Name = "button2_reset";
            this.button2_reset.Size = new System.Drawing.Size(86, 32);
            this.button2_reset.TabIndex = 8;
            this.button2_reset.Text = "Reset";
            this.button2_reset.UseVisualStyleBackColor = true;
            this.button2_reset.Click += new System.EventHandler(this.button2_reset_Click);
            // 
            // button3_keluar
            // 
            this.button3_keluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_keluar.Location = new System.Drawing.Point(442, 195);
            this.button3_keluar.Name = "button3_keluar";
            this.button3_keluar.Size = new System.Drawing.Size(86, 32);
            this.button3_keluar.TabIndex = 9;
            this.button3_keluar.Text = "Keluar";
            this.button3_keluar.UseVisualStyleBackColor = true;
            this.button3_keluar.Click += new System.EventHandler(this.button3_keluar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 310);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5_delete
            // 
            this.button5_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5_delete.Location = new System.Drawing.Point(493, 142);
            this.button5_delete.Name = "button5_delete";
            this.button5_delete.Size = new System.Drawing.Size(86, 32);
            this.button5_delete.TabIndex = 13;
            this.button5_delete.Text = "Delete";
            this.button5_delete.UseVisualStyleBackColor = true;
            this.button5_delete.Click += new System.EventHandler(this.button5_update_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(380, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "Update";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 284);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 32);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cari
            // 
            this.Cari.AutoSize = true;
            this.Cari.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.Location = new System.Drawing.Point(60, 288);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(49, 24);
            this.Cari.TabIndex = 17;
            this.Cari.Text = "Cari";
            this.Cari.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(629, 675);
            this.Controls.Add(this.Cari);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5_delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3_keluar);
            this.Controls.Add(this.button2_reset);
            this.Controls.Add(this.button1_submit);
            this.Controls.Add(this.textBox3_jurusan);
            this.Controls.Add(this.jurusan);
            this.Controls.Add(this.textBox2_kelas);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.textBox1_nama);
            this.Controls.Add(this.nama_siswa);
            this.Controls.Add(this.judul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Data Siswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label nama_siswa;
        private System.Windows.Forms.TextBox textBox1_nama;
        private System.Windows.Forms.TextBox textBox2_kelas;
        private System.Windows.Forms.Label kelas;
        private System.Windows.Forms.TextBox textBox3_jurusan;
        private System.Windows.Forms.Label jurusan;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private System.Windows.Forms.Button button1_submit;
        private System.Windows.Forms.Button button2_reset;
        private System.Windows.Forms.Button button3_keluar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5_delete;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Cari;
    }
}


using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belajar_CRUD
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string user = "root";
        string pw = "";
        string db = "belajar_crud_c#";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conn = "server=" + server + ";uid=" + user + ";pwd=" + pw + ";database=" + db;
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string retrieveData = "SELECT * FROM siswa";
            MySqlCommand cmd = new MySqlCommand(retrieveData, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_keluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_reset_Click(object sender, EventArgs e)
        {
            textBox1_nama.Text = "";
            textBox2_kelas.Text = "";
            textBox3_jurusan.Text = "";
        }

        private void button1_submit_Click(object sender, EventArgs e)
        {
            string conn = "server=" + server + ";uid=" + user + ";pwd=" + pw + ";database=" + db;
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string createData = "INSERT INTO siswa (nama_siswa, kelas, jurusan) VALUES ('" + textBox1_nama.Text + "','" + textBox2_kelas.Text + "','" + textBox3_jurusan.Text + "')";
            MySqlCommand cmd = new MySqlCommand(createData, con);
            int i = cmd.ExecuteNonQuery();
            MessageBox.Show("Data Berhasil Masuk");
            textBox1_nama.Text = "";
            textBox2_kelas.Text = "";
            textBox3_jurusan.Text = "";

            string retrieveData = "SELECT * FROM siswa";
            MySqlCommand cmdRefresh = new MySqlCommand(retrieveData, con);
            MySqlDataReader reader = cmdRefresh.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_tampil_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string conn = "server=" + server + ";uid=" + user + ";pwd=" + pw + ";database=" + db;
                MySqlConnection con = new MySqlConnection(conn);
                con.Open();
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                string idToDelete = dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString();
                string deleteData = "DELETE FROM siswa WHERE id = '" + idToDelete + "'";
                MySqlCommand cmd = new MySqlCommand(deleteData, con);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data berhasil dihapus.");
                    button4_tampil_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Gagal menghapus data.");
                }
                string retrieveData = "SELECT * FROM siswa";
                MySqlCommand cmdRefresh = new MySqlCommand(retrieveData, con);
                MySqlDataReader reader = cmdRefresh.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus.");
            }


        }

        private void button6_Click(object sender, EventArgs e)
{
    if (dataGridView1.SelectedRows.Count > 0)
    {
        int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
        string idToUpdate = dataGridView1.Rows[selectedRowIndex].Cells["id"].Value.ToString();
        string namaSiswa = dataGridView1.Rows[selectedRowIndex].Cells["nama_siswa"].Value.ToString();
        string kelas = dataGridView1.Rows[selectedRowIndex].Cells["kelas"].Value.ToString();
        string jurusan = dataGridView1.Rows[selectedRowIndex].Cells["jurusan"].Value.ToString();

        textBox1_nama.Text = namaSiswa;
        textBox2_kelas.Text = kelas;
        textBox3_jurusan.Text = jurusan;

        button1_submit.Text = "Update";
        button1_submit.Click -= button1_submit_Click;
        button1_submit.Click += (s, ev) =>
        {
            string conn = "server=" + server + ";uid=" + user + ";pwd=" + pw + ";database=" + db;
            MySqlConnection con = new MySqlConnection(conn);
            con.Open();
            string updateData = "UPDATE siswa SET nama_siswa = '" + textBox1_nama.Text + "', kelas = '" + textBox2_kelas.Text + "', jurusan = '" + textBox3_jurusan.Text + "' WHERE id = '" + idToUpdate + "'";
            MySqlCommand cmd = new MySqlCommand(updateData, con);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Data berhasil diupdate.");
                button4_tampil_Click(sender, e);
                textBox1_nama.Text = "";
                textBox2_kelas.Text = "";
                textBox3_jurusan.Text = "";
                button1_submit.Text = "Submit";
                button1_submit.Click -= button1_submit_Click;
                button1_submit.Click += button1_submit_Click;
            }
            else
            {
                MessageBox.Show("Gagal mengupdate data.");
            }
            string retrieveData = "SELECT * FROM siswa";
            MySqlCommand cmdRefresh = new MySqlCommand(retrieveData, con);
            MySqlDataReader reader = cmdRefresh.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;

            con.Close();
        };
    }
    else
    {
        MessageBox.Show("Pilih baris yang akan diupdate.");
    }
}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                string conn = "server=" + server + ";uid=" + user + ";pwd=" + pw + ";database=" + db;
                MySqlConnection con = new MySqlConnection(conn);
                con.Open();

                string searchData = "SELECT * FROM siswa WHERE nama_siswa LIKE '%" + keyword + "%' OR kelas LIKE '%" + keyword + "%' OR jurusan LIKE '%" + keyword + "%'";
                MySqlCommand cmd = new MySqlCommand(searchData, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }

                con.Close();
            }
            else
            {
                Form1_Load(sender, e);
            }
        }

        private void button1_cari_Click(object sender, EventArgs e)
        {
           
        }

    }
}

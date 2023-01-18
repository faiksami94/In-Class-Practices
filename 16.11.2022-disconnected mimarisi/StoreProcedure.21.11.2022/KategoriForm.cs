using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StoreProcedure._21._11._2022
{
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("KategoriEkle2", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@kategoriadi", textBox1.Text);
            command.Parameters.AddWithValue("@tanim", textBox2.Text);
            connection.Open();
            int etk = command.ExecuteNonQuery();
            connection.Close();
            if (etk > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                method();
            }
            else
            {
                MessageBox.Show("Kategori Eklenemedi");
                method();
            }
        }
        private void method()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("KategoriListele",connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource=table; 
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            SqlCommand command = new SqlCommand("KategoriSil", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["KategoriID"].Value);
            connection.Open();
            int etk = command.ExecuteNonQuery();
            connection.Close();
            if (etk > 0)
            {
                MessageBox.Show("Kategori Eklendi");
                method();
            }
            else
            {
                MessageBox.Show("Kategori Eklenemedi");
                method();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            berker form2 = new berker();
            this.Hide();
            form2.Show();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("KategoriListele", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void KategoriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form
        }
    }
}

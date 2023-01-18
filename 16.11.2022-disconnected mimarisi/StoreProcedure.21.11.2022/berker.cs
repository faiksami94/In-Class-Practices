using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProcedure._21._11._2022
{
    public partial class berker : Form
    {
        public berker()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)

        {

            SqlCommand cmd = new SqlCommand("prcUrunEkle2", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd.Parameters.AddWithValue("@fiyat", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@stok", numericUpDown2.Value);
            connection.Open();
            int etk = cmd.ExecuteNonQuery();
            connection.Close();
            if(etk>0)
            {
                MessageBox.Show("Ürün eklendi");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

            }
            else
            {
                MessageBox.Show("Ürün eklenemedi");
            }
        }
        private void Data()
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler" , connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UrunGuncelle2",connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["UrunID"].Value);
            command.Parameters.AddWithValue("@ad", textBox1.Text);
            command.Parameters.AddWithValue("@fiyat", numericUpDown1.Value);
            command.Parameters.AddWithValue("@stok", numericUpDown2.Value);
            connection.Open();
            int etk = command.ExecuteNonQuery();
            connection.Close();

            if (etk>0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells != null)
            {
                SqlCommand command = new SqlCommand("UrunSil2", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["UrunID"].Value);
                connection.Open();
                int etk = command.ExecuteNonQuery();
                if (etk > 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                }
                else
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urunler", connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Alan Geçersiz");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KategoriForm form2 = new KategoriForm();
            this.Hide();
            form2.Show();
        }
    }
}

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

namespace _16._11._2022_disconnected_mimarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True\r\n\r\n");
        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Urunler", connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["UrunID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adi = textBox1.Text;
            decimal fiyat = numericFiyat.Value;
            decimal stok = numericStok.Value;
            if (adi == ""| fiyat==0 | stok == 0)
            {
                MessageBox.Show("Tüm alanları eksiksiz doldurun !! ");
            }
            SqlCommand komut = new SqlCommand();
            komut.CommandText = string.Format("insert Urunler ( UrunAdi,BirimFiyati,HedefStokDuzeyi) values('{0}',{1},{2}) ", adi, fiyat, stok);
            komut.Connection = connection;
            connection.Open();
            int etkilenen=komut.ExecuteNonQuery();
            if (etkilenen>0)
            {
                MessageBox.Show("Kayıt Etkilendi!!");
                NewMethod();
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi !!! ");
            }

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kategoriform form = new kategoriform();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("update Urunler set urunAdi='{0}',BirimFiyati='{1}', HedefStokDuzeyi='{2}' where UrunID='{3}'", textBox1.Text, numericFiyat.Value, numericStok.Value, textBox1.Tag);
            command.Connection = connection;
            connection.Open();

            try
            {
                int etk = command.ExecuteNonQuery();
                connection.Close();
                if (etk>0)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    NewMethod();
                }
                else
                {
                    MessageBox.Show("Kayıt Güncellenirken hata oluştu!");
                }
            }
            catch(Exception ex)
            {
                connection.Close();
                MessageBox.Show("Kayıt Güncellenirken hata oluştu" + ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            textBox1.Tag = dataGridView1.CurrentRow.Cells["UrunID"].Value;
            numericFiyat.Value = (decimal)dataGridView1.CurrentRow.Cells["BirimFiyati"].Value;
            numericStok.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["HedefStokDuzeyi"].Value);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UrunID"].Value);
                SqlCommand cmd = new SqlCommand(string.Format("delete Urunler where UrunID='[0]'", id), connection);
                connection.Open();
                int etk = cmd.ExecuteNonQuery();
                connection.Close();
                if(etk > 0)
                {
                    MessageBox.Show("Kaydınız Silinmiştir");
                    NewMethod();
                }
                else
                {
                    MessageBox.Show("Kayıt oluşturulurken hata oluştu.");
                }
            }
        }
    }
}

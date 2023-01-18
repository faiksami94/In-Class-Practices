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

namespace adonet._3_17._11._2022
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UrunEkle", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UrunAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("@fiyat", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("@stok", numericUpDown2.Text);
            connection.Open();
            int etk = cmd.ExecuteNonQuery();
            if (etk > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                urunListesi();
            }
            else
            {
                MessageBox.Show("Ürün listeye eklenemedi!!!");
            }
            connection.Close();

        }
        private void urunListesi()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Urunler", connection);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urunListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand("UrunGuncelle");
            güncelle.CommandType = CommandType.StoredProcedure;
        }       

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand sil = new SqlCommand("UrunSil", connection);
                sil.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue
                //    ("@urunAdi", dataGridView1.CurrentRow.Cells["UrunAdi"].Value);

                //aynı adda kayıtlı urunleri silebilmek için procedure guncelledik
                //diagram satıs detay ile urunler tble fk ilişkisi vardı
                //o nedenle diğer baglantılı tablo kaydını silebilmek için
                //diagram baglantı tıklayıp delete kuralını cascade yaptık!!
                sil.Parameters.AddWithValue("@urunId", dataGridView1.CurrentRow.Cells["UrunID"].Value);

                connection.Open();
                int etk = sil.ExecuteNonQuery();
                connection.Close();
                if (etk > 0)
                {
                    MessageBox.Show("Kayıt Silinmiştir!!");
                    urunListesi();


                }
                else
                {
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu!");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void KategoriAdi()
        {

        }
    }
}
        
    

        


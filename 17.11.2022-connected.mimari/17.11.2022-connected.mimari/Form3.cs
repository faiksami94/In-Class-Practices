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


namespace _17._11._2022_connected.mimari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True");

        private void KategoriListesi()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("prc_KategoriListele", connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("KategoriEkle", connection);
            cmd.CommandType = CommandType.StoredProcedure;            
            cmd.Parameters.AddWithValue("@adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@tanim", textBox2.Text);
            connection.Open();
            int etk = cmd.ExecuteNonQuery();
            if (etk > 0)
            {
                MessageBox.Show("Kayıt Eklendi");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Ürün listeye eklenemedi!!!");
            }
            connection.Close();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            KategoriListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand sil = new SqlCommand("prc_KategoriSil", connection);
                sil.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue
                //    ("@urunAdi", dataGridView1.CurrentRow.Cells["UrunAdi"].Value);

                //aynı adda kayıtlı urunleri silebilmek için procedure guncelledik
                //diagram satıs detay ile urunler tble fk ilişkisi vardı
                //o nedenle diğer baglantılı tablo kaydını silebilmek için
                //diagram baglantı tıklayıp delete kuralını cascade yaptık!!
                sil.Parameters.AddWithValue("@kId", dataGridView1.CurrentRow.Cells["KategoriID"].Value);

                connection.Open();
                int etk = sil.ExecuteNonQuery();
                connection.Close();
                if (etk > 0)
                {
                    MessageBox.Show("Kayıt Silinmiştir!!");
                    KategoriListesi();
                }
                else
                {
                    MessageBox.Show("Kayıt Silinirken Hata Oluştu!");
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            SqlCommand cmd = new SqlCommand("prc_KategoriGuncelle", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            DataGridViewRow row = dataGridView1.CurrentRow;
            cmd.Parameters.AddWithValue("@id", row.Cells["KategoriID"].Value);
            cmd.Parameters.AddWithValue("@adi", row.Cells["KategoriAdi"].Value);
            cmd.Parameters.AddWithValue("@tanim", row.Cells["Tanimi"].Value);
            connection.Open();
            int etk = cmd.ExecuteNonQuery();
            if (etk > 0)
            {
                MessageBox.Show("Kayıt Güncellendi");
                KategoriListesi();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenmedi !!");
            }
            connection.Close();
        }
    }
}

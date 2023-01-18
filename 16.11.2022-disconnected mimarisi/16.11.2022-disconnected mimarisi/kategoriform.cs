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
    public partial class kategoriform : Form
    {
        public kategoriform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True\r\n\r\n");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("insert Kategoriler(KategoriAdi,Tanimi) values('{0}','{1}')", textBox1.Text, textBox2.Text);
            cmd.Connection = baglanti;
            baglanti.Open();
            int etkilenen = cmd.ExecuteNonQuery();
            baglanti.Close();
            if(etkilenen>0)
            {
                MessageBox.Show("Kayıt Eklendi bebeğiim allahım esirgesin!");
            }
            else
            {
                MessageBox.Show("Kaydınız Eklenemedi ayol!!");
            }
        }

       
        private void CategoryListOfBerker()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Kategoriler", baglanti);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["KategoriID"].Visible = false;

        }
        private void kategoriform_Load(object sender, EventArgs e)
        {
            CategoryListOfBerker();
        }
    }
}

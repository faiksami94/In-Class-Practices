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

namespace _17._11._2022_connected.mimari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True";
            SqlCommand kmt = new SqlCommand();
            kmt.CommandText = "select * from Kategoriler";
            kmt.Connection = connect;
            connect.Open();
            SqlDataReader reader = kmt.ExecuteReader();
            while (reader.Read())
            {
                string kategoriadi = reader["KategoriAdi"].ToString();
                string tanimi = reader["Tanimi"].ToString();
                
                kategoriListesi.Items.Add(String.Format("{0}-{1}", kategoriadi, tanimi));

            }
            connect.Close();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect.ConnectionString = "Data Source=DESKTOP-5U7CRQV;Initial Catalog=kuzeyyeli;Integrated Security=True";
            SqlCommand kmt = new SqlCommand();
            kmt.CommandText = "select * from Urunler";
            kmt.Connection = connect;
            connect.Open();
            SqlDataReader reader = kmt.ExecuteReader();
            while(reader.Read())
            {
                string isim = reader["UrunAdi"].ToString();
                string fiyat = reader["BirimFiyati"].ToString();
                string stok = reader["HedefStokDuzeyi"].ToString();
                urunlerListesi.Items.Add(String.Format("{0}-{1}-{2}",isim,fiyat,stok));

            }
            connect.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_24._11._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            Urunler urun = new Urunler();
            urun.UrunAdi = textBox1.Text;
            urun.BirimFiyati = numericUpDown1.Value;
            urun.HedefStokDuzeyi = (short)numericUpDown2.Value;
            urun.KategoriID = (int)comboBox1.SelectedValue;
            urun.TedarikciID = (int)comboBox2.SelectedValue;


            ctx.Urunlers.InsertOnSubmit(urun);
            ctx.SubmitChanges();

            MessageBox.Show("Ürün EKlendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext ctx = new DataClasses1DataContext();
            dataGridView1.DataSource = ctx.Urunlers;

            comboBox1.DataSource = ctx.Kategorilers;
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "KategoriID";

            comboBox2.DataSource = ctx.Tedarikcilers;
            comboBox2.DisplayMember = "SirketAdi";
            comboBox2.ValueMember = "TedarikciID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int urunid = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
            DataClasses1DataContext context = new DataClasses1DataContext();
            Urunler urn = context.Urunlers.SingleOrDefault(urun=>urun.UrunID ==urunid);

            context.Urunlers.DeleteOnSubmit(urn);
            context.SubmitChanges();
            MessageBox.Show("Ürün Silindi");
            dataGridView1.DataSource = context.Urunlers;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text = row.Cells["UrunAdi"].Value.ToString();
            textBox1.Tag = row.Cells["UrunID"].Value;

            comboBox1.SelectedValue = row.Cells["KategoriID"].Value;
            comboBox2.SelectedValue = row.Cells["TedarikciID"].Value;
            numericUpDown1.Value = (decimal)row.Cells["Fiyat"].Value;
            numericUpDown2.Value = (short)row.Cells["Stok"].Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int urunid = (int)dataGridView1.CurrentRow.Cells["UrunID "].Value;
            DataClasses1DataContext context = new DataClasses1DataContext();

            Urunler urn = context.Urunlers.SingleOrDefault(urun => urun.UrunID ==urunid);
            urn.UrunAdi = textBox1.Text;
            urn.BirimFiyati = numericUpDown1.Value;
            urn.HedefStokDuzeyi =(short)numericUpDown2.Value;
            urn.TedarikciID = (int)comboBox2.SelectedValue;
            urn.KategoriID = (int)comboBox1.SelectedValue;
            context.SubmitChanges();
            MessageBox.Show("Ürün Güncellendi");
            dataGridView1.DataSource = context.Urunlers;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            dataGridView1.DataSource=context.Urunlers.Where(x=>x.UrunAdi.Contains(textBox2.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            if (radioButton1.Checked)
            {   
                dataGridView1.DataSource=context.Urunlers.OrderBy(x => x.UrunAdi);
            }
            else if(radioButton2.Checked)
            {
                dataGridView1.DataSource = context.Urunlers.OrderByDescending(x => x.BirimFiyati);
            }
            else if( radioButton3.Checked)
            {
                dataGridView1.DataSource=context.Urunlers.OrderByDescending(x => x.HedefStokDuzeyi);
            }
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityLinQtoExpressions
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BTN_OrderBy_Click(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();
            var sonuc = from urun in dc.Urunlers orderby urun.BirimFiyati select urun;
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();
            /*
            var sonuc = from urun in dc.Urunlers orderby urun.BirimFiyati descending select urun;
            dataGridView1.DataSource = sonuc;
            */

            var sonuc2 = from satis in dc.Satislars orderby satis.SatisTarihi descending select satis;
            dataGridView1.DataSource = sonuc2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();
            DateTime tarih = Convert.ToDateTime(maskedTextBox1.Text);

            var sonuc = from satis in dc.Satislars
                        where satis.SatisTarihi == tarih
                        select satis;
            dataGridView1.DataSource = sonuc;
        }
    }
}

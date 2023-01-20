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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();

            var sonuc = from satis in dc.Satislars join personel in dc.Personellers 
                        on satis.PersonelID equals personel.PersonelID group satis 
                        by personel.Adi into grup select new
            {
                personelAdi = grup.Key,
                ToplamSatis = grup.Count(),
            };
            dataGridView2.DataSource = sonuc;
        }
    }
}

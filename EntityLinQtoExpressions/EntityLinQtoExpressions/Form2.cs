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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();
            /*
            var sonuc = from urun in dc.Urunlers
                        join satisdetay in dc.Satis_Detaylaris on urun.UrunID 
                        equals satisdetay.UrunID group satisdetay by urun.UrunAdi into grup
                        select new
                        {
                            UrunAdi = grup.Key,
                            ToplamSatis = grup.Sum(x => x.BirimFiyati * x.Miktar)
                        };
            dataGridView1.DataSource = sonuc;
            */

            //lazy load method
            
            var sonuc2 = from urun in dc.Urunlers
                         select new
                         {
                             urun.UrunAdi,
                             ToplamSatis = urun.Satis_Detaylaris.Any()? 
                             urun.Satis_Detaylaris.Sum(x => x.BirimFiyati * x.Miktar) : 0
                         };
            dataGridView1.DataSource = sonuc2;
            

        }
    }
}

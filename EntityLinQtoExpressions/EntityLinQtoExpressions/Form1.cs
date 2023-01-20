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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext dc = new KuzeyYeliDataContext();
            var result = from u in dc.Urunlers
                         join k in dc.Kategorilers on u.KategoriID equals k.KategoriID
                         select new
                         {
                             u.UrunAdi,
                             k.KategoriAdi,
                             u.BirimFiyati,
                             u.HedefStokDuzeyi
                         };
            dataGridView2.DataSource = result;
          
            
        }
    }
}

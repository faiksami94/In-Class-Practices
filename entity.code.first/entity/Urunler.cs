using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitycodefirst.entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunMarkasi { get; set; }
        public string UrunKategorisi { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }
        public Kategoriler Kategorilers { get; set; }
        public Musteriler Musterilers { get; set; }
    }
}

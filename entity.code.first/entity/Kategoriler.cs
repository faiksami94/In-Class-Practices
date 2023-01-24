using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace entitycodefirst.entity
{
    public class Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }

        

    }
}

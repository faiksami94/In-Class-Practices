using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitycodefirst.entity
{
    public class Musteriler
    {
        [Key]

        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriUnvani { get; set; }
        //public ICollection<Urunler> Urunlers { get; set; }

    }
}

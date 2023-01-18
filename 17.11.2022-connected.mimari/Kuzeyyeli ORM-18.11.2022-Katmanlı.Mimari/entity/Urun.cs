using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzeyyeli_ORM_18._11._2022_Katmanlı.Mimari.entity
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal BirimFiyati { get; set; }
        public short HedefStokDuzeyi { get; set; }
        public int KategoriID { get; set; }
        public int TedarikciID { get; set; }
        public string BirimdekiFiyat { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }







    }
}

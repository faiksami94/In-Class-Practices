using KuzeyYeli.ORM.ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.ORM.FACADE
{
    public class Urunler
    {
        public static DataTable Listele()
        {
            return Tools.Listele("UrunListele");
        }
        public static bool Ekle(Urun ENTITY)
        {
            SqlCommand command = new SqlCommand("urunEkle", Tools.Baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@urunAdi",ENTITY.UrunAdi);
            command.Parameters.AddWithValue("@fiyat", ENTITY.BirimFiyati);
            command.Parameters.AddWithValue("@stok", ENTITY.HedefStokDuzeyi);
            return Tools.ExecuteNonQuery(command); 
        }
        public static bool Sil(Urun Entity)
        {
            SqlCommand command = new SqlCommand("UrunSil", Tools.Baglanti);
            command.CommandType= CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@urunID", Entity.UrunID);
            return Tools.ExecuteNonQuery(command);
        }
        public static bool Guncelle(Urun Entity)
        {
            SqlCommand command = new SqlCommand("prc_urunGuncelle", Tools.Baglanti);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UrunID", Entity.UrunID);
            command.Parameters.AddWithValue("@ad", Entity.UrunAdi);
            command.Parameters.AddWithValue("@fiyat", Entity.BirimFiyati);
            command.Parameters.AddWithValue("@stok", Entity.HedefStokDuzeyi);
            return Tools.ExecuteNonQuery(command);
        }
    }
}

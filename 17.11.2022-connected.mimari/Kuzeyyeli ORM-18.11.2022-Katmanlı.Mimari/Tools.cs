using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Kuzeyyeli_ORM_18._11._2022_Katmanlı.Mimari
{
    class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["kuzeyyeli"].ConnectionString);
        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }
        public static bool ExecuteNonQuery(SqlCommand cmd)
        {

        }
    }
   
    
}

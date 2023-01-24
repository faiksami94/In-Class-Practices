using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace KuzeyYeli.ORM
{
    class Tools
    {
        private static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["KuzeyYeli"].ConnectionString);

        public static SqlConnection Baglanti
        {
            get { return baglanti; }
            set { baglanti = value; }
        }      


        public static DataTable Listele(string procedureName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(procedureName, Tools.Baglanti);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static bool ExecuteNonQuery (SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                if(command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }
    }
}

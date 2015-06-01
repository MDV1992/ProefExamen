using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netProefexamen.DAL
{
   public class DaLunch
    {
        static string connString = "Data Source=localhost;Initial Catalog=ProefExamenPr3;Integrated Security=True";


       public static void Get()
       {
           var conn = new SqlConnection(connString);
           var cmd = conn.CreateCommand();
           cmd.CommandText = "SELECT * FROM Lunch";
           conn.Open();
           cmd.ExecuteNonQuery();
           conn.Close();
       }
    }
}

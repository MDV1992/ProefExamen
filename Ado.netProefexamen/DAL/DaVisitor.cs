using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ado.netProefexamen.BO;

namespace Ado.netProefexamen.DAL
{
   public class DaVisitor
    {
       static string connString = "Data Source=localhost;Initial Catalog=ProefExamenPr3;Integrated Security=True";


       public static void Opslaan(Visitor visitor)
       {
           var conn = new SqlConnection(connString);
           var cmd = conn.CreateCommand();
           cmd.CommandText = "INSERT INTO Visitor (FirstName,LastName,EventID,Email,Notebook,LunchID,SubscribeDate) VALUES ('" + Visitor.Firstname + "','" + Visitor.Lastname + "','" + Visitor.EventiD + "' , '" + Visitor.Email + "' , '"+ Visitor.Notebook + "' ,'"+Visitor.LunchID+"', '"+Visitor.SubscribeDate+"')";
           conn.Open();
           cmd.ExecuteNonQuery();
           conn.Close();
       }
    }
}

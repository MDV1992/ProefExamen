using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Ado.netProefexamen.DAL;

namespace Ado.netProefexamen.BO
{
     public class Lunch
    {
         public int LunchID { get; set; }
         public string LunchOmschrijving { get; set; }

         public void Get()
         {
             DaLunch.Get();
         }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.netProefexamen.BO
{
    public class Visitor
    {
        public int VisitorID { get; set; }
        public int EventiD { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public bool Notebook { get; set; }
        public int LunchID { get; set; }
        public DateTime SubscribeDate { get; set; } 


    }
}

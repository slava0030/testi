using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoneApplication3
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SosialSecurityNumber { get; set; }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SosialSecurityNumber;
        }
    }
}

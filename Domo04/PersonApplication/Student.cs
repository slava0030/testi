using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Student : Person
    {
        public string StudentID { get; set; }
        public Student()
        {

        }
        public Student(string firstname, string lastname, string studentID)
            : base(firstname,lastname)
        {
            StudentID = studentID;
        }
        public void StudentMethod()
        {
            Console.WriteLine("This method belongs to student!");
        }
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }
}

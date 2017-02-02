using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Firstname = "Pekka";

            //create one new student object
            Student student = new Student();
            student.Firstname = "Teppo";
            student.Lastname = "Terävä";
            student.Adress = "Piippukatu 3";
            student.Age = 24;
            student.PhoneNumber = "01";
            student.StudentID = "g228";
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Kirsi", "Kernel", "D666");
            teacher.Age = 35;
            teacher.Adress = "Piippukatu 2";
            teacher.PhoneNumber = "055";
            Console.WriteLine(teacher.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();

            //olio ei ole aliluokan sisällä

            //student.PersonMethod();
            
        }
    }
}

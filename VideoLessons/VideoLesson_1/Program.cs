using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student._age = 5;

            Calculator(student);
            Console.WriteLine(student._age);
            Console.ReadLine();


        }

        static void Calculator(Student student)
        {
            student._age += 1;
        }
    }
}

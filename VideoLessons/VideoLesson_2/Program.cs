using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // // For STRUCT
            // var studentStruct0 = new StudentStruct();
            // var studentStruct1 = new StudentStruct(1);
            // var studentStruct2 = new StudentStruct(2, 3);

            // // Instance
            // studentStruct1.WriteAge();

            // // Static
            // StudentStruct.WriteAge(studentStruct1);

            // For Class
            var studentClass0 = new StudentClass();
            studentClass0.Age = 2;
            Console.WriteLine(studentClass0.Age);
            studentClass0.Mass = 3;
            studentClass0.WriteAge();

            var studentClass1 = new StudentClass(1);
            var studentClass2 = new StudentClass(2, "3");

            // Instance
            studentClass1.WriteAge();

            // Static
            StudentClass.WriteAge(studentClass1);
        }
    }
}

using System;

namespace VideoLesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TypeData
            // Разница в использовании примитивного и не примитивного типа данных.
            // int MyV1 = 256;

            // Int32 MyV2 = new Int32();
            // MyV2 = 256;
            #endregion TypeData

            var student = new Student {_age = 5};

            Calculator(student);

            Console.WriteLine(student._age);
            Console.ReadLine();


        }

        /// <summary>
        /// Calculator for icrease age
        /// </summary>
        /// <param name="student">Class student for change age</param>
        static void Calculator(Student student)
        {
            student._age += 1;
        }
    }
}

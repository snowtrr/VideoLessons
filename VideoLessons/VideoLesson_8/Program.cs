using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();

            IStudent<Animal> student = new Student<Animal>();

            // Invariant (param: out)
            IStudent<Animal> studentInv = new Student<Cat>();

            // Covariant (param: in)
            // IStudent<Cat> studentCov = new Student<Animal>();

            Action<int> setColor = SetColor;
            CreateColor(setColor, 1);

            Func<string, string> setFunc = SetFunc;
            Function(setFunc, "X+X=2X");
        }

        private static string SetFunc(string function)
        {
            var output = $"Function: {function}";
            return output;
        }

        private static void SetColor(int colorCode)
        {
            Console.WriteLine(colorCode);
            Console.ReadLine();
        }

        public static void CreateColor(Action<int> setColor, int code)
        {
            setColor(code);
        }

        public static void Function(Func<string, string> setFunc, string value)
        {
            Console.WriteLine(value);
            Console.WriteLine(setFunc(value));
            Console.ReadLine();
        }
    }
}

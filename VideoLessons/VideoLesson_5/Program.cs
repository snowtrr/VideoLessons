using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;

            singleton.Count = 100;

            TestSingleton();

            Console.ReadLine();
        }

        private static void TestSingleton()
        {
            Singleton singleton = Singleton.Instance;
            Console.WriteLine(singleton.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var inform = new Realizator();
            Console.WriteLine(inform.Age());

            IOne interfOne = inform;
            Console.WriteLine(interfOne.Age());
            Console.WriteLine(interfOne.Name());
            
        }
    }
}

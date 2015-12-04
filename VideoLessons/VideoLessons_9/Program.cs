using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLessons_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Progression progression = new Progression(9);

            foreach (int i in progression)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

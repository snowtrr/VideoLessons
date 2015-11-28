using System;

namespace VideoLesson_3
{
    class Program
    {
        private static void Main(string[] args)
        {
            // string mess = "Allo";
            var stringHelper = new StringHelper();

            // DELGATE
            // var d1 = new Delegate1(stringHelper.CountMes);
            // var d2 = new Delegate1(stringHelper.CountA);
            // ShowNum(d1, mess);
            // ShowNum(d2, mess);

            // Common DELEGATE
            // stringHelper.Waiting = Show;
            // stringHelper.WaitForSec(10);

            stringHelper.WaitingEvent += WaitingEvent;
            stringHelper.WaitForSecEvent(3);
            Console.ReadLine();
        }

        private static void WaitingEvent(object sender, WaitingEventArgs waitingEventArgs)
        {
            Console.WriteLine(waitingEventArgs.Message);
        }

        /// <summary>
        /// Print number of symbols
        /// </summary>
        /// <param name="del">Delegat-method</param>
        /// <param name="mess">message to count</param>
        private static void ShowNum(Delegate1 del, string mess)
        {
            Console.WriteLine(del(mess));
        }

        /// <summary>
        /// Show message in console
        /// </summary>
        /// <param name="mess">Message to show</param>
        private static void Show(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}

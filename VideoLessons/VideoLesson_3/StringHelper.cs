using System;
using System.Linq;
using System.Threading;

namespace VideoLesson_3
{
    /// <summary>
    /// Delegate
    /// </summary>
    /// <param name="mes">message to count</param>
    /// <returns></returns>
    public delegate int Delegate1(string mes);



    public class StringHelper
    {
        #region Methods of count

        /// <summary>
        /// Count all symbols
        /// </summary>
        /// <param name="mes">message to count</param>
        /// <returns></returns>
        public int CountMes(string mes)
        {
            return mes.Length;
        }

        /// <summary>
        /// Count symbol 'A'
        /// </summary>
        /// <param name="mes">message to count</param>
        /// <returns></returns>
        public int CountA(string mes)
        {
            return mes.Count(c => c == 'A');
        }

        public void ShowNumNew(Action<string> method, string mess)
        {
            method(string.Format("Ура наш делегат работает и говорит: {0}", mess));
        }

        public void WaitForSec(int sec)
        {
            if (Waiting != null)
            {
                for (int i = 0; i < sec; i++)
                {
                    Thread.Sleep(1000);
                    Waiting(string.Format("Прошло секунд: {0}", i + 1));
                }

                Waiting(string.Format("Ожидание завершено, прошло: {0}", sec));
            }
        }
        /// <summary>
        /// Method using Event
        /// </summary>
        /// <param name="sec">Input time</param>
        public void WaitForSecEvent(int sec)
        {
            for (int i = 0; i < sec; i++)
            {
                Thread.Sleep(1000);
                WaitingEvent(this, new WaitingEventArgs(string.Format("Прошло секунд: {0}", i + 1)));
            }

            WaitingEvent(this, new WaitingEventArgs(string.Format("Ожидание завершено, прошло: {0}", sec)));
        }
        // common delegate 
        public Action<string> Waiting { get; set; }
        // event
        public EventHandler<WaitingEventArgs> WaitingEvent;

        #endregion Methods of count
    }
}
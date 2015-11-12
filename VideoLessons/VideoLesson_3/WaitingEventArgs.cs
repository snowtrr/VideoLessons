using System;

namespace VideoLesson_3
{
    /// <summary>
    /// Class defining Event Arguments's properties
    /// </summary>
    public class WaitingEventArgs : EventArgs
    {
        public WaitingEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
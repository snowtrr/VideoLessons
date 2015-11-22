using System.Dynamic;

namespace VideoLesson_5
{
    public class Singleton
    {
        #region Field

        private static Singleton _singleton;

        #endregion Field

        #region Static Class Constructor

        static Singleton()
        {
            _singleton = new Singleton();
        }

        #endregion Static Class Constructor

        #region Class Constructor

        private Singleton()
        {
            
        }

        #endregion Class Constructor

        #region Property

        public static Singleton Instance
        {
            get {return _singleton; }
        }

        public int Count { get; set; }

        #endregion Property
    }
}
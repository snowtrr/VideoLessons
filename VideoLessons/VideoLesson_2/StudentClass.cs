using System;

namespace VideoLesson_2
{
    public class StudentClass
    {
        #region Fields

        private int _age;
        private int _mass;

        #endregion Fields

        #region Constructors

        public StudentClass()
        {
            _age = 0;
            _mass = 0;
        }

        public StudentClass(int age)
        {
            _age = age;
        }

        public StudentClass(int mass, string name):this(0)
        {
            _mass = mass;
        }

        #endregion Constructors

        #region Properties

        public int Age { get; set; }
        public int Mass { get; set; }

        #endregion Properties

        #region Public methods

        public void WriteAge()
        {
            _age = Age;
            Console.WriteLine("Age is:" + this._age);
        }

        /// <summary>
        /// Статический метод который выводит возраст
        /// </summary>
        /// <param name="studentClass">the <see cref="StudentClass"/></param>
        public static void WriteAge(StudentClass studentClass)
        {
            Console.WriteLine("Age is:" + studentClass._age);
        }

        #endregion Public methods 
    }
}
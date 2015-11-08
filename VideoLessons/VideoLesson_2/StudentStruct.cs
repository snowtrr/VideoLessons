using System;

namespace VideoLesson_2
{
    public struct StudentStruct
    {
        #region Fields

        private int _age;
        private int _mass;

        #endregion Fields

        #region Constructors

        public StudentStruct(int age)
        {
            this= new StudentStruct();
            _age = age;
        }

        public StudentStruct(int age, int mass)
        {
            this = new StudentStruct(age) {_mass = mass};
        }

        #endregion Constructors

        #region Public methods

        public void WriteAge()
        {
            Console.WriteLine("Age is:" + this._age);
        }

        /// <summary>
        /// Статический метод который выводит возраст
        /// </summary>
        /// <param name="studentStruct">the <see cref="StudentStruct"/></param>
        public static void WriteAge(StudentStruct studentStruct)
        {
            Console.WriteLine("Age is:" + studentStruct._age);
        }

        #endregion Public methods
    }
}
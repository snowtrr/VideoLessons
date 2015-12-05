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
            #region Enumarble
            // Progression progression = new Progression(9);

            // foreach (int i in progression)
            // {
            //     Console.WriteLine(i);
            // }
            #endregion Enumarble

            #region Collection
            // var collection = new StoreCollection(@"D:\projects\zalupa344157.txt");
            // collection.Add(1);
            // collection.Remove(1);
            // foreach (int i in collection)
            // {
            //     Console.WriteLine(i);
            // }
            #endregion Collection

            #region List
            // List<int> lst = new List<int>();

            // lst.Add(5);
            // lst.Count();
            // foreach (var i in lst)
            // {
            //     Console.WriteLine(i);
            // }
            // lst.Remove(5);
            // foreach (var i in lst)
            // {
            //     Console.WriteLine($"collection:{i}");
            // }
            #endregion List

            #region Dictionary
            Dictionary<int, Person> persons = new Dictionary<int, Person>();

            var person1 = new Person() {Id = 1, Name = "Петр"};
            var person2 = new Person() { Id = 2, Name = "Василий" };

            persons.Add(person1.Id, person1);
            persons.Add(person2.Id, person2);

            Person searchPerson;
            bool isExist = persons.TryGetValue(2, out searchPerson);

            if (isExist)
                Console.WriteLine(searchPerson.Name);
            #endregion Dictionary

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace VideoLessons_9
{
    public class StoreCollection : ICollection<int>
    {
        private readonly string _filePath;

        public StoreCollection(string filepath)
        {
            _filePath = filepath;
        }

        private string[] GetNumbers()
        {
            string line = File.ReadAllText(_filePath);

            string[] numbers = line.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries);

            return numbers;
        }

        public int Count
        {
            get
            {
                string[] numbers = GetNumbers();
                return numbers.Length;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(int item)
        {
            string[] nubmers = GetNumbers();

            if (nubmers.Length == 0)
                File.WriteAllText(_filePath, item.ToString());
            else
            {
                File.AppendAllText(_filePath, "," + item.ToString());
            }
        }

        public void Clear()
        {
            File.AppendAllText(_filePath, "");
        }

        public bool Contains(int item)
        {
            string[] numbers = GetNumbers();

            foreach (string number in numbers)
            {
                if (int.Parse(number) == item)
                    return true;
            }
            return false;
        }

        public void CopyTo(int[] array, int arrayIndex)
        {
            string[] numbers = GetNumbers();

            foreach (string number in numbers)
            {
                array[arrayIndex] = int.Parse(number);
                arrayIndex++;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            string[] numbers = GetNumbers();

            foreach (string number in numbers)
            {
                yield return int.Parse(number);
            }
        }

        public bool Remove(int item)
        {
            string[] numbers = GetNumbers();
            string line = File.ReadAllText(_filePath);

            int symbolPosition = 0;

            foreach (string number in numbers)
            {
                if (int.Parse(number) == item)
                {
                    if (numbers.Length == 1)
                    {
                        line = "";
                    }
                    else if(symbolPosition == 0)
                    {
                        line = line.Substring(symbolPosition + number.Length + 1); // substring?
                    }
                    else
                    {
                        line = line.Remove(symbolPosition - 1, number.Length + 1); // remove?
                    }

                    File.WriteAllText(_filePath, line);

                    return true;
                }

                symbolPosition += number.Length + 1;
            }

            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;

namespace VideoLessons_9
{
    public class Progression : IEnumerable<int>
    {
        private readonly int _itemCount;

        public Progression(int itemCount)
        {
            _itemCount = itemCount;
        }

        public IEnumerator<int> GetEnumerator()
        {
            // вместо целого класса, наследующего интерфейс enumerator,
            // можно создать данную конструкцию, она является аналогичной,
            // но позволяет не создавать класс
            int current = 1;
            for (int i = 0; i < _itemCount - 1; i++)
            {
                if (i == 0)
                    yield return 1; // yield возвращает значение в текущий класс, тем самым заменяя enumerator

                current += 3;
                yield return current;
            }
            // return new ProgressionIterator(_itemCount);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
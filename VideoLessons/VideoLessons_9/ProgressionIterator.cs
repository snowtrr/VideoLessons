using System;
using System.Collections;
using System.Collections.Generic;

namespace VideoLessons_9
{
    public class ProgressionIterator : IEnumerator<int>
    {
        private readonly int _itemCount;
        private int _position;
        private int _current;

        public ProgressionIterator(int itemCount)
        {
            _itemCount = itemCount;
            _position = 0;
            _current = 1;
        }

        public void Dispose()
        {
           // Заглушка. Осуществляет очистку неуправляемых ресурсов, к которым мы имели доступ 
        }

        public bool MoveNext()
        {
            if (_position > 0)
                _current += 3;

            if (_position < _itemCount)
            {
                _position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _position = 0;
            _current = 1;
        }

        public int Current
        {
            get { return _current; }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
}
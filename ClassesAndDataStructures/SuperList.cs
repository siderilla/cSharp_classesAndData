using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class SuperList<T>
    {
        private T[] _realArray;

        public SuperList()
        {
            _realArray = [];
        }

        public void Push(T item)
        {
            var originialLenght = _realArray.Length;
            var newArray = new T[originialLenght + 1];
            for (int i = 0; i < originialLenght; i++)
            {
                newArray[i] = _realArray[i];
            }
            newArray[originialLenght] = item;

            _realArray = newArray;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _realArray.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _realArray[index];
        }

        public T Pop()
        {
            int originialLenght = _realArray.Length;
            int newArrayLength = originialLenght - 1;
            var newArray = new T[newArrayLength];
            T element = _realArray[originialLenght - 1];

            for (int i = 0; i < newArrayLength; i++)
            {
                newArray[i] = _realArray[i];
            }
            _realArray = newArray;
            return element;
        }
    }
}

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

        public T Pop() //rimuove l'ultimo elemento dell'array
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

        public void Delete(int index)
        {
            if (index < 0 || index >= _realArray.Length)
                throw new IndexOutOfRangeException("Segmentation fault");

            int newLength = _realArray.Length - 1;
            var newArray = new T[newLength];

            int j = 0; // indice per scrivere nel nuovo array

            for (int i = 0; i < _realArray.Length; i++)
            {
                if (i == index)
                    continue; // salta l'elemento da rimuovere

                newArray[j] = _realArray[i];
                j++;
            }

            _realArray = newArray;
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_Task04
{
    public class MyList<T> : IMyList<T>, IEnumerable<T>
    {
        private T[] array;
        int position = -1; // сохраняем позицию 

        public MyList()
        {
            this.array = new T[0];
        }

        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                Console.Write($"[{index}] - индекс считывания за пределами List-a - ");
                return default(T);
            }
        }

        public void Add(T item)
        {
            // создаем новый массив с длиной +1
            T[] newArray = new T[array.Length + 1];
            // копируем старый в новый
            array.CopyTo(newArray, 0);
            // добавляем новый элемент в конец нового массива
            newArray[array.Length] = item;
            // и подставлем старому массиву ссылку нового
            array = newArray;

        }

        public int Count => array.Length;

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    position = -1;
                    yield break;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

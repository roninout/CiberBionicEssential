using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task04
{
    class ArrayList
    {

        // то же что и MyList, только заменил <T> на object
        private object[] array;

        public ArrayList()
        {
            this.array = new object[0];
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                Console.Write($"[{index}] - индекс считывания за пределами - ");
                return 0;
            }
        }


        public void Add(object item)
        {
            // создаем новый массив с длиной +1
            object[] newArray = new object[array.Length + 1];
            // копируем старый в новый
            array.CopyTo(newArray, 0);
            // добавляем новый элемент в конец нового массива
            newArray[array.Length] = item;
            // и подставлем старому массиву ссылку нового
            array = newArray;

        }

        public int Count => array.Length;

        // добавил новый метод Clear
        public void Clear()
        {
            array = new object[0];
        }
    }
}

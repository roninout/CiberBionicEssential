using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_Task04
{
    static class ExtMyList
    {
        // Расширяющий метод, копирующий элементы List в Array
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            // создаем новый массив размером List-а
            T[] array = new T[list.Count()];
            // переделал for в foreach
            int i = 0;
            foreach (var item in list)
            {
                array[i] = item;
                i++;
            }
            return array;
        }
    }
}

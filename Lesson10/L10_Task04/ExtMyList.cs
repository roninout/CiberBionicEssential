using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task04
{
    static class ExtMyList
    {
        // Расширяющий метод, копирующий элементы List в Array
        public static T[] GetArray<T>(this MyList<T> list)
        {
            // создаем новый массив размером List-а
            T[] array = new T[list.Count];
            for (int i = 0; i < list.Count; i++)
                array[i] = list[i];
            return array;
        }
    }
}

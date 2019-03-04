using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task02
{
    public interface IMyList<T>
    {
        int Count {get; } // длина массива
        void Add(T item); // добавить в массив
        T this[int index] {get; } // индексатор
    }
}

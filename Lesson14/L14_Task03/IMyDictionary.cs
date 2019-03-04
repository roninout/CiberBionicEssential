using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14_Task03
{
    public interface IMyDictionary<T1, T2>
    {
        int Lenght { get; }

        void Add(T1 key, T2 value); // добавить в словарь
        string this[int index] { get; } // индексатор
    }
}

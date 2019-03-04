using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_Task03
{
    public class MyDictionary<T1, T2> : IMyDictionary<T1, T2>
    {
        private T1[] key;
        private T2[] value;

        public MyDictionary()
        {
            key = new T1[0];
            value = new T2[0];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return string.Format($"{key[index]} - {value[index]}");
                return "Индекс считывания за пределами Dictionary";
            }
        }

        public string this[string index]
        {
            get
            {
                if (!string.IsNullOrEmpty(index))
                {
                    for (int i = 0; i < key.Length; i++)
                        if (index.Equals(key[i]))
                            return string.Format($"{key[i]} - {value[i]}");
                }
                return string.Format($"Перевод слова {index} - не найден");
            }
        }

        public void Add(T1 key, T2 value)
        {
            T1[] newKey = new T1[this.key.Length + 1];
            this.key.CopyTo(newKey, 0);
            newKey[this.key.Length] = key;
            this.key = newKey;

            T2[] newValue = new T2[this.value.Length + 1];
            this.value.CopyTo(newValue, 0);
            newValue[this.value.Length] = value;
            this.value = newValue;
        }

        public int Lenght => key.Length;
    }
}

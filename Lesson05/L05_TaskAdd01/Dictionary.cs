using System;

namespace Indexers
{
    class Dictionary
    {
        const int size = 5;

        private string[] ENG = new string[size];
        private string[] RU = new string[size];
        private string[] UA = new string[size];

        public Dictionary()
        {
            RU[0] = "книга"; UA[0] = "книга"; ENG[0] = "book";
            RU[1] = "ручка"; UA[1] = "ручка"; ENG[1] = "pen";
            RU[2] = "солнце"; UA[2] = "сонце"; ENG[2] = "sun";
            RU[3] = "яблоко"; UA[3] = "яблуко"; ENG[3] = "apple";
            RU[4] = "стол"; UA[4] = "стіл"; ENG[4] = "table";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < RU.Length; i++)
                    if ((RU[i] == index) || (UA[i] == index) || (ENG[i] == index))
                        return string.Format($"{RU[i]} - {UA[i]} - {ENG[i]}");

                return string.Format($"{index} - нет перевода для этого слова.");
            }
        }

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index < RU.Length) ? string.Format($"{RU[index]} - {UA[index]} - {ENG[index]}") : "Попытка обращения за пределы массива.";
            }
        }
    }
}

using System;
using System.Linq;
using L10_Task02;

namespace L11_Task02
{
    class CarCollection<T> : MyList<T>
    {
        MyList<string> nameCar;
        MyList<DateTime> yearCar;

        // в конструкторе создаем два пользовательских List-а с именем машины и годом выпуска
        public CarCollection()
        {
            this.nameCar = new MyList<string>();
            this.yearCar = new MyList<DateTime>();
        }

        // инексатор Int
        public new string this[int index]
        {
            get
            {
                if (index >= 0 && index < nameCar.Count)
                    return string.Format($"Машина [{nameCar[index]}] : выпуск [{yearCar[index]:y}]");
                return "Такой машины нет!!!";
            }
        }

        // инексатор String
        public string this[string index]
        {
            get
            {
                if (!string.IsNullOrEmpty(index))
                {
                    for (int i = 0; i < nameCar.Count; i++)
                        if (index.Equals(nameCar[i]))
                            return string.Format($"Машина [{nameCar[i]}] : выпуск [{yearCar[i]:y}]");
                }
                return "Такой машины нет!!!";
            }
        }

        // добавляем новую машину
        public void Add(string name, DateTime dateTime)
        {
            nameCar.Add(name);
            yearCar.Add(dateTime);
        }

        // свойство возвраащаемое количество машин
        public int Lenght
        {
            get
            {
                return nameCar.Count;  // используем свойство родителя
            }
        }

        // метод очистки автопарка
        public void Remove()
        {
            // у радителя этого метода не было поэтому
            // просто создаем новые экземпляры
            nameCar = new MyList<string>();
            yearCar = new MyList<DateTime>();
        }
    }
}

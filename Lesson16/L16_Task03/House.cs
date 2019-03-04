using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task03
{
    class House : ICloneable
    {
        // поля
        private string addres;
        private int doors;

        // конструктор
        public House(string adress, int doors)
        {
            this.addres = adress;
            this.doors = doors;
        }

        // свойства
        public string Adress { get => addres; set => addres = value; }
        public int Doors { get => doors; set => doors = value; }

        // реализуем поверхностное клонирование
        public object Clone()
        {
            return this;
        }

        // реализуем глубокое клонирование
        public House DeepClone()
        {
            return new House(this.Adress, this.Doors);
        }
    }
}

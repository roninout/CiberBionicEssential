using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House("Какой-то адресс", 5);
            House cloneHouse = house.Clone() as House;
            House deepCloneHouse = house.DeepClone();

            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"Оригинал: {house.Adress}, {house.Doors}");
            Console.WriteLine($"Клон: {cloneHouse.Adress}, {cloneHouse.Doors}");
            Console.WriteLine($"Супер клон: {deepCloneHouse.Adress}, {deepCloneHouse.Doors}");
            Console.WriteLine(new string('*', 50));

            cloneHouse.Adress = "Новый адресс";
            cloneHouse.Doors = 19;

            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"Оригинал: {house.Adress}, {house.Doors}");
            Console.WriteLine($"Клон: {cloneHouse.Adress}, {cloneHouse.Doors}");
            Console.WriteLine($"Супер клон: {deepCloneHouse.Adress}, {deepCloneHouse.Doors}");
            Console.WriteLine(new string('*', 50));

            Console.ReadKey();
        }
    }
}

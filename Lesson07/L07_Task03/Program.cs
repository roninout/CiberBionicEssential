using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            ClassTaker(myClass); // передаем ссылку
            StructTaker(myStruct); // передаем аргумент

            Console.WriteLine($"Класс = {myClass.change}");
            Console.WriteLine($"Структура = {myStruct.change}");

            Console.ReadKey();
        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L08_TaskAdd01
{
    class Program
    {
        static void Main(string[] args)
        {
            int year= 0, month = 0, day = 0;

            Console.Write("Введите месяц рождения: ");
            int.TryParse(Console.ReadLine(), out month);

            Console.Write("Введите день рождения: ");
            int.TryParse(Console.ReadLine(), out day);

            Console.WriteLine(new String('-', 25));

            // определяем сегодняшнюю дату
            DateTime dayToday = DateTime.Now;
            //определяем год по текущему месяцу
            year = dayToday.Month >= month ? year = dayToday.Year + 1 : dayToday.Year;
            // создаем дату ДР пользователя
            DateTime date = new DateTime(year, month, day);
            // высчитываем временной промежуток
            TimeSpan span = (date - dayToday);

            Console.WriteLine("Ваш день рождения:");
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(new String('-', 25));

            Console.WriteLine("До дня рождения осталось:");
            Console.WriteLine("Дней: " + span.Days);
            Console.WriteLine("Часов: " + span.Hours);
            Console.WriteLine("Минут: " + span.Minutes);
            Console.WriteLine("Секунд: " + span.Seconds);

            Console.ReadKey();
        }
    }
}

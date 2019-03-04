using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task04
{
    class OverData
    {
        private DateTime date;
        public static int countDays;

        // конструктор
        public OverData(DateTime date)
        {
            this.date = date;
        }

        // перегружаем оператор вычитания
        public static OverData operator -(OverData date1, OverData date2)
        {
            // промежуток между датами
            TimeSpan timeSpan = date1.date - date2.date;
            countDays = timeSpan.Days;
            // вычитаем количество дней от первой даты
            if (date2.date.Year <= date1.date.Year)
                return new OverData(date1.date.AddDays(-timeSpan.Days));
            else
                return new OverData(date1.date.AddDays(timeSpan.Days));
        }

        // перегружаем оператор сложения
        public static OverData operator +(OverData date1, OverData date2)
        {
            // промежуток между датами
            TimeSpan timeSpan = date1.date - date2.date;
            countDays = timeSpan.Days;
            // прибавляем количество дней к первой дате
            if (date2.date.Year <= date1.date.Year)
                return new OverData(date1.date.AddDays(timeSpan.Days));
            else
                return new OverData(date1.date.AddDays(-timeSpan.Days));
        }

        // метод сложения
        public static OverData Add(OverData day1, OverData day2)
        {
            return day1 + day2;
        }

        // метод вычитания
        public static OverData Sub(OverData day1, OverData day2)
        {
            return day1 - day2;
        }

        // перегружаем метод ToString
        public override string ToString()
        {
            return date.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L07_Task02
{
    class Schedule
    {
        public Train[] Trains { get; set; }

        public Schedule(int count)
        {
            Trains = new Train[Math.Abs(count)];
        }

        // Создаем запись о новом поезде
        private Train CreateTrainRecord()
        {
            string destination = "";
            int trainNumberber = 0;
            DateTime departureTime;
            string line = "";

            Console.Write("Введите номер поезда:");
            line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                trainNumberber = -1;
            else
                int.TryParse(line, out trainNumberber);

            Console.Write("Введите пункт назначения:");
            line = Console.ReadLine();
            destination = string.IsNullOrEmpty(line) ? "Пункт назаначения - отсутсвует!" : line;

            Console.Write("Введите время отправления:");
            line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                departureTime = DateTime.Now;
            else
                DateTime.TryParse(line, out departureTime);
            Console.WriteLine(new String('*', 50));

            return new Train(destination, trainNumberber, departureTime);
        }

        // Добавляем поезд в массив поездов
        public void AddTrainsToSchedule()
        {
            for (int i = 0; i < Trains.Length; i++)
                Trains[i] = CreateTrainRecord();
        }

        // Сортируем пузырьком
        private void SortedTrains()
        {
            for (int i = 0; i < Trains.Length - 1; i++)
            {
                for (int j = i + 1; j < Trains.Length; j++)
                {
                    if (Trains[i].TrainNumber > Trains[j].TrainNumber)
                    {
                        // сортировка
                        Train temp = Trains[i];
                        Trains[i] = Trains[j];
                        Trains[j] = temp;
                    }
                }
            }
        }

        // Отображаем расписание поездов с сортировкой
        public void Show()
        {
            // Сортируем перед выводом
            SortedTrains();

            foreach (Train train in Trains)
                Console.WriteLine($"№ поезда: {train.TrainNumber} - пункт назначения: {train.Destination} - время отправления: {train.DepartureTime}");
        }
    }
}

using System;

namespace L01_Task04
{
    class Figure
    {
        string name;
        Point[] point;

        public Figure(Point point0, Point point1, Point point2)
        {
            point = new Point[3];
            point[0] = point0;
            point[1] = point1;
            point[2] = point2;
            this.name = "триугольника";
        }

        public Figure(Point point0, Point point1, Point point2, Point point3)
        {
            point = new Point[4];
            point[0] = point0;
            point[1] = point1;
            point[2] = point2;
            point[3] = point3;
            this.name = "четырехугольника";
        }

        public Figure(Point point0, Point point1, Point point2, Point point3, Point point4)
        {
            point = new Point[5];
            point[0] = point0;
            point[1] = point1;
            point[2] = point2;
            point[3] = point3;
            point[4] = point4;
            this.name = "пятиугольника";
        }


        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
                sum += LengthSide(point[i], point[i + 1]);

            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.WriteLine($"Периметр {name} = {sum: #.##} см");
        }

        public string Name { get => name; }
    }
}

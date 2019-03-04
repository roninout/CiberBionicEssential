using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16_Task02
{
    class Block
    {
        private int side1; //сторона 1
        private int side2; //сторона 2
        private int side3; //сторона 3
        private int side4; //сторона 4

        // конструктор
        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        // переопределяем метод Equals
        public override bool Equals(object obj)
        {
            var block = obj as Block;
            return block != null &&
                   side1 == block.side1 &&
                   side2 == block.side2 &&
                   side3 == block.side3 &&
                   side4 == block.side4;
        }

        // переопределяем метод GetHashCode
        public override int GetHashCode()
        {
            var hashCode = -1497281178;
            hashCode = hashCode * -1521134295 + side1.GetHashCode();
            hashCode = hashCode * -1521134295 + side2.GetHashCode();
            hashCode = hashCode * -1521134295 + side3.GetHashCode();
            hashCode = hashCode * -1521134295 + side4.GetHashCode();
            return hashCode;
        }

        // переопределяем метод ToString
        public override string ToString()
        {
            return String.Format($"Бло состоит из следующих сторон. Cторона 1: {side1}, сторона 2: {side2}, сторона 3: {side3}, сторона 4: {side4}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03.Task02
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pupil_0, Pupil pupil_1)
        {
            pupils[0] = pupil_0;
            pupils[1] = pupil_1;
            pupils[2] = new GoodPupil();
            pupils[3] = new BadPupil();
        }

        public ClassRoom(Pupil pupil_0, Pupil pupil_1, Pupil pupil_2)
        {
            pupils[0] = pupil_0;
            pupils[1] = pupil_1;
            pupils[2] = pupil_2;
            pupils[3] = new BadPupil();
        }

        public ClassRoom(Pupil pupil_0, Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            pupils[0] = pupil_0;
            pupils[1] = pupil_1;
            pupils[2] = pupil_2;
            pupils[3] = pupil_3;
        }

        // Выводим информацию об учениках
        // Выводим свой метод
        public void Study()
        {
            foreach(Pupil p in pupils)
                p.Study();
        }

        public void Write()
        {
            foreach (Pupil p in pupils)
                p.Write();
        }

        public void Read()
        {
            foreach (Pupil p in pupils)
                p.Read();
        }

        public void Realax()
        {
            foreach (Pupil p in pupils)
                p.Relax();
        }
    }
}

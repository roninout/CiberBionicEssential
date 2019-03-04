namespace L08_Task03
{
    enum Post
    {
        PRESIDENT = 120,
        VICE_PRESIDENT = 110,
        DIRECTOR = 100,
        MANAGER = 90,
        ENGINEER = 85,
        CLEANER = 70
    }

    class Accauntant
    {
        public bool AscForBonus(Post worker, int hours)
        {
            return (int)hours >= (int)worker;
        }
    }
}
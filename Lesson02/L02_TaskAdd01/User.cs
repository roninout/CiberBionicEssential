using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_TaskAdd01
{
    class User
    {
        string login;
        string name;
        string surname;
        int age = 10;
        public readonly DateTime dateTime;

        public string Login
        {
            get
            {
                if (login == null)
                    return "Пусто";
                return login;
            }
            set => login = value;
        }
        public string Name
        {
            get
            {
                if (name == null)
                    return "Пусто";
                return name;
            }
            set => name = value;
        }
        public string Surname
        {
            get
            {
                if (surname == null)
                    return "Пусто";
                return surname;
            }
            set => surname = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }


        //Конструктор по умолчанию
        public User()
        {
            this.dateTime = DateTime.Now;
        }
        // И другой конструктор
        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.dateTime = DateTime.Now;
        }


    }
}

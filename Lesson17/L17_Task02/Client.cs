using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L17_Task02
{
    class Client
    {
        public Client(string name, string model, string phone)
        {
            Name = name;
            Model = model;
            Phone = phone;
        }

        public string Name { get; }
        public string Model { get; }
        public string Phone { get; }

    }
}

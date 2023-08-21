using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Microwave : Device, IMicrowave
    {
        private string _producer;
        private int _power;
        private string _color;
        public Microwave(string name, string desc, string producer, int power, string color) : base(name, desc) 
        {
            _producer = producer;
            _power = power;
            _color = color;
        }

        override public void Sound() { Console.WriteLine("*wwwwww*, *peep*, *peep*"); }
        override public void Desc() { Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nВиробник: {_producer}\nПотужність: " +
            $"{_power} Вт\nКолір: {_color}"); }
    }
}

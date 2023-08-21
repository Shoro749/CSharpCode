using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Car : Device, ICar
    {
        private string _producer;
        private int _speed;
        private string _color;
        public Car(string name, string desc, string producer, int speed, string color) : base(name, desc)
        {
            _producer = producer;
            _speed = speed;
            _color = color;
        }

        override public void Sound() { Console.WriteLine("*buzz*"); }
        override public void Desc() {
            Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nВиробник: {_producer}\nШвидкість: " +
            $"{_speed} Км/год\nКолір: {_color}");
        }
    }
}

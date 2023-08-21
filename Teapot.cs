﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Teapot : Device, ITeapot
    {
        private string _producer;
        private int _power;
        private string _color;
        public Teapot(string name, string desc, string producer, int power, string color) : base(name, desc) 
        {
            _producer = producer;
            _power = power;
            _color = color;
        }

        override public void Sound() { Console.WriteLine("*gurgle*");  }
        override public void Desc() { Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nВиробник: {_producer}\nПотужність: " +
            $"{_power} Вт\nКолір: {_color}"); }
    }
}

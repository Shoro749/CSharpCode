using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Violin : MusicInstrument, IViolin
    {
        private string _type;
        private int _size;
        private int _price;
        private string _producer;

        public Violin(string name, string desc, string type, int size, int price, string producer) : base(name, desc)
        {
            _size = size;
            _type = type;
            _producer = producer;
            _price = price;
        }
        override public void Desc() {
            Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nТип: {_type}\nРозмір: {_size}\nЦіна: {_price}\n" +
                $"Виробник: {_producer}\n"); }
        override public void Sound() { Console.WriteLine("Звук: виразний!"); }
        override public void History() { Console.WriteLine("Прототипами скрипки були арабський ребаб" +
            " і німецька рота, злиття яких і утворило віолу." +
            " Форми скрипки сформувались до XVI століття, в цьому столітті і на початку наступного," +
            " XVII, творили майстри скрипок сімейства Аматі." +
            " Їх інструменти відрізняються прекрасною формою і чудовим матеріалом."); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Cello : MusicInstrument, ICello
    {
        private string _type;
        private int _size;
        private int _price;
        private string _producer;

        public Cello(string name, string desc, string type, int size, int price, string producer) : base(name, desc)
        {
            _size = size;
            _type = type;
            _producer = producer;
            _price = price;
        }
        override public void Desc()
        {
            Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nТип: {_type}\nРозмір: {_size}\nЦіна: {_price}\n" +
                $"Виробник: {_producer}\n");
        }
        override public void Sound() { Console.WriteLine("Звук: глибокий і багатий!"); }
        override public void History()
        {
            Console.WriteLine("У XVII—XVIII століттях зусиллями видатних музичних майстрів " +
                "італійських шкіл була створена класична модель віолончелі з твердо усталеним розміром корпусу.");
        }
    }
}

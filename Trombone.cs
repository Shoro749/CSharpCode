using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Trombone : MusicInstrument, ITrombone
    {
        private string _type;
        private int _price;
        private string _producer;

        public Trombone(string name, string desc, string type, int price, string produser) : base(name, desc) 
        {
            _type = type;
            _price = price;
            _producer = produser;
        }

        override public void Desc()
        {
            Console.WriteLine($"Назва: {_name}\nОпис: {_desc}\nТип: {_type}\nЦіна: {_price}\n" +
                $"Виробник: {_producer}\n");
        }
        override public void Sound() { Console.WriteLine("Звук: динамічний і насичений!"); }
        override public void History()
        {
            Console.WriteLine("Історія тромбона налічує кілька століть, це один з найдавніших " +
                "представників сімейства мідних духових і народних інструментів." +
                " Перше документальне свідчення існування тромбонів відноситься до 15 століття," +
                " але у істориків є всі підстави вважати, що предки цього інструменту набагато давніше.");
        }
    }
}

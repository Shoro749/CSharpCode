using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*Створити базовий клас «Музичний інструмент» і похідні
//класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель». За
//допомогою конструктора, встановити назву до кожного
//музичного інструменту і його характеристики.
//Реалізуйте для кожного з класів методи:
//■ Sound — видає звук музичного інструменту (пишемо
//текстом у консоль);
//■ Show — відображає назву музичного інструменту;
//■ Desc — відображає опис музичного інструменту;
//■ History — відображає історію створення музичного
//інструменту.*/

namespace CSharpCode
{
    public class MusicInstrument : IMusicInstrument
    {
        public string _name;
        public string _desc;

        public MusicInstrument(string name, string desc)
        {
            _name = name;
            _desc = desc;
        }

        public void Show() { Console.WriteLine("\n" + _name); }
        virtual public void Desc() { Console.WriteLine(_desc); }
        virtual public void Sound() { Console.WriteLine("Nothing!"); }
        virtual public void History() { Console.WriteLine("Nothing!"); }
    }
}

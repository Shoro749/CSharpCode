using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Запрограмуйте клас Money (об'єкт класу оперує однією
валютою) для роботи з грошима.
У класі мають бути передбачені: поле для зберігання
цілої частини грошей (долари, євро, гривні тощо) і поле
для зберігання копійок (центи, євроценти, копійки тощо)
Реалізувати методи виведення суми на екран, завдання
значень частин.
На базі класу Money створити клас Product для роботи
з продуктом або товаром. Реалізувати метод, який дозволяє
зменшити ціну на задане число.
Для кожного з класів реалізувати необхідні методи і
поля.*/

namespace CSharpCode
{
    public class Money : IMoney
    {
        public int _dollars;
        public int _cents;
        public int _euro;
        public int _eurocents;
        public int _hrivnias;
        public int _kopiyki;

        public Money()
        {
            _dollars = 0;
            _cents = 0;
            _euro = 0;
            _eurocents = 0;
            _hrivnias = 0;
            _kopiyki = 0;
        }

        public Money(int dollars, int cents, int euro, int eurocents, int hrivnias, int kopiyki)
        {
            _dollars = dollars;
            _cents = cents;
            _euro = euro;
            _eurocents = eurocents;
            _hrivnias = hrivnias;
            _kopiyki = kopiyki;
        }


        public void Tostring()
        {
            Console.WriteLine($"{_dollars} доларів і {_cents} центів!\n{_euro} євро і {_eurocents} євроцентів!\n" +
                $"{_hrivnias} гривень і {_kopiyki} копійок!\n");
        }
    }
}

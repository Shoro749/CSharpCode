using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Product : Money, IProduct
    {
        private int _price;
        private int _pricecent;
        private bool _bought;

        //public Product(int price, int pricecent)
        //{
        //    _price = price;
        //    _pricecent = pricecent;
        //    _bought = false;
        //}

        public Product(int dollars, int cents, int euro, int eurocents, int hrivnias, int kopiyki)
        : base(dollars, cents, euro, eurocents, hrivnias, kopiyki)
        {
            _price = 1000;
            _pricecent = 5;
            _bought = false;
        }

        public void Discount()
        {
            Console.Write($"Введіть на скільки зменшити ціну продукту(ціна зараз: {_price} євро): ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (_price - num < 0) 
            {
                throw new Exception("\nЦіна не може бути меншою за нуль!");
            }
            else
            {
                _price -= num;
                Console.WriteLine($"\nВаша ціна була успішно змінено ({_price} євро)!");
            }
        }

        public void Payment()
        {
            Console.WriteLine("Виберіть варіант оплати!");
            Console.WriteLine("1) В євро\n2) В доларах\n3) В гривнях");
            Console.Write("Введіть свій вибір: ");
            int select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    if (_price > _euro) { throw new Exception("Недостатньо на рахунку!"); }
                    else 
                    { 
                        _euro -= _price;
                        if (_pricecent > _eurocents)
                        {
                            _euro -= 1;
                            _eurocents = (_eurocents + 100) - _pricecent;
                        }
                        else { _eurocents -= _pricecent; }
                        _bought = true;
                    }

                    break;

                case 2:
                    _price = _price * 2;
                    if (_price > _dollars) { throw new Exception("Недостатньо на рахунку!"); }
                    else
                    {
                        _dollars -= _price;
                        if (_pricecent > _cents)
                        {
                            _dollars -= 1;
                            _cents = (_cents + 100) - _pricecent;
                        }
                        else { _cents -= _pricecent; }
                        _bought = true;
                    }
                    _price = _price / 2;
                    break;

                case 3:
                    _price = _price * 36;
                    if (_price > _hrivnias) { throw new Exception("Недостатньо на рахунку!"); }
                    else
                    {
                        _hrivnias -= _price;
                        if (_pricecent > _kopiyki)
                        {
                            _hrivnias -= 1;
                            _kopiyki = (_kopiyki + 100) - _pricecent;
                        }
                        else { _kopiyki -= _pricecent; }
                        _bought = true;
                    }
                    _price = _price / 36;
                    break;
            }
        }

        public void ProductInfo()
        {
            Console.WriteLine($"\nЦіна: {_price} євро!\nКулено: {_bought}!\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Кредитна картка». Клас повинен містити:
■ Номер картки;
■ ПІБ власника;
■ Термін дії карти;
■ PIN;
■ Кредитний ліміт;
■ Сума грошей.
Створіть потрібний набір способів класу. Реалізуйте
події для наступних ситуацій:
■ Поповнення рахунку;
■ Витрата коштів з рахунку;
■ Старт використання кредитних коштів;
■ Досягнення ліміту заданої суми грошей;
■ Зміна PIN.*/

namespace CSharpCode
{
    public class CreditCard
    {
        private string _number;
        private string _fullName;
        private string _validityPeriod;
        private int _PIN;
        private int _creditLimit;
        private int _sum;

        public delegate void Massages(string massage);
        public event Massages? Notify;

        public CreditCard(string number, string fullName, string validityPeriod, int pIN, int creditLimit, int sum)
        {
            _number = number;
            _fullName = fullName;
            _validityPeriod = validityPeriod;
            _PIN = pIN;
            _creditLimit = creditLimit;
            _sum = sum;
        }

        public void Add(int num)
        {
            _sum += num;
            Console.ForegroundColor = ConsoleColor.Green;
            Notify += (massage) => Console.WriteLine(massage);
            Notify?.Invoke("Ваш баланс поповнено на " + num + " доларів!");
            Console.ResetColor();
        }

        public void Subtraction(int num)
        {
            Console.Write("Введіть PIN: ");
            if (_PIN == Convert.ToInt32(Console.ReadLine()))
            {
                if (_sum > num)
                {
                    _sum -= num;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Notify += (massage) => Console.WriteLine(massage);
                    Notify?.Invoke("З вашого балансу було знято суму на " + num + " доларів!");
                    Console.ResetColor();
                }
                else 
                {
                    if (_creditLimit > num - _sum)
                    {
                        num -= _sum;
                        _sum = 0;
                        _creditLimit -= num;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Notify += (massage) => Console.WriteLine(massage);
                        Notify?.Invoke("(C) З вашого балансу було знято суму на " + num + " доларів!");
                        Console.ResetColor();
                    }
                    else { Console.WriteLine("Ви досягли ліміту!"); }
                }
            }
            else { Console.WriteLine("Неправильний PIN!"); }
        }

        public void ChangePIN(int num)
        {
            if (num < 4 && num > 4) { Console.WriteLine("Неправильний PIN!"); }
            else 
            { 
                _PIN = num;
                Notify += (massage) => Console.WriteLine(massage);
                Notify?.Invoke("Ваш PIN був успішно змінений!");
            }
        }

        public void Info()
        {
            Console.WriteLine($"Номер карти: {_number}\nПІБ: {_fullName}\nТермін дії: {_validityPeriod}\n" +
                $"PIN: {_PIN}\nКредитний ліміт: {_creditLimit}\nСума: {_sum}\n");
        }
    }
}

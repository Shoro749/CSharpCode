using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть користувацький тип «Автомобіль», який зберігатиме
                таку інформацію:
                 назва;
                 виробник;
                 рік випуску.
                Для двох масивів автомобілів реалізуйте операції:
                 різниця масивів;
                 перетин масивів;
                 об'єднання масивів.
                Критерій для виконання операцій – виробник.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Car car1 = new Car("Car", "Ford", 2010);
                Car car2 = new Car("Car_2.0", "Honda", 2007);
                Car car3 = new Car("Car_1.0", "Fiat-Chrysler", 2016);
                Car car4 = new Car("Car_1", "Honda", 2000);
                Car car5 = new Car("Car_", "BMW", 2020);
                Car car6 = new Car("Car_2.0", "Ford", 2016);
                Car[] cars1 = { car1, car2, car3 };
                Car[] cars2 = { car4, car5, car6 };
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
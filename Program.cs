using System.Text;
using System.Xml.Linq;

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
                Car car5 = new Car("Car_", "BMW", 2016);
                Car car6 = new Car("Car", "Ford", 2010);

                Car[] cars1 = { car1, car2, car3 };
                Car[] cars2 = { car4, car5, car6 };

                Console.WriteLine("1) Різниця масивів");
                Console.WriteLine("2) Перетин масивів");
                Console.WriteLine("3) Об'єднання масивів");
                Console.Write("Введіть свій вибір: ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.Write("\nРезультат:\n");
                        var result1 = cars1.Except(cars2);
                        foreach(var car in result1)
                        {
                            Console.WriteLine($"\nНазва: {car.Name}\nВиробник: {car.Manufacturer}\nРік випуску: {car.Year}");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("\nРезультат:\n");
                        var result2 = cars1.Intersect(cars2);
                        foreach (var car in result2)
                        {
                            Console.WriteLine($"\nНазва: {car.Name}\nВиробник: {car.Manufacturer}\nРік випуску: {car.Year}");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("\nРезультат:\n");
                        var result3 = cars1.Union(cars2);
                        foreach (var car in result3)
                        {
                            Console.WriteLine($"\nНазва: {car.Name}\nВиробник: {car.Manufacturer}\nРік випуску: {car.Year}");
                        }
                        Console.WriteLine();
                        break;
                }
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
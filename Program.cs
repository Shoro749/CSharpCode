using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
/*Для масиву рядків з назвою міст, реалізуйте наступні запити:
 Отримати весь масив міст.
 Отримати міста з довжиною назви, що дорівнює заданому
 Отримати міста, назви яких починаються з літери A.
 Отримати міста, назви яких закінчуються літерою M.
 Отримати міста, назви яких починаються з літери N і
закінчуються літерою K.
 Отримати міста, назви яких починаються з Ne. Результат
відсортувати за спаданням.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] cities = new string[6] { "Atlanta", "Stockholm", "New York", "Kyiv", "Netanya", "London" };

                Console.WriteLine("1) Отримати весь масив міст");
                Console.WriteLine("2) Отримати міста з довжиною назви, що дорівнює заданому");
                Console.WriteLine("3) Отримати міста, назви яких починаються з літери A");
                Console.WriteLine("4) Отримати міста, назви яких закінчуються літерою M");
                Console.WriteLine("5) Отримати міста, назви яких починаються з літери N і закінчуються літерою K");
                Console.WriteLine("6) Отримати міста, назви яких починаються з Ne");
                Console.Write("Введіть свій вибір: ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.WriteLine("\nМіста:");
                        var c = from city in cities
                                select city;
                        foreach(var city in c)
                        {
                            Console.Write(" " + city);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("\nВведіть довжину назви міста: ");
                        sel = Convert.ToInt32(Console.ReadLine());
                        var c1 = from city in cities
                                 where city.Length == sel
                                 select city;
                        foreach (var city in c1)
                        {
                            Console.Write(" " + city);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        char letter = 'A';
                        Console.Write("\nМіста які начинаться на А:");
                        var c2 = from city in cities
                                 where char.ToUpper(city[0]) == char.ToUpper(letter)
                                 select city;
                        foreach (var city in c2)
                        {
                            Console.Write(" " + city);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        char letter2 = 'm';
                        Console.Write("\nМіста які закінчуються на М:");
                        var c3 = from city in cities
                                 where char.ToUpper(city[city.Length-1]) == char.ToUpper(letter2)
                                 select city;
                        foreach (var city in c3)
                        {
                            Console.Write(" " + city);
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        letter = 'N';
                        letter2 = 'k';
                        Console.Write("\nМіста які починаються на N і закінчуються на K:");
                        var c4 = from city in cities
                                 where char.ToUpper(city[0]) == char.ToUpper(letter)
                                 where char.ToUpper(city[city.Length - 1]) == char.ToUpper(letter2)
                                 select city;
                        foreach (var city in c4)
                        {
                            Console.Write(" " + city);
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        letter = 'N';
                        letter2 = 'e';
                        Console.Write("\nМіста які починаються на Ne:");
                        var c5 = from city in cities
                                 where char.ToUpper(city[0]) == char.ToUpper(letter)
                                 where char.ToUpper(city[1]) == char.ToUpper(letter2)
                                 orderby city descending
                                 select city;
                        foreach (var city in c5)
                        {
                            Console.Write(" " + city);
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
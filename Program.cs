using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Для двох масивів цілих реалізуйте такі запити:
                 Отримати різницю двох масивів (елементи першого масиву,
                яких немає у другому).
                 Отримати перетин масивів (спільні елементи для обох
                масивів).
                 Отримати об'єднання масивів (елементи обох масивів без
                дублікатів).
                 Отримати вміст першого масиву без повторень.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int[] arr1 = { 2, 5, 9, 9, 7 };
                int[] arr2 = { 1, 6, 9 };

                Console.Write("Масив 1: ");
                foreach (int i in arr1) { Console.Write(i + " "); }
                Console.Write("\nМасив 2: ");
                foreach (int i in arr2) { Console.Write(i + " "); }

                Console.WriteLine("\n\n1) Отримати різницю двох масивів (елементи першого масиву, яких немає у другому)");
                Console.WriteLine("2) Отримати перетин масивів (спільні елементи для обох масивів)");
                Console.WriteLine("3) Отримати об'єднання масивів (елементи обох масивів без дублікатів)");
                Console.WriteLine("4) Отримати вміст першого масиву без повторень");
                Console.Write("Введіть свій вибір: ");
                int sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        var result = arr1.Except(arr2);
                        Console.Write("Результат:");
                        foreach (var num in result)
                        {
                            Console.Write(" " + num);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        var result1 = arr1.Intersect(arr2);
                        Console.Write("Результат:");
                        foreach (var num in result1)
                        {
                            Console.Write(" " + num);
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        var result2 = arr1.Union(arr2);
                        Console.Write("Результат:");
                        foreach (var num in result2)
                        {
                            Console.Write(" " + num);
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        var result3 = arr1.Distinct();
                        Console.Write("Результат:");
                        foreach (var num in result3)
                        {
                            Console.Write(" " + num);
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
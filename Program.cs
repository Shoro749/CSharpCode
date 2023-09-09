using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Для масиву рядків реалізуйте користувальницьке сортування.
                Сортування має працювати за кількістю символів (за зростанням
                та спаданням). Наприклад, якщо сортування проводиться за
                спаданням, потрібно повернути рядки з максимальною
                довжиною в порядку зменшення довжини.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] arr = { "Apple", "Computer", "TV", "Ocean", "Jellyfish"};
                Console.WriteLine("Масив: ");
                foreach (string str in arr) { Console.Write(str + " "); }
                Console.WriteLine("\n");
                Console.Write("1) Сортувати за зростанням\n2) Сотувати за спаданням\nВведіть свій вибір: ");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        var result = from word in arr
                                     orderby word.Length ascending
                                     select word;
                        foreach (var item in result) { Console.WriteLine(item); }
                        break;

                    case 2:
                        var result1 = from word in arr
                                     orderby word.Length descending
                                     select word;

                        Console.WriteLine();
                        foreach (var item in result1) { Console.WriteLine(item); }
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
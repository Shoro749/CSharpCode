using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Для масиву прізвищ виконайте наступні завдання:
                 Перевірте, чи всі прізвища мають довжину більше трьох
                символів. Використовуйте метод All.
                 Перевірте, чи всі прізвища мають довжину більше трьох і
                менше десяти символів. Використовуйте метод All.
                 Перевірте, чи є в масиві хоча б одне прізвище, яке
                починається з літери «W». Використовуйте метод Any.
                 Перевірте, чи є в масиві хоча б одне прізвище, яке
                закінчується на літеру «Y». Використовуйте метод Any.
                 Перевірте, чи є у масиві прізвище Orange. Використовуйте
                метод Contains.
                 Відобразіть перше прізвище з довжиною 6. Використовуйте
                метод FirstOrDefault.
                 Відобразіть останнє прізвище з довжиною менше 15.
                Використовуйте метод LastOrDefault.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] surnames = { "Johnson", "Scott", "Holland", "Favreau", "Walker", "Yaroshenko" };

                Console.WriteLine("1) Перевірка, чи всі прізвища мають довжину більше трьох: ");
                var result = surnames.All(surname => surname.Length > 3);
                Console.WriteLine(result);

                Console.WriteLine("\n2) Перевірте, чи всі прізвища мають довжину більше трьох і менше десяти символів: ");
                var result1 = surnames.All(surname => surname.Length > 3 && surname.Length < 10);
                Console.WriteLine(result1);

                Console.WriteLine("\n3) Перевірте, чи є в масиві хоча б одне прізвище, яке починається з літери «W»: ");
                var result2 = surnames.Any(surname => surname.StartsWith("W"));
                Console.WriteLine(result2);

                Console.WriteLine("\n4) Перевірте, чи є в масиві хоча б одне прізвище, яке закінчується на літеру «Y»: ");
                var result3 = surnames.Any(surname => surname.StartsWith("Y"));
                Console.WriteLine(result3);

                Console.WriteLine("\n5) Перевірте, чи є у масиві прізвище Orange: ");
                var result4 = surnames.Contains("Orange");
                Console.WriteLine(result4);

                Console.WriteLine("\n6) Відобразіть перше прізвище з довжиною 6: ");
                var result5 = surnames.FirstOrDefault(surname => surname.Length == 6);
                Console.WriteLine(result5);

                Console.WriteLine("\n7) Відобразіть останнє прізвище з довжиною менше 15: ");
                var result6 = surnames.LastOrDefault(surname => surname.Length < 15);
                Console.WriteLine(result6);
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
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть користувацький тип «Журнал», який зберігатиме таку
                інформацію:
                 Назва журналу.
                 Жанр.
                 Кількість сторінок у випуску.
                 Дата видання.
                      Для масиву журналів виконайте наступні завдання:
                 Перевірте, чи у всіх журналів кількість сторінок більше 30.
                Використовуйте метод All.
                 Перевірте, чи всі журнали у жанрі «Політика», «Мода» або
                «Спорт». Використовуйте метод All.
                 Перевірте, чи є хоча б один журнал у жанрі «Сад та город».
                Використовуйте метод Any.
                 Перевірте, чи є в масиві хоча б один журнал у жанрі
                «Рибалка». Використовуйте метод Any.
                 Перевірте, чи є в масиві журнали про «Полювання».
                Використовуйте метод Contains.Зверніть увагу, що
                «Полювання» може бути написано у будь - якому регістрі.Тож
                ігноруйте регістр.
                 Відобразіть перший журнал з роком випуску 2022.
                Використовуйте метод FirstOrDefault.
                 Відобразіть останній журнал, назва якого починається зі
                слова «Авто». Використовуйте метод LastOrDefault.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Magazine magazine1 = new Magazine("Вісник", "Наука", 50, 2023);
                Magazine magazine2 = new Magazine("Мистецтво", "Культура", 60, 2022);
                Magazine magazine3 = new Magazine("Спортекспрес", "Спорт", 40, 2020);
                Magazine magazine4 = new Magazine("Мода і стиль", "Мода", 70, 2023);
                Magazine magazine5 = new Magazine("Гастроном", "Кулінарія", 45, 2023);
                Magazine[] magazines = new Magazine[] { magazine1, magazine2, magazine3, magazine4, magazine5 };

                Console.WriteLine("Перевірте, чи у всіх журналів кількість сторінок більше 30:");
                var result = magazines.All(magazine => magazine.Pages > 30);
                Console.WriteLine(result);

                Console.WriteLine("\nПеревірте, чи всі журнали у жанрі «Політика», «Мода» або «Спорт»:");
                var result1 = magazines.All(magazine => magazine.Genre == "Політика" || magazine.Genre == "Мода" || magazine.Genre == "Спорт");
                Console.WriteLine(result1);

                Console.WriteLine("\nПеревірте, чи є хоча б один журнал у жанрі «Сад та город»:");
                var result2 = magazines.Any(magazine => magazine.Genre == "Сад та город");
                Console.WriteLine(result2);

                Console.WriteLine("\nПеревірте, чи є в масиві хоча б один журнал у жанрі «Рибалка»:");
                var result3 = magazines.Any(magazine => magazine.Genre == "Рибалка");
                Console.WriteLine(result3);

                Console.WriteLine("\nПеревірте, чи є в масиві журнали про «Полювання»:");
                var result4 = magazines.Any(magazine => magazine.Genre == "Полювання");
                Console.WriteLine(result4);

                Console.WriteLine("\nВідобразіть перший журнал з роком випуску 2022:");
                var result5 = magazines.FirstOrDefault(magazine => magazine.PublicationDate == 2022);
                if (result5 != null) { Console.WriteLine(result5.Name); }
                else { Console.WriteLine("Нема журналів які мають рік випуску 2022!"); }

                Console.WriteLine("\nВідобразіть останній журнал, назва якого починається зі слова «Авто»:");
                var result6 = magazines.LastOrDefault(magazine => magazine.Name.StartsWith("Авто"));
                if (result6 != null) { Console.WriteLine(result6); }
                else { Console.WriteLine("Нема журналів які починаються на «Авто»!"); }
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
using System;
using System.Text;

namespace CSharpCode
{
    internal class Program
    {
        static void CurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Поточний час: " + currentTime.ToString("HH:mm:ss"));
        }

        static string StrCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime.ToString("HH:mm:ss");
        }

        static bool Checking1(string date) => StrCurrentTime() == date;

        static void CurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Поточна дата: " + currentDate.ToString("dd.MM.yyyy"));
        }

        static void CurrentDayOfWeek()
        {
            DateTime currentDayOfWeek = DateTime.Now;
            Console.WriteLine("Поточний день тижня: " + currentDayOfWeek.DayOfWeek);
        }

        static void AreaTriangle()
        {
            Console.Write("Введіть основу трикутника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть висоту трикутника: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площа: " + (a *h)/2);
        }

        static int AreaTriangle2(int a, int h)
        {
            return (a * h) / 2;
        }

        static void AreaRectangle()
        {
            int[] arr = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Введіть сторону прямокутника: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Площа: " + arr[0] * arr[1]);
        }

        static int AreaRectangle2(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            try
            {
                /*Створіть набір методів:
                ■ Метод відображення поточного часу;
                ■ Метод відображення поточної дати;
                ■ Метод відображення поточного дня тижня;
                ■ Метод для підрахунку площі трикутника;
                ■ Метод для підрахунку площі прямокутника.
                Для реалізації проєкту використовуйте делегати: Action, Predicate, Func.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Action action = CurrentTime;
                action += CurrentDate;
                action += CurrentDayOfWeek;
                action += AreaTriangle;
                action += AreaRectangle;
                action();

                Console.WriteLine("\nPredicate\n");

                Predicate<string> predicate = Checking1;
                Console.WriteLine(predicate.Invoke("01.08.2014"));

                Console.WriteLine("\nFunc\n");

                Func<int, int, int> func = AreaTriangle2;
                func += AreaRectangle2;
                foreach (var item in func.GetInvocationList())
                {
                    Console.WriteLine(item.DynamicInvoke(5, 4));
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